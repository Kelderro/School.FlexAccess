using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess
{
    public partial class frmDetailsPerson : Form
    {
        private Person.Person _person;
        private Person.Person_group[] _selectedPersonGroup;
        private Person.Person_group[] _nonSelectedPersonGroup;
        private Person.Person_group _selectItemPersonGroup;
        private DataTable dtSelectedPersonGroups = new DataTable();
        private DataTable dtNonSelectedPersonGroups = new DataTable();


        public frmDetailsPerson(Person.Person objPerson)
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(346, 236);
            cmdExtendScreen.Text = "Wijzig persoonlijke groep(-en)";

            _person             = objPerson;
            this.Text = this.Text + _person.getFullName();
            txtFristname.Text   = _person.Firstname;
            txtMiddlename.Text  = _person.Middlename;
            txtLastname.Text    = _person.Lastname;


            DataColumn col0 = new DataColumn("Naam", System.Type.GetType("System.String"));
            DataColumn col1 = new DataColumn("Naam", System.Type.GetType("System.String"));
            dtSelectedPersonGroups.Columns.Add(col0);
            dtNonSelectedPersonGroups.Columns.Add(col1);

        }

        private void cmdChangePerson_Click(object sender, EventArgs e)
        {
            taPerson.Update(txtFristname.Text, txtMiddlename.Text, txtLastname.Text, true, _person.PersonID);
            CustomMessage childCustomMessage = new CustomMessage(_person.getFullName() + " is gewijzigt");
            childCustomMessage.Show();
            this.Close();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wilt u deze gebruiker echt verwijderen?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taPerson.deletePerson(_person.PersonID);
                CustomMessage childCustomMessage = new CustomMessage(_person.getFullName() + " is verwijderd");
                childCustomMessage.Show();
                this.Close();
            }
        }

        private void cmdFingerprints_Click(object sender, EventArgs e)
        {
          FingerReader.frmAddFinger childAddFinger = new FingerReader.frmAddFinger(_person);
          childAddFinger.MdiParent = this.ParentForm;
          childAddFinger.Show();
        }

        private void cmdExtendScreen_Click(object sender, EventArgs e)
        {
            if (cmdExtendScreen.Text == "Wijzig persoonlijke groep(-en)")
            {
                this.Size = new System.Drawing.Size(629, 476);
                cmdExtendScreen.Text = "Terug naar klein scherm";
                refreshPersonGroupData();
                BindPersonGroupData();
            }
            else
            {
                cmdExtendScreen.Text = "Wijzig persoonlijke groep(-en)";
                this.Size = new System.Drawing.Size(346, 236);
            }
        }

        private void refreshPersonGroupData()
        {
            dtSelectedPersonGroups.Clear();
            dtNonSelectedPersonGroups.Clear();
            _nonSelectedPersonGroup = null;
            _selectedPersonGroup = null;

            FlexAccessDataSet.person_groupDataTable personSelectedGroupDataTable = taPerson_group.getAllPersonGroupsByPersonID(_person.PersonID);
            FlexAccessDataSet.person_groupDataTable personNonSelectedGroupDataTable = taPerson_group.GetData();
            _selectedPersonGroup = new Person.Person_group[personSelectedGroupDataTable.Count];
            _nonSelectedPersonGroup = new Person.Person_group[personNonSelectedGroupDataTable.Count];
            int i = 0;
            foreach (FlexAccessDataSet.person_groupRow personGroupRow in personSelectedGroupDataTable)
            {
                _selectedPersonGroup[i] = new Person.Person_group();
                _selectedPersonGroup[i].personGroupID = personGroupRow.psg_id;
                _selectedPersonGroup[i].personGroupName = personGroupRow.psg_name;

                object[] row = { _selectedPersonGroup[i].personGroupName };
                dtSelectedPersonGroups.Rows.Add(row);
                i++;
            }
            i = 0;
            Boolean AddToNonSelected;
            foreach (FlexAccessDataSet.person_groupRow personGroupRow in personNonSelectedGroupDataTable)
            {
                AddToNonSelected = true;
                for (int j = 0; j < _selectedPersonGroup.Length; j++)
                {
                    if (personGroupRow.psg_id == _selectedPersonGroup[j].personGroupID)
                    {
                        AddToNonSelected = false;
                    }
                }
                if (AddToNonSelected == true)
                {
                    _nonSelectedPersonGroup[i] = new Person.Person_group();
                    _nonSelectedPersonGroup[i].personGroupID = personGroupRow.psg_id;
                    _nonSelectedPersonGroup[i].personGroupName = personGroupRow.psg_name;

                    object[] row = { _nonSelectedPersonGroup[i].personGroupName };
                    dtNonSelectedPersonGroups.Rows.Add(row);
                    i++;
                }
            }

            BindPersonGroupData();
        }

        private void BindPersonGroupData()
        {
            dgNonSelectedPersonGroups.DataSource = dtNonSelectedPersonGroups;
            dgSelectedPersonGroup.DataSource = dtSelectedPersonGroups;
            dgNonSelectedPersonGroups.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgSelectedPersonGroup.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void cmdRightToLeft_Click(object sender, EventArgs e)
        {
            taPerson_has_person_group.Insert(_person.PersonID, _selectItemPersonGroup.personGroupID);
            refreshPersonGroupData();
            BindPersonGroupData();
            lblSelectedPersonGroupItemValue.Text = "";
            cmdRightToLeft.Enabled = false;
            cmdLeftToRight.Enabled = false;

        }

        private void dgNonSelectedPersonGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmdRightToLeft.Enabled = true;
                cmdLeftToRight.Enabled = false;
                _selectItemPersonGroup = new Person.Person_group();
                _selectItemPersonGroup = _nonSelectedPersonGroup[Convert.ToInt32(e.RowIndex.ToString())];
                lblSelectedPersonGroupItemValue.Text = _selectItemPersonGroup.personGroupName;
            }
        }

        private void dgSelectedPersonGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmdRightToLeft.Enabled = false;
                cmdLeftToRight.Enabled = true;
                _selectItemPersonGroup = new Person.Person_group();
                _selectItemPersonGroup = _selectedPersonGroup[Convert.ToInt32(e.RowIndex.ToString())];
                lblSelectedPersonGroupItemValue.Text = _selectItemPersonGroup.personGroupName;
            }
        }

        private void cmdLeftToRight_Click(object sender, EventArgs e)
        {
            taPerson_has_person_group.Delete(_person.PersonID, _selectItemPersonGroup.personGroupID);
            refreshPersonGroupData();
            BindPersonGroupData();
            lblSelectedPersonGroupItemValue.Text = "";
            cmdRightToLeft.Enabled = false;
            cmdLeftToRight.Enabled = false;
        }
    }
}