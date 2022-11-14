using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GrFingerXLib;

namespace FlexAccess.FingerReader
{
  public partial class frmAddFinger : Form
  {
    // Fingerprint class defineren
    private FingerPrint myFP;

    public frmAddFinger(Person.Person person)
    {
      InitializeComponent();

      // FingerPrint class initialiseren
      myFP = new FingerPrint(pbFingerPrint, person, trvFingers);

      // Library initialiseren
      myFP.InitializeGrFinger(axGrFingerXCtrl1);

      lblPersonValue.Text = person.getFullName();

      myFP.markUnknownFingers();
    }

    // Vinger op scanner
    private void axGrFingerXCtrl1_FingerDown(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEvent e)
    {

    }

    // Vinger is verwerkt
    private void axGrFingerXCtrl1_FingerUp(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEvent e)
    {

    }

    // Verwerken van de ingescande afbeelding
    private void axGrFingerXCtrl1_ImageAcquired(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent e)
    {
      // Kopieeren van de gevonden afbeelding
      myFP._raw.img = e.rawImage;
      myFP._raw.height = (int)e.height;
      myFP._raw.width = (int)e.width;
      myFP._raw.Res = e.res;

      // Functie aanroepen die de afbeelding weergeeft op beeld.
       //try
      //{
        myFP.PrintBiometricDisplay(false, GRConstants.GR_DEFAULT_CONTEXT);
        // Template maken
        if (myFP.ExtractTemplate())
        {
          // Als er geen fout is opgetreden, minutiae/segments/directions weergeven in de afbeelding
          myFP.PrintBiometricDisplay(true, GRConstants.GR_NO_CONTEXT);
          // Controle of de template geldig is.
          if (myFP.TemplateIsValid())
          {
            // Toevoegen template naar de database.
            //myFP.saveTemplate();
            int score = 0;
            Person.Person personFinger = myFP.Identify(ref score);
            if (personFinger != null)
            {
              MessageBox.Show("Goedendag: " + personFinger.getFullName() + "\nScore: " + score);
            }
            else
            {
              MessageBox.Show("Geen vingerprint gevonden");
            }
          }
        }
      /*}
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }*/
    }

    // Scanner is aangesloten op het systeem
    private void axGrFingerXCtrl1_SensorPlug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent e)
    {
      axGrFingerXCtrl1.CapStartCapture(e.idSensor);
    }

    private void trvFingers_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (trvFingers.SelectedNode.Parent != null)
      {
        pbFingerPrint.Image = null;
        pbFingerPrint.Visible = true;
        pbDelete.Visible = true;
        myFP.setFingerLocationID(Convert.ToInt32(trvFingers.SelectedNode.Tag.ToString()));
      }
      else
      {
        pbFingerPrint.Visible = false;
        pbDelete.Visible = false;
      }
    }

    private void pbDelete_Click(object sender, EventArgs e)
    {
      if (trvFingers.SelectedNode.Parent != null)
      {
        if (MessageBox.Show("Weet u zeker dat u de vingerafdruk wilt verwijderen?", "Bevestig verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          if (myFP.deleteFinger())
          {
            MessageBox.Show("Vingerafdruk is verwijderd", "Vingerafdruk verwijderen");
          }
          else
          {
            MessageBox.Show("Fout opgetreden bij het verwijderen van de vingerafdruk", "Vingerafdruk verwijderen");
          }
        }
      }
    }

    private void pbDelete_MouseLeave(object sender, EventArgs e)
    {
      pbDelete.BorderStyle = BorderStyle.None;
    }

    private void pbDelete_MouseEnter(object sender, EventArgs e)
    {
      pbDelete.BorderStyle = BorderStyle.Fixed3D;
    }
  }
}