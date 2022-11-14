using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess.Person
{
    public class Person_group
    {

        private int ID;
        private String name;

        public int personGroupID
        {
            get { return ID; }
            set { ID = value; }
        }

        public String personGroupName
        {
            get { return name; }
            set { name = value; }
        }
    }
}
