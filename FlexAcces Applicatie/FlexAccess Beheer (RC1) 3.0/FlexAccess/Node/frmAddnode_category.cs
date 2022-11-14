using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Node
{
    public partial class frmAddnode_category : Form
    {
        public frmAddnode_category()
        {
            InitializeComponent();
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
           node_categoryTableAdapter1.Insert(txtName.Text, txtDescription.Text,true);
           CustomMessage childCustomMessage = new CustomMessage("Er is een node categorie toegevoegd");
           childCustomMessage.Show();
            this.Close();
        }
        
        private void controle()
        {
            if (txtName.Text != "")
            {
                if (txtDescription.Text != "")
                    cmdSubmit.Enabled = true;
                else
                {
                    cmdSubmit.Enabled = false;
                }
            }
            else
            {
                cmdSubmit.Enabled = false;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

          
    }
}