using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Node
{
    public partial class frmSearchNode : Form
    {
        private Node[] _node;
        private DataTable dt = new DataTable();
        private Boolean allNodesRepresented = false;

        public frmSearchNode()
        {
            InitializeComponent();
            DataColumn col0 = new DataColumn("Name", System.Type.GetType("System.String"));
            dt.Columns.Add(col0);
            showAllNodes();
        }

        private void showAllNodes()
        {

            dt.Clear();
            _node = null;

            FlexAccessDataSet.nodeDataTable nodeDataTable = taNode.GetAllActiveNodes();
            _node = new Node[nodeDataTable.Count];

            int i = 0;
            foreach (FlexAccessDataSet.nodeRow nodeRow in nodeDataTable)
            {
                _node[i] = new Node();
                _node[i].nodeID = nodeRow.nde_id;
                _node[i].nodeModel = nodeRow.ndm_id;
                _node[i].nodeRemark = nodeRow.nde_remark;
                _node[i].nodeName = nodeRow.nde_name;

                object[] row = { _node[i].nodeName };
                dt.Rows.Add(row);
                i++;
            }
            allNodesRepresented = true;
            binddata();
        }

        private void binddata()
        {
            dgNode.DataSource = dt;
            dgNode.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void cmdAll_Click(object sender, EventArgs e)
        {
            showAllNodes();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (allNodesRepresented == false)
            {
                showAllNodes();
            }
            Node[] _tmpNodes;
            _tmpNodes = new Node[_node.Length];
            dt.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _node.Length; i++)
            {
                if (_node[i].nodeName.ToLower().Trim() == txtSearchNode.Text.ToLower().Trim())
                {
                    _tmpNodes[j] = new Node();
                    _tmpNodes[j] = _node[i];
                    object[] row = { _tmpNodes[j].nodeName };
                    dt.Rows.Add(row);
                    j++;
                }
            }
            _node = null;
            _node = _tmpNodes;
            _tmpNodes = null;
            allNodesRepresented = false;
            binddata();
        }

        private void dgNode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                frmDetailNode childDetailNode = new frmDetailNode(_node[Convert.ToInt32(e.RowIndex.ToString())]);
                childDetailNode.MdiParent = this.ParentForm;
                childDetailNode.Show();
                _node = null;
                this.Close();
            }
        }
    }
}