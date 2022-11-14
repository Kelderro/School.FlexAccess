using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess
{
    public partial class frmAddManager : Form
    {
        private Person.Person[] _person;
        private Person.Person _selectedPerson = new Person.Person();
        private DataTable dt = new DataTable();
        private Boolean allPersonsRepresented = false;

        public frmAddManager()
        {
            InitializeComponent();
            DataColumn col0 = new DataColumn("FirstName", System.Type.GetType("System.String"));
            DataColumn col1 = new DataColumn("MiddleName", System.Type.GetType("System.String"));
            DataColumn col2 = new DataColumn("LastName", System.Type.GetType("System.String"));

            dt.Columns.Add(col0);
            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            showAllPersons();
        }

        private void dgPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                _selectedPerson = _person[Convert.ToInt32(e.RowIndex.ToString())];
                lblSelectedPersonValue.Text = _selectedPerson.Firstname.ToString() + " " + _selectedPerson.Middlename.ToString() + " " + _selectedPerson.Lastname.ToString();
            }
        }


        private void showAllPersons()
        {
            dt.Clear();
            _person = null;
            FlexAccessDataSet.personDataTable personDataTable = taPerson.GetAllNonSystemPersons();
            _person = new Person.Person[personDataTable.Count];
            int i = 0;
            foreach (FlexAccessDataSet.personRow personRow in personDataTable)
            {
                _person[i] = new Person.Person();
                _person[i].PersonID = personRow.prs_id;
                _person[i].Firstname = personRow.prs_firstname;
                _person[i].Middlename = personRow.prs_middlename;
                _person[i].Lastname = personRow.prs_lastname;
                object[] row = { _person[i].Firstname, _person[i].Middlename, _person[i].Lastname };
                dt.Rows.Add(row);
                i++;
            }
            allPersonsRepresented = true;
            binddata();
        }

        private void binddata()
        {
            dgPerson.DataSource = dt;
            dgPerson.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgPerson.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgPerson.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void cmdAll_Click(object sender, EventArgs e)
        {
            showAllPersons();
            binddata();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (allPersonsRepresented == false)
            {
                showAllPersons();
            }
            Person.Person[] _tmpPerson;
            _tmpPerson = new Person.Person[_person.Length];
            dt.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _person.Length; i++)
            {
                Boolean finish = false;
                if (_person[i].Firstname.ToLower() == txtFirstname.Text.ToLower())
                {
                    _tmpPerson[j] = new Person.Person();
                    _tmpPerson[j] = _person[i];
                    object[] row = { _tmpPerson[j].Firstname, _tmpPerson[j].Middlename, _tmpPerson[j].Lastname };
                    dt.Rows.Add(row);
                    j++;
                    finish = true;
                }
                if ((_person[i].Middlename.ToLower() == txtMiddlename.Text.ToLower()) && (finish == false) && (txtMiddlename.Text != ""))
                {
                    _tmpPerson[j] = new Person.Person();
                    _tmpPerson[j] = _person[i];
                    object[] row = { _tmpPerson[j].Firstname, _tmpPerson[j].Middlename, _tmpPerson[j].Lastname };
                    dt.Rows.Add(row);
                    j++;
                    finish = true;
                }
                if ((_person[i].Lastname.ToLower() == txtLastname.Text.ToLower()) && (finish == false))
                {
                    _tmpPerson[j] = new Person.Person();
                    _tmpPerson[j] = _person[i];
                    object[] row = { _tmpPerson[j].Firstname, _tmpPerson[j].Middlename, _tmpPerson[j].Lastname };
                    dt.Rows.Add(row);
                    j++;
                    finish = true;
                }
            }
            _person = null;
            _person = _tmpPerson;
            _tmpPerson = null;
            allPersonsRepresented = false;
            binddata();
        }

        private void cmdGeneratePassword_Click(object sender, EventArgs e)
        {
            PasswordGenerator passGen = new PasswordGenerator();
            txtPassword.Text = passGen.Generate();
            passGen = null;
        }

        private void cmdAddSystemUser_Click(object sender, EventArgs e)
        {
            if (lblSelectedPersonValue.Text.Length == 0)
            {
                MessageBox.Show("Er is momenteel geen gebruiker geselecteerd");
            }
            else
            {
                if (txtLoginname.Text.Length == 0)
                {
                    MessageBox.Show("Er is momenteel geen loginnaam ingevoerd");
                }
                else
                {
                    if (txtPassword.Text.Length == 0)
                    {
                        MessageBox.Show("Er is momenteel geen wachtwoord ingevoerd");
                    }
                    else
                    {
                        try{
                            taSystemuser.Insert(_selectedPerson.PersonID,txtLoginname.Text,txtPassword.Text,true);
                            CustomMessage childCustomMessage = new CustomMessage("Gebruiker " + txtLoginname.Text + " is aangemaakt");
                            childCustomMessage.Show();
                            this.Close();
                        }
                        catch
                        {
                            this.Close();
                            CustomMessage childCustomMessage = new CustomMessage("Er is een probleem opgetreden, gebruiker is niet toegevoegd");
                            childCustomMessage.Show();
                        }
                    }
                }
            }
        }
    }
}