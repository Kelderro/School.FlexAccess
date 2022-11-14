using System;
using System.Collections.Generic;
using System.Text;

namespace FlexAccess.Person
{
  public class Person
  {
    private int personID;
    private String firstname;
    private String middlename;
    private String lastname;

    public int PersonID
    {
      get { return personID; }
      set { personID = value; }
    }

    public String Firstname
    {
      get { return firstname; }
      set { firstname = value; }
    }

    public String Middlename
    {
      get { return middlename; }
      set { middlename = value; }
    }

    public String Lastname
    {
      get { return lastname; }
      set { lastname = value; }
    }

    public String getFullName()
    {
      return lastname + ", " + firstname + " " + middlename;
    }
  }
}
