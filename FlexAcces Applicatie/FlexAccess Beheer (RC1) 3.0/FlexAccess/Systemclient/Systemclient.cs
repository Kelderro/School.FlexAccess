using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess.Systemclient
{
    public class Systemclient
    {
        private int Id;
        private String Name;
        private String Ip;
        private String remark;

        public int systemclientId
        {
            get { return Id; }
            set { Id = value; }
        }

        public String systemclientName
        {
            get { return Name; }
            set { Name = value; }
        }

        public String systemclientRemark
        {
            get { return remark; }
            set { remark = value; }
        }

        public String systemclientIp
        {
            get { return Ip; }
            set { Ip = value; }
        }
    }
}
