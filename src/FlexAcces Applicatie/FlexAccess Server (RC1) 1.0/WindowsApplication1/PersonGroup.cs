using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess_Server
{
  class PersonGroup
  {
    private int personGroupID;
    private String personGroupName;

    public PersonGroup(int personGroupID, String personGroupName)
    {
      this.personGroupID = personGroupID;
      this.personGroupName = personGroupName;
    }

    public int PersonGroupID
    {
      get { return personGroupID; }
      set { personGroupID = value; }
    }

    public String PersonGroupName
    {
      get { return personGroupName; }
      set { personGroupName = value; }
    }
  }
}
