using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace FlexAccess_Server
{
  class Entry
  {
    private int entryID;
    private String entryName;
    private Boolean entryPowered = false;
    private int portNumber;
    public Zone zone;
    public EntryController entryController = null;
    private Timer entryCloseTimer = new Timer();

    public Entry(int entryID, String entryName, int portNumber, Zone zone, EntryController entryController)
    {
      this.entryID = entryID;
      this.entryName = entryName;
      this.portNumber = portNumber;
      this.zone = zone;
      this.entryController = entryController;

      entryCloseTimer.Interval = 10000;
      entryCloseTimer.Elapsed += new ElapsedEventHandler(entryCloseTimer_Tick);
      entryCloseTimer.AutoReset = false;
    }

    public int EntryID
    {
      get { return entryID; }
      set { entryID = value; }
    }

    public String EntryName
    {
      get { return entryName; }
      set { entryName = value; }
    }

    public Boolean EntryPowered
    {
      get { return entryPowered; }
      set { 
        entryPowered = value;
        FlexAccessServerDataSetTableAdapters.entryTableAdapter entryAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.entryTableAdapter();
        entryAdapter.updatePoweredState(this.entryPowered, this.entryID);
      }
    }

    public int PortNumber
    {
      get { return portNumber; }
      set { portNumber = value; }
    }

    public bool powerOn(Node node, Person person, bool powerOn, String comment)
    {
      bool bolResultPowerOn = this.entryController.powerOn(this, node, person, powerOn, comment);
      entryCloseTimer.Stop();
      if (comment != "Emergency" && powerOn)
      {
        entryCloseTimer.Start();
      }
      return bolResultPowerOn;
    }

    private void entryCloseTimer_Tick(object sender, ElapsedEventArgs args)
    {
      this.powerOn(null, null, false, "Timer is verlopen. Entry powered wordt uitgezet.");
    }

    public void entryCloseTimerEnabled(bool enabled)
    {
      entryCloseTimer.Enabled = enabled;
    }
  }
}
