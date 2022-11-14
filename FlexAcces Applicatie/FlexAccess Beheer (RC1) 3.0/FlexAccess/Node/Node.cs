using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess.Node
{
    public class Node
    {
        private int ID;
        private String name;
        private String remark;
        private Int32 Model;

        public int nodeID
        {
            get { return ID; }
            set { ID = value; }
        }

        public String nodeName
        {
            get { return name; }
            set { name = value; }
        }

        public String nodeRemark
        {
            get { return remark; }
            set { remark = value; }
        }

        public Int32 nodeModel
        {
            get { return Model; }
            set { Model = value; }
        }
    }
}
