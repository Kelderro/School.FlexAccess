using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess.Entry
{
    public class Entry
    {
        private int ID;
        private String name;
        private String remark;
        private Zone.Zone zone;
        private Entry_Controller controller;
        private Entry_Categorie categorie;
        private int portnummer;

        public int entryID
        {
            get { return ID; }
            set { ID = value; }
        }

        public String entryName
        {
            get { return name; }
            set { name = value; }
        }

        public String entryRemark
        {
            get { return remark; }
            set { remark = value; }
        }

        public int entryPortnummer
        {
            get { return portnummer; }
            set { portnummer = value; }
        }

        public Entry_Categorie entryCategorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        public Entry_Controller entryController
        {
            get { return controller; }
            set { controller = value; }
        }
        public Zone.Zone entryZone
        {
            get { return zone; }
            set { zone = value; }
        }
    }
}
