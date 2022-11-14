using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Node
{
    public partial class frmAddnode_model : Form
    {
        public frmAddnode_model()
        {
            InitializeComponent();
            cmbCategorie.DataSource = taNode_category.getNode_category();
            cmbCategorie.ValueMember = "ndc_id";
            cmbCategorie.DisplayMember = "ndc_name";
        }

        
        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            taNode_model.Insert(Convert.ToInt32(cmbCategorie.SelectedValue), txtversion.Text, txtbrand.Text, true);            
            CustomMessage childCustomMessage = new CustomMessage("Er is een node model toegevoegd");
            childCustomMessage.Show();
            this.Close();
        }

        private void controle()
        {
            if (txtbrand.Text != "")
            {
                if (txtversion.Text != "")
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

        private void txtbrand_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void txtversion_TextChanged(object sender, EventArgs e)
        {
            controle();
        }


        private void txtbrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtversion_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }
    }
}