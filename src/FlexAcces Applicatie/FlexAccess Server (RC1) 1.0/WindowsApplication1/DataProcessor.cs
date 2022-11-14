using System;
using System.Collections;
using System.Text;
using System.Data;

namespace FlexAccess_Server
{
  class DataProcessor
  {
    public DataSet incomingClientDataset(DataSet dsFromClient) {
      int   TABLE_HEADER        = 0;
      int   TABLE_DATA          = 1;
      int   COLUMN_MESSAGE_TYPE = 0;
      int   COLUMN_NODE         = 1;
      int   COLUMN_DATA         = 0;

      String strResponse = "";
      String strMessageType = Convert.ToString(dsFromClient.Tables[TABLE_HEADER].Rows[0].ItemArray[COLUMN_MESSAGE_TYPE]);

      if ((Controller.serverLockDown) && (strMessageType != "Emergency"))
      {
        strResponse = strMessageType + "Server staat in emergengy mode. Aanvraag is niet behandeld.";
      }
      else
      {
        switch (strMessageType)
        {
          case "Emergency":
            Controller.serverLockDown = true;
            if (Convert.ToString(dsFromClient.Tables[TABLE_DATA].Rows[0].ItemArray[COLUMN_DATA]) == "")
            {
              strResponse = "!!Emergengy!! is voorbij. Fijne dag verder.";
              Controller.serverLockDown = false;
            }
            else if (Convert.ToBoolean(dsFromClient.Tables[TABLE_DATA].Rows[0].ItemArray[COLUMN_DATA]))
            {
              strResponse = "!!Emergengy!! protocol geactiveerd en uitgevoerd. Alle actieve entry's gaan open. Rennen anders ga je dood!";
            }
            else
            {
              strResponse = "!!Emergengy!! protocol geactiveerd en uitgevoerd. Alle actieve entry's gaan op slot. Pak die gast!";
            }
            
            Hashtable entryHashTable = Controller.getEntryList();

            foreach(Entry entry in entryHashTable.Values)
            {
              // Entry open / dicht zetten
              bool powered;
              if (Convert.ToString(dsFromClient.Tables[TABLE_DATA].Rows[0].ItemArray[COLUMN_DATA]) == "")
              {
                powered = false;
              }
              else
              {
                powered = Convert.ToBoolean(dsFromClient.Tables[TABLE_DATA].Rows[0].ItemArray[COLUMN_DATA]);
              }
              entry.powerOn(null, null, powered, "Emergency");

              if (Convert.ToString(dsFromClient.Tables[TABLE_DATA].Rows[0].ItemArray[COLUMN_DATA]) == "")
              {
                // Timer's van de entry's inschakelen
                entry.entryCloseTimerEnabled(true);
              }
              else
              {
                // Timer's van de entry's uitschakelen
                entry.entryCloseTimerEnabled(false);
              }
            }
            break;
          case "RegisterClient":
            strResponse = "Client is succesvol aangemeld bij de server.";
            break;
          case "RequestEntryOpen":
            // Persoon object ophalen uit de dataset
            Person person = new Person(Convert.ToInt16(dsFromClient.Tables[TABLE_DATA].Rows[0].ItemArray[COLUMN_DATA]));
            // Person ID -1 betekend dat de persoon niet gevonden kon worden in de database
            if (person.PersonID == -1)
            {
              strResponse = "Onbekende persoon, aanvraag om de entry te openen is afgebroken.";
            }
            else
            {
              // Node naam uit het object halen
              String nodeName = Convert.ToString(dsFromClient.Tables[TABLE_HEADER].Rows[0].ItemArray[COLUMN_NODE]);

              FlexAccessServerDataSetTableAdapters.nodeTableAdapter nodeAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.nodeTableAdapter();
              FlexAccessServerDataSet.nodeDataTable nodeData = nodeAdapter.GetNodeByName(nodeName);

              if (nodeData.Rows.Count > 0)
              {
                FlexAccessServerDataSet.nodeRow nodeDataRow = (FlexAccessServerDataSet.nodeRow)nodeData.Rows[0];
                Node node = new Node(nodeDataRow.nde_id, nodeDataRow.nde_name, nodeDataRow.nde_active);

                if (node.NodeActive)
                {
                  // Met de persoon object en node naam opzoeken welke entry er geopend mogen worden
                  Permissions.Permission.checkPermission(node, person);
                  // Response naar de client
                  strResponse = person.Fullname + ", uw aanvraag is behandeld.";
                }
                else
                {
                  strResponse = person.Fullname + ", uw aanvraag is afgebroken. " + node.NodeName + " is uitgeschakeld.";
                }
              }
              else
              {
                strResponse = person.Fullname + ", uw aanvraag is afgebroken. " + nodeName + " niet gevonden.";
              }
            }
            break;
          case "ResponseEntryOpen":
            // Wegschrijvinen in logboek
            break;
          default:
            strResponse = "Bericht type wordt niet ondersteunt: " + strMessageType;
            break;
        }
      }
      Console.WriteLine("Response naar client >> " + strResponse);

      DataSet dsToClient;
      System.Data.DataTable dtHeader, dtData;
      dsToClient = new DataSet();
      dtHeader = new DataTable();
      dtData = new DataTable();
      dsToClient.DataSetName = "flexaccess";
      dtHeader.TableName = "header";
      dtData.TableName = "data";
      dtHeader.Columns.Add(new DataColumn("message_type", System.Type.GetType("System.String"), "", MappingType.Element));
      dtData.Columns.Add(new DataColumn("data_row", System.Type.GetType("System.String"), "", MappingType.Element));
      dsToClient.Tables.Add(dtHeader);
      dsToClient.Tables.Add(dtData);
      DataRow rowHeaderData = dtHeader.NewRow();
      DataRow rowDataData = dtData.NewRow();
      rowHeaderData["message_type"] = "Response";
      dsToClient.Tables["header"].Rows.Add(rowHeaderData);
      rowDataData["data_row"] = strResponse;
      dsToClient.Tables["data"].Rows.Add(rowDataData);
      dsToClient.AcceptChanges();

      return dsToClient;
    }
  }
}
