using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Person
{
    public partial class frmGroupPersons : Form
    {
        private Person[] _persons;
        private Person_group[] _personGroups;
        private Person_group _selectedPersonGroup;
        private DataTable dtPersonGroups = new DataTable();
        private DataTable dtPersons = new DataTable();
        private Boolean allPersonsGroupsRepresented = false;
      //  private Boolean allPersonsRepresented = false;

        public frmGroupPersons()
        {
            InitializeComponent();
            DataColumn col = new DataColumn("Naam", System.Type.GetType("System.String"));
            dtPersonGroups.Columns.Add(col);

            DataColumn col0 = new DataColumn("Voornaam", System.Type.GetType("System.String"));
            DataColumn col1 = new DataColumn("Tussenvoegsel", System.Type.GetType("System.String"));
            DataColumn col2 = new DataColumn("Achternaam", System.Type.GetType("System.String"));
            dtPersons.Columns.Add(col0);
            dtPersons.Columns.Add(col1);
            dtPersons.Columns.Add(col2);
            showAllPersonsGroups();
        }

        private void showAllPersonsGroups()
        {
            dtPersonGroups.Clear();
            _personGroups = null;
            FlexAccessDataSet.person_groupDataTable personGroupDataTable = taPerson_group.GetData();
            _personGroups = new Person_group[personGroupDataTable.Count];
            int i = 0;
            foreach (FlexAccessDataSet.person_groupRow personGroupRow in personGroupDataTable)
            {
                _personGroups[i] = new Person_group();
                _personGroups[i].personGroupID = personGroupRow.psg_id;
                _personGroups[i].personGroupName = personGroupRow.psg_name;

                object[] row = { _personGroups[i].personGroupName };
                dtPersonGroups.Rows.Add(row);
                i++;
            }
            allPersonsGroupsRepresented = true;
            binddataPersonGroup();
        }



        private void binddataPersonGroup()
        {
            dgPerson_groep.DataSource = dtPersonGroups;
            dgPerson_groep.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void cmdSearchPersonGroup_Click(object sender, EventArgs e)
        {
            if (allPersonsGroupsRepresented == false)
            {
                showAllPersonsGroups();
            }
            Person_group[] _tmpPersonGroup;
            _tmpPersonGroup = new Person_group[_personGroups.Length];
            dtPersonGroups.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _personGroups.Length; i++)
            {
                if (_personGroups[i].personGroupName.ToLower() == txtSearchPersonGroup.Text.ToLower())
                {
                    _tmpPersonGroup[j] = new Person_group();
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

        private void disableForCanges()
        {
            txtChangesGroupPerson.Visible = true;
            txtSearchPersonGroup.Enabled = false;
            cmdDeletePersonGroup.Enabled = false;
            cmdChangePersonGroup.Enabled = false;
            cmdAddPersonGroup.Enabled = false;
            cmdShowAllPersonGroups.Enabled = false;
            cmdSearchPersonGroup.Enabled = false;
            dgPersons.Enabled = false;
            dgPerson_groep.Enabled = false;
        }

        private void enableForCanges()
        {
            txtChangesGroupPerson.Visible = false;
            txtSearchPersonGroup.Enabled = true;
            cmdDeletePersonGroup.Enabled = true;
            cmdChangePersonGroup.Enabled = true;
            cmdAddPersonGroup.Enabled = true;
            cmdShowAllPersonGroups.Enabled = true;
            cmdSearchPersonGroup.Enabled = true;
            dgPersons.Enabled = true;
            dgPerson_groep.Enabled = true;
        }

        private void cmdAddPersonGroup_Click(object sender, EventArgs e)
        {
            if (cmdAddPersonGroup.Text == "toevoegen")
            {
                disableForCanges();
                cmdChangePersonGroup.Enabled = false;
                cmdAddPersonGroup.Text = "bevestig";
            }
            else
            {
                if (taPerson_group.Insert(txtChangesGroupPerson.Text) != 1)
                {
                    CustomMessage childCustomMessage = new CustomMessage("Er is een fout opgetreden");
                    childCustomMessage.Show();
                }
                else
                {
                    CustomMessage childCustomMessage = new CustomMessage("de groep: " + txtChangesGroupPerson.Text + " is toegevoegd");
                    childCustomMessage.Show();
                }
                enableForCanges();
                showAllPersonsGroups();
                binddataPersonGroup();
                cmdAddPersonGroup.Text = "toevoegen";
            }
        }

        private void cmdChangePersonGroup_Click(object sender, EventArgs e)
        {
            if (_selectedPersonGroup == null)
            {
                MessageBox.Show("Er is momenteel geen groep geselecteerd om te bewerken");
            }
            else
            {
                if (cmdChangePersonGroup.Text == "wijzigen")
                {
                    disableForCanges();
                    cmdAddPersonGroup.Enabled = false;
                    cmdChangePersonGroup.Text = "bevestig";
                    txtChangesGroupPerson.Text = _selectedPersonGroup.personGroupName;
                }
                else
                {
                    if (taPerson_group.Update(txtChangesGroupPerson.Text,_selectedPersonGroup.personGroupID,_selectedPersonGroup.personGroupName,_selectedPersonGroup.personGroupID) != 1)
                    {
                        CustomMessage childCustomMessage = new CustomMessage("Er is een fout opgetreden");
                        childCustomMessage.Show();
                    }
                    else
                    {
                        CustomMessage childCustomMessage = new CustomMessage("de groep: " + _selectedPersonGroup.personGroupName + " is gewijzigt");
                        childCustomMessage.Show();
                    }
                    enableForCanges();
                    showAllPersonsGroups();
                    binddataPersonGroup();
                    cmdChangePersonGroup.Text = "wijzigen";
                }
            }
        }

        private void txtChangesGroupPerson_TextChanged(object sender, EventArgs e)
        {
            if (txtChangesGroupPerson.Text != "")
            {
                if (cmdAddPersonGroup.Text == "bevestig")
                {
                    cmdAddPersonGroup.Enabled = true;
                }
                if (cmdChangePersonGroup.Text == "bevestig")
                {
                    cmdChangePersonGroup.Enabled = true;
                }
            }
            else
            {
                if (cmdAddPersonGroup.Text == "bevestig")
                {
                    cmdAddPersonGroup.Enabled = false;
                }
                if (cmdChangePersonGroup.Text == "bevestig")
                {
                    cmdChangePersonGroup.Enabled = false;
                }
            }
        }

        private void cmdDeletePersonGroup_Click(object sender, EventArgs e)
        {
            if (_selectedPersonGroup == null)
            {
                MessageBox.Show("Er is momenteel geen groep geselecteerd om te bewerken");
            }
            else
            {
                if (MessageBox.Show("Wilt u deze groep echt verwijderen?\nAls u doorgaat zullen alle relaties met deze groep worden opgeheven\n\nDeze wijzigingen kunnen niet meer ongedaan worden gemaakt", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    taPerson_has_person_group.DeleteAllPersonGroups(_selectedPersonGroup.personGroupID);
                    taPerson_group.Delete(_selectedPersonGroup.personGroupID);
                    CustomMessage childCustomMessage = new CustomMessage("De groep: " + _selectedPersonGroup.personGroupName + " is verwijderd");
                    childCustomMessage.Show();
                    _selectedPersonGroup = null;
                    lblGroupSelectedValue.Text = "";
                    showAllPersonsGroups();
                    binddataPersonGroup();
                }
            }
        }

        private void dgPerson_groep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                _selectedPersonGroup = _personGroups[Convert.ToInt32(e.RowIndex.ToString())];
                lblGroupSelectedValue.Text = _selectedPersonGroup.personGroupName;
                showAllPersonsInGroup();
            }
        }

        private void cmdShowAllPersonGroups_Click(object sender, EventArgs e)
        {
            showAllPersonsGroups();
            binddataPersonGroup();
        }

        private void showAllPersonsInGroup()
        {
            dtPersons.Clear();
            _persons = null;
            FlexAccessDataSet.personDataTable personDataTable = taPerson.GetPersonsByPersonGroupID(_selectedPersonGroup.personGroupID);
            _persons = new Person[personDataTable.Count];
            int i = 0;
            foreach (FlexAccessDataSet.personRow personRow in personDataTable)
            {
                _persons[i] = new Person();
                _persons[i].PersonID = personRow.prs_id;
                _persons[i].Firstname = personRow.prs_firstname;
                _persons[i].Middlename = personRow.prs_middlename;
                _persons[i].Lastname = personRow.prs_lastname;

                object[] row = { _persons[i].Firstname, _persons[i].Middlename, _persons[i].Lastname };
                dtPersons.Rows.Add(row);
                i++;
            }
       //     allPersonsRepresented = true;
            bindPeronsData();
        }

        private void bindPeronsData()
        {
            dgPersons.DataSource = dtPersons;
            dgPersons.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgPersons.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgPersons.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dgPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex != -1)
            {
                frmDetailsPerson childDetailsPerson = new frmDetailsPerson(_persons[Convert.ToInt32(e.RowIndex.ToString())]);
                childDetailsPerson.MdiParent = this.ParentForm;
                childDetailsPerson.Show();
                _persons = null;
                this.Close();
            }
        }
    }
}