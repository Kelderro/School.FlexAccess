using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Systemclient
{
    public partial class frmAddsystemclient : Form
    {
        public frmAddsystemclient()
        {
            InitializeComponent();
        }

        private void controle()
        {
            if (txtname.Text != "")
            {
                if (txtip.Text != "")
                {
                    cmdsubmit.Enabled = true;
                }
                else
                {
                    cmdsubmit.Enabled = false;
                }
            }
            else
            {
                cmdsubmit.Enabled = false;
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtip_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtremark_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void txtip_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void txtremark_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void cmdsubmit_Click(object sender, EventArgs e)
        {
            taSystemclient.Insert(txtname.Text.Trim(),txtip.Text.Trim(), txtremark.Text, true);
            CustomMessage childCustomMessage = new CustomMessage("Er is een systemclient toegevoegd");
            childCustomMessage.Show();
            this.Close();
        }
    }
}