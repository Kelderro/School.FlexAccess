using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GrFingerXLib;

namespace FlexAccess
{
    public partial class frmMain : Form
    {
      // Fingerprint class defineren
      private FingerReader.FingerPrint myFP;
      private String strServerIP;
      private Int32 intServerPort;
      private static FlexClient connectie = new FlexClient();
      private String[] GrFingerCtrlSensors = new String[0];

      public frmMain(String strServerIP, int intServerPort)
      {
        this.strServerIP = strServerIP;
        this.intServerPort = intServerPort;

        InitializeComponent();

        // FingerPrint class initialiseren
        myFP = new FingerReader.FingerPrint(pbFingerPrint);

        // Library initialiseren
        myFP.InitializeGrFinger(axGrFingerXCtrl1);
        lblFlexAccessServerValue.Text = strServerIP + ":" + Convert.ToString(intServerPort);
      }

      private void axGrFingerXCtrl1_SensorPlug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent e)
      {
        String[] tmpSensors = new String[ GrFingerCtrlSensors.Length + 1];
        for (int i = 1; i <= GrFingerCtrlSensors.Length; i++ )
        {
            tmpSensors[i - 1] = GrFingerCtrlSensors[i - 1];
        }
        Console.WriteLine("SensorPlug");
        tmpSensors[GrFingerCtrlSensors.Length] = e.idSensor;
        axGrFingerXCtrl1.CapStartCapture(e.idSensor);
      }

      private void axGrFingerXCtrl1_ImageAcquired(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent e)
      {
        String sensorID = Convert.ToString(e.idSensor);
        // Kopieeren van de gevonden afbeelding
        myFP._raw.img = e.rawImage;
        myFP._raw.height = (int)e.height;
        myFP._raw.width = (int)e.width;
        myFP._raw.Res = e.res;

        // Functie aanroepen die de afbeelding weergeeft op beeld.
        try
        {
            myFP.PrintBiometricDisplay(false, GRConstants.GR_DEFAULT_CONTEXT);
            // Template maken
            if (myFP.ExtractTemplate())
            {
                myFP.PrintBiometricDisplay(true, GRConstants.GR_NO_CONTEXT);
                if (myFP.TemplateIsValid())
                {
                    int score = 0;
                    FlexAccess.FingerReader.Person personFinger = myFP.Identify(ref score);
                    if (personFinger != null)
                    {

                        FlexAccess.Connection.Send.RequestOpenEntry(connectie.getClient(),personFinger.PersonID, sensorID);
                        Console.WriteLine("-----========Vinger gevonden========-----\n@@@Persoon: " + personFinger.PersonID + " @@@\n@@@Score: " + score + " @@@\n=============Vinger gevonden=============");
                    }
                    else
                    {
                        Console.WriteLine("-----========Geen vingerprint gevonden========-----");
                    }
                }
            }    
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
      {
        // Programma gelijk afsluiten en niet keurig afsluiten.
        // Dit moet gedaan worden om de TCPClient te stoppen.
        // Sluit je deze met client.close() dan blijft de socket open. Waardoor de server niet ziet of de client weg is.
        Application.Exit();
        /*
          if (appNotExit)
          {
              e.Cancel = true;
              connectie.disconnect();
              Console.WriteLine("ApplicationExit");
              appNotExit = false;
              Application.Exit();
          }
         */
      }

      private static void StopCounter()
      {
        FlexAccess.Program.clientForm.tmrCheckConnection.Stop();
        FlexAccess.Program.clientForm.tmrCheckConnection.Enabled = false;
      }

      public static FlexClient getConnection()
      {
          return connectie;
      }

      private void cmdShowAllExternalDivices_Click(object sender, EventArgs e)
      {
          String tmpMessage;
          tmpMessage = "Momenteel verbonden met deze client:\n\n" + Convert.ToString(GrFingerCtrlSensors.Length);

          for (int i = 1; i <= GrFingerCtrlSensors.Length;i++ )
          {
              tmpMessage += "- " + GrFingerCtrlSensors[i - 1];
          }
          MessageBox.Show(tmpMessage);
      }

      private void tmrCheckConnection_Tick(object sender, EventArgs e)
      {
        tmrCheckConnection.Enabled = false;
        if (connectie.isConnected())
        {
          lblisConnectedValue.Text = "Verbonden";
        }
        else
        {
          if (connectie.Connect(strServerIP, intServerPort))
          {
            FlexAccess.Connection.Send.ClientRegistation(connectie.getClient());
            lblisConnectedValue.Text = "Verbonden";
          }
          else
          {
            lblisConnectedValue.Text = "Geen verbinding";
          }
        }
        tmrCheckConnection.Enabled = true;
      }
    }
}