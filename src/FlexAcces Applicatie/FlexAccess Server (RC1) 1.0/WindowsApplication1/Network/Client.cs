using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FlexAccess_Server.Network
{
  public class Client
  {
    public String strIpAddress;
    TcpClient tcpClient;

    public Client()
    {
    }

    public string ipAddress
    {
      get { return strIpAddress; }
      set { this.strIpAddress = value; }
    }
    public TcpClient Socket
    {
      get { return tcpClient; }
      set { this.tcpClient = value; }
    }
    public void SendDataset(DataSet ds)
    {
      // Dataset omzetten naar een byte array
      MemoryStream memoryStream = new MemoryStream();
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      binaryFormatter.Serialize(memoryStream, ds);
      memoryStream.Seek(0, SeekOrigin.Begin);
      Byte[] streamData = memoryStream.ToArray();
      Byte[] bytesToSend = new Byte[streamData.Length];

      // Data versturen
      try
      {
        NetworkStream stream = tcpClient.GetStream();
        stream.Write(streamData, 0, streamData.Length);
        stream.Flush();
      }
      catch {}

      // Melding maken in console
      Console.WriteLine("Gegevens zijn verstuurd");
    }
  }

  public class ClientCollection : System.Collections.CollectionBase
  {
    public ClientCollection()
    {
    }

    public Client this[int index]
    {
      get { return (Client)List[index]; }
      set { List[index] = (Client)value; }
    }

    public void Add(Client client)
    {
      List.Add(client);
    }

    public void Remove(string strIpAddress)
    {
      for (int i = 0; i < List.Count; i++)
      {
        if (((Client)List[i]).strIpAddress.Equals(strIpAddress))
        {
          List.Remove(List[i]);
        }
      }
    }

    public bool Contains(string strIpAddress)
    {
      for (int i = 0; i < List.Count; i++)
      {
        if (((Client)List[i]).strIpAddress.Equals(strIpAddress))
        {
          return true;
        }
      }
      return false;
    }
  }
}