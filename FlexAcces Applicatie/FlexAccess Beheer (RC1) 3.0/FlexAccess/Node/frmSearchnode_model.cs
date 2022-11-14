using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Node
{
    public partial class frmSearchnode_model : Form
    {
        private Node_Model[] _nodeModels;
        private DataTable dt = new DataTable();
        private Boolean allNodeModelsRepresented = false;

        public frmSearchnode_model()
        {
            InitializeComponent();
            DataColumn col0 = new DataColumn("Name", System.Type.GetType("System.String"));
            dt.Columns.Add(col0);
            showAllNodeModules();
            binddata();
        }

        private void showAllNodeModules()
        {

            dt.Clear();
            _nodeModels = null;

            FlexAccessDataSet.node_modelDataTable node_modelDataTable = taNode_model.GetAllActiveNode_modules();
            _nodeModels = new Node_Model[node_modelDataTable.Count];

            int i = 0;
            foreach (FlexAccessDataSet.node_modelRow node_modelRow in node_modelDataTable)
            {
                Node_Categorie _nodecategorie = new Node_Categorie();
                _nodeModels[i] = new Node_Model();
                _nodecategorie.nodeCategorieID = node_modelRow.ndc_id;
                _nodeModels[i].nodeModelID = node_modelRow.ndm_id;
                _nodeModels[i].nodeModelBrand = node_modelRow.ndm_brand;
                _nodeModels[i].nodeModelVersion = node_modelRow.ndm_version;
                _nodeModels[i].nodeCategorie = _nodecategorie;

                object[] row = { _nodeModels[i].nodeModelBrand + "(" + node_modelRow.ndm_version + ")" };
                dt.Rows.Add(row);
                i++;
            }
            allNodeModelsRepresented = true;
        }

        private void binddata()
        {
            dgNodeModel.DataSource = dt;
            dgNodeModel.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void cmdAll_Click(object sender, EventArgs e)
        {
            showAllNodeModules();
            binddata();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (allNodeModelsRepresented == false)
            {
                showAllNodeModules();
            }
            Node_Model[] _tmpNodeModels;
            _tmpNodeModels = new Node_Model[_nodeModels.Length];
            dt.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _nodeModels.Length; i++)
            {
                if (_nodeModels[i].nodeModelBrand.ToLower().Trim() == txtbrand.Text.ToLower().Trim())
                {
                    _tmpNodeModels[j] = new Node_Model();
                    _tmpNodeModels[j] = _nodeModels[i];
                    object[] row = { _nodeModels[i].nodeModelBrand + "(" + _nodeModels[i].nodeModelVersion + ")" };
                    dt.Rows.Add(row);
                    j++;
                }
            }
            _nodeModels = null;
            _nodeModels = _tmpNodeModels;
            _tmpNodeModels = null;
            allNodeModelsRepresented = false;
            binddata();
        }

        private void dgNodeModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                frmDetailNode_model childDetailNode_model = new frmDetailNode_model(_nodeModels[Convert.ToInt32(e.RowIndex.ToString())]);
                childDetailNode_model.MdiParent = this.ParentForm;
                childDetailNode_model.Show();
                _nodeModels = null;
                this.Close();
            }
        }
    }
}