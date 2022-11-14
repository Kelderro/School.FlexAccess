using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Entry
{
    public partial class frmAddEntry_category : Form
    {
        public frmAddEntry_category()
        {
            InitializeComponent();
        }

        private void controle()
        {
            if (txtName.Text != "")
            {
                cmdSubmit.Enabled = true;
            }
            else
            {
                cmdSubmit.Enabled = false;
            }
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            taEntryCategory.Insert(txtName.Text, txtDescription.Text, true);
            CustomMessage childCustomMessage = new CustomMessage("Er is een entry categorie toegevoegd");
            childCustomMessage.Show();
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            controle();
        }
    }
}