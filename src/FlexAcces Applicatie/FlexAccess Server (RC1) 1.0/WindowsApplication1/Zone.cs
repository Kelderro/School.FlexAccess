using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess_Server
{
  class Zone
  {
    private int zoneID;
    private String zoneName;

    public Zone(int zoneID, String zoneName)
    {
      this.zoneID = zoneID;
      this.zoneName = zoneName;
    }

    public int ZoneID
    {
      get { return zoneID; }
      set { zoneID = value; }
    }

    public String ZoneName
    {
      get { return zoneName; }
      set { zoneName = value; }
    }
  }
}
