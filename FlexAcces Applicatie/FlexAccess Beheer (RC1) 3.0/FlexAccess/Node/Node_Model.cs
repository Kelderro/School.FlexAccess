using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess.Node
{
    public class Node_Model
    {
        private int ID;
        private String Version;
        private String Brand;
        private Node_Categorie NodeCategorie;

        public int nodeModelID
        {
            get { return ID; }
            set { ID = value; }
        }

        public String nodeModelVersion
        {
            get { return Version; }
            set { Version = value; }
        }

        public String nodeModelBrand
        {
            get { return Brand; }
            set { Brand = value; }
        }

        public Node_Categorie nodeCategorie
        {
            get { return NodeCategorie; }
            set { NodeCategorie = value; }
        }
    }
}
