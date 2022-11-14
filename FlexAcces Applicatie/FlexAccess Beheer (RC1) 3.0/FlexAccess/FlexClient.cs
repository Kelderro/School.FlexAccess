using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Data;
//using System.Xml;
using System.IO;
//using System.Text;
//using System.Drawing;
using System.Threading;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
    public class FlexClient
    {
        private TcpClient client;
        private NetworkStream stream;
        private System.Windows.Forms.Timer tmrCheckincommingData;

        public Boolean Connect(String server)
        {
            try
            {
                // de verbinding tot stand brengen
                Int32 port = 1337;
                client = new TcpClient(server, port);
                stream = client.GetStream();

                tmrCheckincommingData = new System.Windows.Forms.Timer();
                tmrCheckincommingData.Enabled = true;
                tmrCheckincommingData.Interval = 50;
                tmrCheckincommingData.Tick += new System.EventHandler(tmrCheckincommingData_Tick);
                tmrCheckincommingData.Start();

                return true;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
                return false;
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
                return false;
            }
        }

        private void tmrCheckincommingData_Tick(object sender, EventArgs e)
        {
            handleIncommingdata();
        }

        private void handleIncommingdata()
        {
            int numBytesRead;
            int BUFFER_SIZE = 200;
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            if (stream.DataAvailable)
            {
              Thread.Sleep(1500);
                Console.WriteLine("Binnenkomende gegevens. Bezig met binnenhalen...");
                DateTime startTime = DateTime.Now;
                MemoryStream memoryStream = new MemoryStream();
                do
                {
                    numBytesRead = stream.Read(bytesToRead, 0, BUFFER_SIZE);
                    memoryStream.Write(bytesToRead, 0, numBytesRead);
                }
                while (stream.DataAvailable);

                BinaryFormatter binaryFormatter = new BinaryFormatter();
                memoryStream.Seek(0, SeekOrigin.Begin);
                DataSet ds = (DataSet)binaryFormatter.Deserialize(memoryStream);

                DateTime stopTime = DateTime.Now;
                TimeSpan duration = stopTime - startTime;
                FlexAccess.Connection.Receive.ProcessData(ds);
                Console.WriteLine("Tijd: " + duration);
            }
        }

        public void disconnect()
        {
            try
            {
                tmrCheckincommingData.Stop();
                tmrCheckincommingData.Enabled = false;
                stream.Close();
                client.Close();
            }
            catch
            {
                Console.WriteLine("Error @ FlexClient.Disconnect");
            }
        }

        public DataSet GetData()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(stream, XmlReadMode.InferSchema);
            Console.WriteLine(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            return ds;
        }

        public TcpClient getClient() { return client; }
    }
