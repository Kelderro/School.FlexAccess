using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace FlexAccess_Server
{
  public class Person
  {
    private int personID = -1;
    private String fullName = null;

    public Person(int personIDInDatabase)
    {
      FlexAccessServerDataSetTableAdapters.personTableAdapter personTableAdapter = new FlexAccessServerDataSetTableAdapters.personTableAdapter();
      FlexAccessServerDataSet.personDataTable personTableData = personTableAdapter.getPerson(personIDInDatabase);

      if (personTableData.Rows.Count > 0)
      {
        this.personID = personIDInDatabase;

        FlexAccessServerDataSet.personRow personRow = personTableData[0];

        this.fullName = null;

        if (personRow.prs_firstname != "")
        {
          this.fullName = personRow.prs_firstname;
        }

        if (personRow.prs_middlename != "")
        {
          if (this.fullName.Length > 0)
          {
            this.fullName = this.fullName + " ";
          }
          this.fullName = this.fullName + personRow.prs_middlename;
        }

        if (personRow.prs_lastname != "")
        {
          if (this.fullName.Length > 0)
          {
            this.fullName = this.fullName + " ";
          }
          this.fullName = this.fullName + personRow.prs_lastname;
        }
      }
    }

    public int PersonID
    {
      get { return personID; }
      set { personID = value; }
    }

    public String Fullname
    {
      get { return fullName; }
      set { fullName = value; }
    }

    public Hashtable personGroup()
    {
      Hashtable personGroupHashtable = new Hashtable();

      FlexAccessServerDataSetTableAdapters.person_groupTableAdapter personGroupAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.person_groupTableAdapter();
      FlexAccessServerDataSet.person_groupDataTable personGroupData = personGroupAdapter.GetPersonGroupList(this.PersonID);

      foreach (FlexAccessServerDataSet.person_groupRow personGroupDataRow in personGroupData)
      {
        PersonGroup personGroup = new PersonGroup(personGroupDataRow.psg_id, personGroupDataRow.psg_name);
        personGroupHashtable.Add(personGroupDataRow.psg_id.GetHashCode(), personGroup);
      }
      return personGroupHashtable;
    }
  }
}
