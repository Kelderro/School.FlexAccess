using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Node
{
    public partial class frmDetailsNode_category : Form
    {
        private Node_Categorie _nodeCategorie;

        public frmDetailsNode_category(Node_Categorie objNode_Categorie)
        {
            InitializeComponent();
            _nodeCategorie = new Node_Categorie();
            _nodeCategorie = objNode_Categorie;
            objNode_Categorie = null;
            txtName.Text = _nodeCategorie.nodeCategorieName;
            txtDescription.Text = _nodeCategorie.nodeCategorieRemark;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wilt u deze categorie echt verwijderen?", "Bevestig verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taNodeCategory.DeleteNodeCategorie(_nodeCategorie.nodeCategorieID);
                CustomMessage childCustomMessage = new CustomMessage("categorie " + _nodeCategorie.nodeCategorieName + " is verwijderd");
                childCustomMessage.Show();
                this.Close();
            }
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            taNodeCategory.Update(txtName.Text,txtDescription.Text,true,_nodeCategorie.nodeCategorieID);
            CustomMessage childCustomMessage = new CustomMessage("categorie " + _nodeCategorie.nodeCategorieName + " is gewijzigd");
            childCustomMessage.Show();
            this.Close();
        }

        private void cmdSubmit_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                cmdSubmit.Enabled = false;
            }
            else
            {
                cmdSubmit.Enabled = true;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                cmdSubmit.Enabled = false;
            }
            else
            {
                cmdSubmit.Enabled = true;
            }
        }

        private void lbldescription_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            frmSearchnode_category childfrmSearchnode_category = new frmSearchnode_category();

            childfrmSearchnode_category.Show();
            this.Close();
        }
    }
}