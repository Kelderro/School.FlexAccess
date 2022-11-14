using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess.Entry
{
    public class Entry_Categorie
    {
        private int ID;
        private String name;
        private String remark;

        public int entryCategorieID
        {
            get { return ID; }
            set { ID = value; }
        }

        public String entryCategorieName
        {
            get { return name; }
            set { name = value; }
        }

        public String entryCategorieRemark
        {
            get { return remark; }
            set { remark = value; }
        }
    }
}
