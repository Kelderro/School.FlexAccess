using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Admin
{
    public partial class frmChangePassword : Form
    {
        private Person.Person _person;

        public frmChangePassword(Person.Person _tmpPerson)
        {
            InitializeComponent();
            _person = _tmpPerson; 
            _tmpPerson = null;
            lblPersonValue.Text = _person.getFullName();
        }

        private void cmdChangePassword_Click(object sender, EventArgs e)
        {
          
            if (txtNewpassword1.Text == txtNewpassword2.Text)
            {
                if (txtNewpassword1.Text.Length < 4)
                {
                    MessageBox.Show("Het wachtwoord is te kort");
                }
                else
                {

                    FlexAccessDataSet.systemuserDataTable systemuserDataTable = taSystemuser.GetSystemuserDetails(_person.PersonID);
                    foreach (FlexAccessDataSet.systemuserRow systemuserRow in systemuserDataTable)
                    {
                        if (systemuserRow.stu_password == txtOldpassword.Text)
                        {
                            taSystemuser.changePassword(txtNewpassword1.Text,_person.PersonID);
                            CustomMessage childCustomMessage = new CustomMessage("Wachtwoord gewijzigd");
                            childCustomMessage.Show();
                            _person = null;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Het oude password is incorrect");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Het nieuwe password komt niet overeen");
            }
        }

        private void controle()
        {
            if (txtOldpassword.Text != "")
            {
                if (txtNewpassword1.Text != "")
                {
                    if (txtNewpassword2.Text != "")
                    {
                        {
                            cmdChangePassword.Enabled = true;
                        }
                    }
                    else
                    {
                        cmdChangePassword.Enabled = false;
                    }


                }
                else
                {
                    cmdChangePassword.Enabled = false;
                }
            }
            else
            {
                cmdChangePassword.Enabled = false;
            }

        }

        private void txtOldpassword_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void txtNewpassword1_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void txtNewpassword2_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void txtOldpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtNewpassword1_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtNewpassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }
    }
}