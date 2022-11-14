using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Node
{
    public partial class frmDetailNode_model : Form
    {
        private Node_Model _nodeModel;

        public frmDetailNode_model(Node_Model NodeModel)
        {
            InitializeComponent();
            _nodeModel = NodeModel;

            Node_Categorie _NodeCat;
            _NodeCat = _nodeModel.nodeCategorie;
            
            cmbCategorie.DataSource = taNode_category.getNode_category();
            cmbCategorie.ValueMember = "ndc_id";
            cmbCategorie.DisplayMember = "ndc_name";
            cmbCategorie.SelectedValue = _NodeCat.nodeCategorieID;
            txtbrand.Text = _nodeModel.nodeModelBrand;
            txtversion.Text = _nodeModel.nodeModelVersion;
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            Node_Categorie _node_cat = _nodeModel.nodeCategorie;
            taNode_model.Update(Convert.ToInt32(cmbCategorie.SelectedValue), txtversion.Text, txtbrand.Text, true, _nodeModel.nodeModelID, _node_cat.nodeCategorieID, _nodeModel.nodeModelVersion, _nodeModel.nodeModelBrand, true, _nodeModel.nodeModelID);
            CustomMessage childCustomMessage = new CustomMessage("model: " + _nodeModel.nodeModelBrand + "(" + _nodeModel.nodeModelVersion + ") gewijzigd");
            childCustomMessage.Show();
            this.Close();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            taNode_model.DeleteNodeModel(_nodeModel.nodeModelID);
            CustomMessage childCustomMessage = new CustomMessage("model: " + _nodeModel.nodeModelBrand+ "("+_nodeModel.nodeModelVersion+") verwijderd");
            childCustomMessage.Show();
            this.Close();
        }
    }
}