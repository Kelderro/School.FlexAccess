using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess.Node
{
    public class Node_Categorie
    {
        private int ID;
        private String name;
        private String remark;

        public int nodeCategorieID
        {
            get { return ID; }
            set { ID = value; }
        }

        public String nodeCategorieName
        {
            get { return name; }
            set { name = value; }
        }

        public String nodeCategorieRemark
        {
            get { return remark; }
            set { remark = value; }
        }
    }
}
