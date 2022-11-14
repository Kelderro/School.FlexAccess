using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Net;

namespace FlexAccess_Server
{
  class EntryController
  {
    private int controllerID;
    private String controllerIP;
    private Boolean active;
    private DataSet ds = new DataSet();

    public EntryController(int controllerID, String controllerIP, Boolean active)
    {
      this.controllerID = controllerID;
      this.controllerIP = controllerIP;
      this.active = active;
    }

    public String ControllerIP
    {
      get { return controllerIP; }
      set { controllerIP = value; }
    }

    public Boolean Active
    {
      get { return active; }
      set { active = value; }
    }

    public bool powerOn(Entry entry, Node node, Person person, bool powerOn, String comment)
    {
      if (this.active)
      {
        LogControl.addLog(((powerOn) ? "Aan" : "Uit") + "zetten toevoer van stroom - Controller IP: " + this.ControllerIP + " - PortID: " + entry.PortNumber);
        FlexAccessServerDataSetTableAdapters.entryTableAdapter entryAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.entryTableAdapter();
        entry.EntryPowered = powerOn;
        try
        {
          WebClient Client = new WebClient();
          Client.OpenRead("http://" + this.controllerIP + "/dk40_set?" + entry.PortNumber + ((powerOn) ? 1 : 0));
        }
        catch
        {
          LogControl.addLog("Fout bij het versturen van opdracht naar controller! - Controller IP: " + this.ControllerIP + " - PortID: " + entry.PortNumber);
          return false;
        }

        LogControl.entryLog(entry, node, person, powerOn, comment);
        LogControl.addLog("Klaar met " + ((powerOn) ? "aan" : "uit") + "zetten. - Controller IP: " + this.ControllerIP + " - PortID: " + entry.PortNumber);
        return true;
      }
      else
      {
        LogControl.addLog("Entrycontroller is uitgeschakeld! - Controller IP: " + this.ControllerIP + " - PortID: " + entry.PortNumber);
        return false;
      }
    }
  }
}
