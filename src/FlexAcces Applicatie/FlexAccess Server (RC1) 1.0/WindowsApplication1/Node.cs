using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess_Server
{
  class Node
  {
    private int nodeID;
    private String nodeName;
    private bool nodeActive;

    public Node(int nodeID, String nodeName, bool nodeActive)
    {
      this.nodeID = nodeID;
      this.nodeName = nodeName;
      this.nodeActive = nodeActive;
    }

    public int NodeID
    {
      get { return nodeID; }
      set { nodeID = value; }
    }

    public String NodeName
    {
      get { return nodeName; }
      set { nodeName = value; }
    }

    public bool NodeActive
    {
      get { return nodeActive; }
      set { nodeActive = value; }
    }
  }
}
