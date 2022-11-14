using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Entry
{
    public partial class frmDetailsEntry_controller : Form
    {
        Entry_Controller _controller;

        public frmDetailsEntry_controller(Entry_Controller changeEntryController)
        {
            InitializeComponent();
            _controller = changeEntryController;
            changeEntryController = null;
            txtIp.Text = _controller.entryControllerIP;
            txtName.Text = _controller.entryControllerName;
            txtRemark.Text = _controller.entryControllerRemark;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {           
            if (MessageBox.Show("Wilt u deze controller echt verwijderen?", "Bevestig verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taEntry_controller.DeleteEntry_controller(_controller.entryControllerID);
                CustomMessage childCustomMessage = new CustomMessage("controller " + _controller.entryControllerName + " is verwijderd");
                childCustomMessage.Show();
                this.Close();
            }
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void txtIp_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            taEntry_controller.Update(txtName.Text, txtRemark.Text, txtIp.Text, _controller.entryControllerID);
            CustomMessage childCustomMessage = new CustomMessage("controller " + _controller.entryControllerName + " is gewijzigd");
            childCustomMessage.Show();
            this.Close();
        }
    }
}