using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess
{
    public partial class frmAddPerson : Form
    {
        private Person.Person_group[] _personGroups;
        private Person.Person_group[] _selectedPersonGroups;
        private DataTable dtPersonGroups = new DataTable();
        private Boolean allPersonsGroupsRepresented = false;


        public frmAddPerson()
        {
            InitializeComponent();
            DataColumn col0 = new DataColumn("Naam", System.Type.GetType("System.String"));
            
            dtPersonGroups.Columns.Add(col0);
            showAllPersonsGroups();
        }

        private void showAllPersonsGroups()
        {
            dtPersonGroups.Clear();
            _personGroups = null;
            FlexAccessDataSet.person_groupDataTable personGroupDataTable = taPerson_group.GetData();
            _personGroups = new Person.Person_group[personGroupDataTable.Count];
            int i = 0;
            foreach (FlexAccessDataSet.person_groupRow personGroupRow in personGroupDataTable)
            {
                try
                {
                    Boolean checkSelected = true;
                    for (int j = 0; j < _selectedPersonGroups.Length; j++)
                    {
                        if (personGroupRow.psg_id == _selectedPersonGroups[j].personGroupID)
                        {
                            checkSelected = false;
                        }
                    }
                    if (checkSelected)
                    {
                        _personGroups[i] = new Person.Person_group();
                        _personGroups[i].personGroupID = personGroupRow.psg_id;
                        _personGroups[i].personGroupName = personGroupRow.psg_name;
                        object[] row = { _personGroups[i].personGroupName };
                        dtPersonGroups.Rows.Add(row);
                        i++;
                    }
                }
                catch
                {
                    _personGroups[i] = new Person.Person_group();
                    _personGroups[i].personGroupID = personGroupRow.psg_id;
                    _personGroups[i].personGroupName = personGroupRow.psg_name;
                    object[] row = { _personGroups[i].personGroupName };
                    dtPersonGroups.Rows.Add(row);
                    i++;
                }
            }
            allPersonsGroupsRepresented = true;
            binddataPersonGroup();
        }

        private void binddataPersonGroup()
        {
            dgPersonGroups.DataSource = dtPersonGroups;
            dgPersonGroups.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }


        private void cmdAddPerson_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wilt u direct vingers inscannen voor deze nieuwe gebruiker?", "Vingerprint scanner", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (taPerson.Insert(txtFristname.Text, txtMiddlename.Text, txtLastname.Text, true) != 1)
                {
                    CustomMessage childCustomMessage = new CustomMessage("Er is een fout opgetreden");
                    childCustomMessage.Show();
                }
                else
                {
                    try
                    {
                        Person.Person _Person = new Person.Person();
                        _Person.PersonID = (int)taPerson.GetLastPersonID();
                        FlexAccessDataSet.personDataTable personDataTable = taPerson.GetPersonDetails(_Person.PersonID);
                        foreach (FlexAccessDataSet.personRow personRow in personDataTable)
                        {
                            _Person.Firstname = personRow.prs_firstname;
                            _Person.Middlename = personRow.prs_middlename;
                            _Person.Lastname = personRow.prs_lastname;
                        }
                        FingerReader.frmAddFinger childAddFinger = new FingerReader.frmAddFinger(_Person);
                        childAddFinger.MdiParent = this.ParentForm;
                        childAddFinger.Show();
                        for (int i = 0; i < _selectedPersonGroups.Length; i++ )
                        {
                            taPerson_has_person_group.Insert(_Person.PersonID, _selectedPersonGroups[i].personGroupID);
                        }

                        CustomMessage childCustomMessage = new CustomMessage("Er is een persoon toegevoegd");
                        childCustomMessage.Show();
                    }
                    catch
                    {
                        CustomMessage childCustomMessage = new CustomMessage("Er is een database fout opgetreden");
                        childCustomMessage.Show();
                    }
                }
                this.Close();
            }
            else
            {
                if (taPerson.Insert(txtFristname.Text, txtMiddlename.Text, txtLastname.Text,true) != 1)
                {
                    CustomMessage childCustomMessage = new CustomMessage("Er is een fout opgetreden");
                    childCustomMessage.Show();
                }
                else
                {
                    Person.Person _Person = new Person.Person();
                    _Person.PersonID = (int)taPerson.GetLastPersonID();
                    for (int i = 0; i < _selectedPersonGroups.Length; i++)
                    {
                        taPerson_has_person_group.Insert(_Person.PersonID, _selectedPersonGroups[i].personGroupID);
                    }
                    CustomMessage childCustomMessage = new CustomMessage("Er is een persoon toegevoegd");
                    childCustomMessage.Show();
                }
                this.Close();
            }
        }

        private void checkInput()
        {
            cmdAddPerson.Enabled = false;
            if (txtFristname.Text != "")
            {
                if (txtLastname.Text != "")
                {
                    cmdAddPerson.Enabled = true;
                }
            }
        }

        private void txtFristname_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void txtMiddlename_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void cmdShowAllPersonGroups_Click(object sender, EventArgs e)
        {
            showAllPersonsGroups();
            binddataPersonGroup();
        }

        private void cmdSearchPersonGroups_Click(object sender, EventArgs e)
        {
            if (allPersonsGroupsRepresented == false)
            {
                showAllPersonsGroups();
            }
            Person.Person_group[] _tmpPersonGroup;
            _tmpPersonGroup = new Person.Person_group[_personGroups.Length];
            dtPersonGroups.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _personGroups.Length; i++)
            {
                if (_personGroups[i].personGroupName.ToLower() == txtSearchPersongroups.Text.ToLower())
                {
                    _tmpPersonGroup[j] = new Person.Person_group();
                    _tmpPersonGroup[j] = _personGroups[i];
                    object[] row = { _tmpPersonGroup[j].personGroupName };
                    dtPersonGroups.Rows.Add(row);
                    j++;
                }
            }
            _personGroups = null;
            _personGroups = _tmpPersonGroup;
            _tmpPersonGroup = null;
            allPersonsGroupsRepresented = false;
            binddataPersonGroup();
        }

        private void cmdShowSelectedPersonGroups_Click(object sender, EventArgs e)
        {
            String tmpString;
            try
            {
                tmpString = "U heeft de volgende persoons groepen geselecteerd:\n";

                for (int i = 0; i < _selectedPersonGroups.Length; i++)
                {
                    tmpString = tmpString + "- " + _selectedPersonGroups[i].personGroupName + "\n";
                }
            }
            catch
            {
                tmpString = "Er zijn momenteel geen persoons groepen geselecteerd";
            }
            MessageBox.Show(tmpString);
        }

        private void cmdEmptyPersonGroups_Click(object sender, EventArgs e)
        {
            _selectedPersonGroups = null;
            showAllPersonsGroups();
            binddataPersonGroup();
        }

        private void dgPersonGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    Person.Person_group[] _tmpPersonGroups;
                    _tmpPersonGroups = new Person.Person_group[_selectedPersonGroups.Length + 1];
                    for (int i = 0; i < _selectedPersonGroups.Length; i++)
                    {
                        _tmpPersonGroups[i] = _selectedPersonGroups[i];
                    }
                    _selectedPersonGroups = _tmpPersonGroups;
                    _selectedPersonGroups[_tmpPersonGroups.Length - 1] = _personGroups[Convert.ToInt32(e.RowIndex.ToString())];
                    _tmpPersonGroups = null;
                }
                catch
                {
                    _selectedPersonGroups = new Person.Person_group[1];
                    _selectedPersonGroups[0] = _personGroups[Convert.ToInt32(e.RowIndex.ToString())];
                }
                showAllPersonsGroups();
                binddataPersonGroup();
            }
        }
    }
}