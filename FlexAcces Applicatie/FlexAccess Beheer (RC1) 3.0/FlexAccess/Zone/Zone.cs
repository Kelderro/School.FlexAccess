using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess.Zone
{
    public class Zone
    {
        private int zoneID;
        private String zoneName;
        private String zoneRemark;
        private Byte[] zonePlan;

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

        public String ZoneRemark
        {
            get { return zoneRemark; }
            set { zoneRemark = value; }
        }

        public Byte[] ZonePlan
        {
            get { return zonePlan; }
            set { zonePlan = value; }
        }
    }
}
