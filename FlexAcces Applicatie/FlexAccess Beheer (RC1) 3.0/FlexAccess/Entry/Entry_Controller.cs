using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess.Entry
{
    public class Entry_Controller
    {
        private int ID;
        private String name;
        private String remark;
        private String IP;

        public int entryControllerID
        {
            get { return ID; }
            set { ID = value; }
        }

        public String entryControllerName
        {
            get { return name; }
            set { name = value; }
        }

        public String entryControllerRemark
        {
            get { return remark; }
            set { remark = value; }
        }
        public String entryControllerIP
        {
            get { return IP; }
            set { IP = value; }
        }
    }
}
