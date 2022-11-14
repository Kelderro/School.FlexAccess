using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Text;

namespace FlexAccess_Server.Network
{
  public class SocketServer
  {
    TcpListener listener;
    IPAddress ipaAddress;

    // Port nummer
    int iPort;

    public delegate void ListenForMessageDelegate(Client client);
    public delegate void ClientConnectedEventHandler(object sender, Client client);

    public event ListenForMessageDelegate listenForMessageDelegate;
    public event ClientConnectedEventHandler ClientConnected;

    Thread thrListenForClients;

    bool bolListenForClients;

    public SocketServer(string ipAddress, string port)
    {
      ipaAddress = IPAddress.Parse(ipAddress);
      iPort = int.Parse(port);

      IPEndPoint endPoint = new IPEndPoint(ipaAddress, iPort);

      listener = new TcpListener(endPoint);
      
      listener.Start();
    }

    public IPAddress SocketIPAddress
    {
      get { return ipaAddress; }
    }
    public int Port
    {
      get { return iPort; }
    }

    public void Listen()
    {
      thrListenForClients = new Thread(new ThreadStart(ListenForClients));
      thrListenForClients.Name = "Lijsteren voor clienten thread";
      thrListenForClients.Start();
    }

    public void Stop()
    {
      listener.Stop();
    }

    /**
     * Luisteren naar inkomende verbindingen
     */
    private void ListenForClients()
    {
      bolListenForClients = true;

      /** Blijven luisteren naar clienten tot er een fout is opgetreden */
      while (bolListenForClients)
      {
        Client acceptClient = new Client();
        try
        {
          acceptClient.Socket = listener.AcceptTcpClient();

          String remoteEndPoint = acceptClient.Socket.Client.RemoteEndPoint.ToString();
          String[] arrRemoteEndPoint = remoteEndPoint.Split(':');
          String remoteIP = arrRemoteEndPoint[0];

          FlexAccessServerDataSetTableAdapters.systemclientTableAdapter systemclientAdapter = new FlexAccessServerDataSetTableAdapters.systemclientTableAdapter();
          FlexAccessServerDataSet.systemclientDataTable systemClientData = systemclientAdapter.systemClientData(remoteIP);

          // Controle of de systemclient toegang heeft
          if (systemClientData.Count == 1)
          {
            // Console schrijven gegevens van de client
            Console.WriteLine("Client " + systemClientData.Rows[0].ItemArray[1] + "(" + remoteIP + ") verbonden");
            // IP Address koppelen aan classe client
            acceptClient.ipAddress = remoteIP;
            ClientConnected(this, acceptClient);
            // Functie die luisterd of er een inkomend bericht is
            listenForMessageDelegate = new ListenForMessageDelegate(ListenForMessages);
            // Functie koppelen aan Socket met client
            listenForMessageDelegate.BeginInvoke(acceptClient, new AsyncCallback(ListenForMessagesCallback), "Completed");
          }
          else
          {
            // Client komt niet voor in de systemclient database, bericht terug van afwijzing.
            // Dataset maken
            DataSet ds;
            System.Data.DataTable dtHeader, dtData;
            ds = new DataSet();
            dtHeader = new DataTable();
            dtData = new DataTable();
            ds.DataSetName = "flexaccess";
            dtHeader.TableName = "header";
            dtData.TableName = "data";
            dtHeader.Columns.Add(new DataColumn("messagetype", System.Type.GetType("System.String"), "", MappingType.Element));
            dtData.Columns.Add(new DataColumn("data_row", System.Type.GetType("System.String"), "", MappingType.Element));
            ds.Tables.Add(dtHeader);
            ds.Tables.Add(dtData);
            DataRow rowHeaderData = dtHeader.NewRow();
            DataRow rowDataData = dtData.NewRow();
            rowHeaderData["messagetype"] = "invalidIP";
            ds.Tables["header"].Rows.Add(rowHeaderData);
            rowDataData["data_row"] = remoteIP;
            ds.Tables["data"].Rows.Add(rowDataData);
            ds.AcceptChanges();

            // Dataset sturen
            acceptClient.SendDataset(ds);

            // Client verbinding verbreken
            acceptClient.Socket.Client.Disconnect(false);
            LogControl.addLog("Client (" + remoteIP + ") zijn verbinding verbroken. Ongeldig IP adres");
          }
        }
        catch (Exception e)
        {
          // Als er een fout optreed stoppen met luisteren
          bolListenForClients = false;
          System.Windows.Forms.MessageBox.Show(e.Message);
        }
      }
    }

    // Luisteren naar inkomende berichten
    private void ListenForMessages(Client client)
    {
      int BUFFER_SIZE = 200;
      byte[] bytesToRead = new byte[client.Socket.ReceiveBufferSize];
      int numBytesRead;
      DataProcessor dp = new DataProcessor();
      while (client.Socket.Client.Connected)
      {
        // Controle of de client nog wel actief is
        // http://msdn2.microsoft.com/en-us/library/system.net.sockets.socket.connected.aspx
        bool blockingState = client.Socket.Client.Blocking;
        try
        {
          byte[] tmp = new byte[1];
          client.Socket.Client.Blocking = false;
          client.Socket.Client.Send(tmp, 0, 0);
        }
        catch {}

        client.Socket.Client.Blocking = blockingState;

        if (client.Socket.Client.Connected)
        {
          NetworkStream networkStream = client.Socket.GetStream();
          if (networkStream.DataAvailable)
          {
            Console.WriteLine("Binnenkomende gegevens. Bezig met binnenhalen...");
            DateTime startTime = DateTime.Now;
            MemoryStream memoryStream = new MemoryStream();
            do
            {
              numBytesRead = networkStream.Read(bytesToRead, 0, BUFFER_SIZE);
              memoryStream.Write(bytesToRead, 0, numBytesRead);
            }
            while (networkStream.DataAvailable);

            try
            {
              BinaryFormatter binaryFormatter = new BinaryFormatter();
              memoryStream.Seek(0, SeekOrigin.Begin);
              DataSet ds = (DataSet)binaryFormatter.Deserialize(memoryStream);

              // Terugsturen van data
              client.SendDataset(dp.incomingClientDataset(ds));
            }
            catch { }

            // Verlopen tijd weergeven van ontvangen tot verzenden
            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - startTime;

            Console.WriteLine("Tijd: " + duration);
          }
        }
       Thread.Sleep(500);
      }
      Console.WriteLine("Client heeft zijn verbinding verbroken");
    }

    private void ListenForMessagesCallback(IAsyncResult ar)
    {
      try
      {
        listenForMessageDelegate.EndInvoke(ar);
      }
      catch
      {
        
      }
    }
  }
}