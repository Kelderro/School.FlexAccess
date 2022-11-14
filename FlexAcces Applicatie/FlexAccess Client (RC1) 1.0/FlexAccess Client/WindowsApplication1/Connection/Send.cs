using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Data;
using System.IO;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;

namespace FlexAccess.Connection
{
    class Send
    {
        public static void ClientRegistation(TcpClient client)
        {
            DataSet ds;
            System.Data.DataTable dtHeader, dtData;
            ds = new DataSet();
            dtHeader = new DataTable();
            dtData = new DataTable();
            ds.DataSetName = "flexaccess";
            dtHeader.TableName = "header";
            dtData.TableName = "data";
            dtHeader.Columns.Add(new DataColumn("message_type", System.Type.GetType("System.String"), "", MappingType.Element));
            dtData.Columns.Add(new DataColumn("data_row", System.Type.GetType("System.String"), "", MappingType.Element));
            ds.Tables.Add(dtHeader);
            ds.Tables.Add(dtData);
            DataRow rowHeaderData = dtHeader.NewRow();
            DataRow rowDataData = dtData.NewRow();
            rowHeaderData["message_type"] = "RegisterClient";
            ds.Tables["header"].Rows.Add(rowHeaderData);
            rowDataData["data_row"] = "SystemClient1";
            ds.Tables["data"].Rows.Add(rowDataData);
            ds.AcceptChanges();
            //ds.WriteXml("C:\\Send_ClientRegistation.xml");
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, ds);
                memoryStream.Seek(0, SeekOrigin.Begin);
                Byte[] streamData = memoryStream.ToArray();
                NetworkStream stream = client.GetStream();
                Byte[] bytesToSend = new Byte[streamData.Length];
                stream.Write(streamData, 0, streamData.Length);
                stream.Flush();
            }
            catch
            {
                Console.WriteLine("Tijdens het opstarten kon geen verbinding worden gemaakt met de server");
            }
        }

        public static void RequestOpenEntry(TcpClient client, int Person_ID, String Node_ID)
        {
            DataSet ds;
            System.Data.DataTable dtHeader;
            ds = new DataSet();
            dtHeader = new DataTable();
            dtHeader.TableName = "header";
            dtHeader.Columns.Add(new DataColumn("messagetype", System.Type.GetType("System.String"), "", MappingType.Element));
            dtHeader.Columns.Add(new DataColumn("node", System.Type.GetType("System.String")));
            ds.DataSetName = "flexaccess";
            ds.Tables.Add(dtHeader);
            DataRow rowHeaderData = dtHeader.NewRow();
            rowHeaderData["messagetype"] = "RequestEntryOpen";
            rowHeaderData["node"] = Node_ID;
            ds.Tables["header"].Rows.Add(rowHeaderData);
            DataTable dtData = new DataTable();
            dtData.TableName = "data";
            dtData.Columns.Add(new DataColumn("data_row", System.Type.GetType("System.Int64")));
            ds.Tables.Add(dtData);

            DataRow rowDataData = dtData.NewRow();
            rowDataData["data_row"] = Person_ID;
            ds.Tables["data"].Rows.Add(rowDataData);

            ds.AcceptChanges();
            //ds.WriteXml("C:\\Send_RequestOpenEntry.xml");
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, ds);
                memoryStream.Seek(0, SeekOrigin.Begin);
                Byte[] streamData = memoryStream.ToArray();
                NetworkStream stream = client.GetStream();
                Byte[] bytesToSend = new Byte[streamData.Length];
                stream.Write(streamData, 0, streamData.Length);
                stream.Flush();
            }
            catch
            {
                Console.WriteLine("Tijdens het opstarten kon geen verbinding worden gemaakt met de server");
            }
        }
    }
}
