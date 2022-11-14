using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Node
{
    public partial class frmSearchnode_category : Form
    {
        private Node_Categorie[] _category;
        private DataTable dt = new DataTable();
        private Boolean allNodeCategoryRepresented = false;
       
        public frmSearchnode_category()

        {
            InitializeComponent();
            DataColumn col0 = new DataColumn("Name", System.Type.GetType("System.String"));
            dt.Columns.Add(col0);
            showAllCategorys();
        }
        
        private void showAllCategorys()
        {
                   
            dt.Clear();
            _category = null;

            FlexAccessDataSet.node_categoryDataTable node_categoryDataTable = taNodeCategory.getNode_category();
            _category = new Node_Categorie[node_categoryDataTable.Count];
           
            int i = 0;
            foreach (FlexAccessDataSet.node_categoryRow categoryRow in node_categoryDataTable)
                
            {
                _category[i] = new Node_Categorie();
                _category[i].nodeCategorieID = categoryRow.ndc_id;
                _category[i].nodeCategorieName = categoryRow.ndc_name;
                _category[i].nodeCategorieRemark = categoryRow.ndc_description;
                
                object[] row = {  _category[i].nodeCategorieName };
                dt.Rows.Add(row);
                i++;
            }
           allNodeCategoryRepresented = true;
           binddata();
        }

        private void binddata()
        {
            dgNodeCategorie.DataSource = dt;
            dgNodeCategorie.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void cmdAll_Click(object sender, EventArgs e)
        {
            showAllCategorys();
            binddata();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (allNodeCategoryRepresented == false)
            {
                showAllCategorys();
            }
            Node_Categorie[] _tmpNodeCategorie;
            _tmpNodeCategorie = new Node_Categorie[_category.Length];
            dt.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _category.Length; i++)
            {
                if (_category[i].nodeCategorieName.ToLower() == txtName.Text.ToLower())
                {
                    _tmpNodeCategorie[j] = new Node_Categorie();
                    _tmpNodeCategorie[j] = _category[i];
                    object[] row = { _tmpNodeCategorie[j].nodeCategorieName };
                    dt.Rows.Add(row);
                    j++;
                }
            }
            _category = null;
            _category = _tmpNodeCategorie;
            _tmpNodeCategorie = null;
            allNodeCategoryRepresented = false;
            binddata();
        }

        private void dgNodeCategorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                frmDetailsNode_category childDetailsNode_category = new frmDetailsNode_category(_category[Convert.ToInt32(e.RowIndex.ToString())]);
                childDetailsNode_category.MdiParent = this.ParentForm;
                childDetailsNode_category.Show();
                _category = null;
                this.Close();
            }
        }
    }
}