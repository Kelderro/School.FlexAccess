using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Entry
{
    public partial class frmAddEntry_controller : Form
    {
        public frmAddEntry_controller()
        {
            InitializeComponent();
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            taEntry_controller.Insert(txtName.Text, txtRemark.Text, txtIp.Text, true);
            CustomMessage childCustomMessage = new CustomMessage("Er is een controller toegevoegd");
            childCustomMessage.Show();
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            controle();
        }
        private void controle()
        {
            cmdSubmit.Enabled = false;
            if (txtIp.Text != "")
            {
                if (txtName.Text != "")
                {
                    cmdSubmit.Enabled = true;
                }
            }
        }

        private void txtIp_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void txtIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }
    }
}