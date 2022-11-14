using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess_Server
{
  class LogControl
  {
    public static void addLog(String strMessage)
    {
      Console.WriteLine("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + strMessage);
    }

    public static void entryLog(Entry entry, Node node, Person person, Boolean powered, String comment)
    {
      int personID = 0;
      if (person != null)
      {
        personID = person.PersonID;
      }

      int nodeID = 0;
      if (node != null)
      {
        nodeID = node.NodeID;
      }

      FlexAccessServerDataSetTableAdapters.log_entry_controllerTableAdapter logEntryControllerAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.log_entry_controllerTableAdapter();
      logEntryControllerAdapter.addLogEntryControllerRow(entry.EntryID, nodeID, personID, powered, comment);
    }
  }
}
