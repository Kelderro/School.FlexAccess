using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Data;
using System.Xml;

using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace FlexAccess_Server.Network
{
  class Server
  {
    private SocketServer socketServer;
    public ClientCollection clientCollection;

    public Server()
    {
      LogControl.addLog("Opstarten van server");
      int intPort = 1337;

      IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
      clientCollection = new ClientCollection();

      try
      {
        // Ipadressen van de computer opvragen
        IPAddress[] ipAddress = ipHostEntry.AddressList;

        // Socket server aanmaken
        socketServer = new SocketServer(ipAddress[1].ToString(), Convert.ToString(intPort));
        LogControl.addLog("Alleen naar IP Address " + ipAddress[1].ToString() + " mag een verbinding gemaakt worden.");
        // Functie toewijzen die aangeroepen wordt als er een client verbinding maakt
        socketServer.ClientConnected += new SocketServer.ClientConnectedEventHandler(socketServer_ClientConnected);

        // Server activeren
        socketServer.Listen();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Messenger Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      LogControl.addLog("Klaar met opstarten van server");
    }

    private void socketServer_ClientConnected(object sender, Client client)
    {
      /** Client toevoegen aan de collectie */
      LogControl.addLog("Client toegevoegd aan collectie!");
      clientCollection.Add(client);
    }
  }
}