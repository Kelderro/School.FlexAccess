using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Entry
{
    public partial class frmAddEntry : Form
    {
        private Node.Node[] _nodes;
        private Node.Node[] _selectedNodes;
        private Boolean allNodesRepresented = false;
        private DataTable dtSystemClient = new DataTable();
        private DataTable dtNodes = new DataTable();

        public frmAddEntry()
        {
            InitializeComponent();

            dtSystemClient.Columns.Add(new DataColumn("naam", System.Type.GetType("System.String")));
            dtSystemClient.Columns.Add(new DataColumn("ip", System.Type.GetType("System.String")));
            dtNodes.Columns.Add(new DataColumn("naam", System.Type.GetType("System.String")));

            cmbController.DataSource = taEntry_controller.GetActiveEntry_controllers();
            cmbController.ValueMember = "ecn_id";
            cmbController.DisplayMember = "ecn_name";
            
            cmbZone.DataSource = taZone.GetActiveZones();
            cmbZone.ValueMember = "zne_id";
            cmbZone.DisplayMember = "zne_name";

            showAllNodes();
        }

        private void frmAddEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flexAccessDataSet.entry_category' table. You can move, or remove it, as needed.
            this.entry_categoryTableAdapter.Fill(this.flexAccessDataSet.entry_category);
        }

        private void cmdAddEntry_Click(object sender, EventArgs e)
        {
            int EntryID;
            try
            {
                taEntry.Insert(Convert.ToInt32(cmbEntryCategory.SelectedValue), Convert.ToInt32(cmbZone.SelectedValue), Convert.ToInt32(cmbController.SelectedValue), txtEntryName.Text, txtRemark.Text, false, true, Convert.ToInt32(txtControllerPort.Text));
                EntryID = Convert.ToInt32(taEntry.getLastEntryID());
                try
                {
                    if (_selectedNodes.Length >= 1)
                    {
                        for (int i = 0; i < _selectedNodes.Length; i++)
                        {
                            int SystemClientID = Convert.ToInt32(taLink.GetSystemClientByNodeID(_selectedNodes[i].nodeID));
                            taLink.DeleteAllNULLentrysByNodeID(_selectedNodes[i].nodeID);
                            taLink.Insert(SystemClientID, _selectedNodes[i].nodeID, EntryID);
                        }
                    }
                }
                catch { }
                CustomMessage childCustomMessage = new CustomMessage("Er is een entry toegevoegd");
                childCustomMessage.Show();
                this.Close(); 
            }
            catch
            {
                MessageBox.Show("het systeem heeft een ongeldige waarde ontvangen\nKan bewerking niet voltooien");
                this.Close();
            }
        }

        private void checkSubmit()
        {
            try
            {

                if (txtEntryName.Text != "")
                {
                    if (cmbEntryCategory.SelectedValue != Convert.DBNull)
                    {
                        if (cmbController.SelectedValue != Convert.DBNull)
                        {
                            if (txtControllerPort.Text != "")
                            {
                                cmdAddEntry.Enabled = true;
                            }
                            else
                            {
                                cmdAddEntry.Enabled = false;
                            }
                        }
                        else
                        {
                            cmdAddEntry.Enabled = false;
                        }
                    }
                    else
                    {
                        cmdAddEntry.Enabled = false;
                    }
                }
                else
                {
                    cmdAddEntry.Enabled = false;
                }
            }
            catch
            {
                cmdAddEntry.Enabled = false;
            }
        }

        private void txtEntryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSubmit();
        }

        private void cmbEntryCategory_ValueMemberChanged(object sender, EventArgs e)
        {
            checkSubmit();
        }

        private void showAllNodes()
        {
            dtNodes.Clear();
            _nodes = null;
            FlexAccessDataSet.nodeDataTable nodeDataTable = taNode.GetAllActiveNodes();
            _nodes = new Node.Node[nodeDataTable.Count];
            int i = 0;
            foreach (FlexAccessDataSet.nodeRow nodeRow in nodeDataTable)
            {
                try
                {
                    Boolean checkSelected = true;
                    for (int j = 0; j < _selectedNodes.Length; j++)
                    {
                        if (nodeRow.nde_id == _selectedNodes[j].nodeID)
                        {
                            checkSelected = false;
                        }
                    }
                    if (checkSelected)
                    {
                        _nodes[i] = new Node.Node();
                        _nodes[i].nodeID = nodeRow.nde_id;
                        _nodes[i].nodeName = nodeRow.nde_name;
                        object[] row = { _nodes[i].nodeName };
                        dtNodes.Rows.Add(row);
                        i++;
                    }
                }
                catch
                {
                    _nodes[i] = new Node.Node();
                    _nodes[i].nodeID = nodeRow.nde_id;
                    _nodes[i].nodeName = nodeRow.nde_name;
                    object[] row = { _nodes[i].nodeName };
                    dtNodes.Rows.Add(row);
                    i++;
                }
            }
            allNodesRepresented = true;
            bindNodedata();
        }

        private void bindNodedata()
        {
            dgNodes.DataSource = dtNodes;
            dgNodes.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void cmdShowAllNodes_Click(object sender, EventArgs e)
        {
            showAllNodes();
            bindNodedata();
        }

        private void cmdSearchNode_Click(object sender, EventArgs e)
        {
            if (allNodesRepresented == false)
            {
                showAllNodes();
            }
            Node.Node[] _tmpNodes;
            _tmpNodes = new Node.Node[_nodes.Length];
            dtNodes.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _nodes.Length; i++)
            {
                if (_nodes[i].nodeName.ToLower().Trim() == txtSearchNode.Text.ToLower().Trim())
                {
                    _tmpNodes[j] = new Node.Node();
                    _tmpNodes[j] = _nodes[i];
                    object[] row = { _tmpNodes[j].nodeName };
                    dtNodes.Rows.Add(row);
                    j++;
                }
            }
            _nodes = null;
            _nodes = _tmpNodes;
            _tmpNodes = null;
            allNodesRepresented = false;
            bindNodedata();
        }

        private void cmdDeselectNodes_Click(object sender, EventArgs e)
        {
            _selectedNodes = null;
            showAllNodes();
            bindNodedata();
        }

        private void dgNodes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    Node.Node[] _tmpNodes;
                    _tmpNodes = new Node.Node[_selectedNodes.Length + 1];
                    for (int i = 0; i < _selectedNodes.Length; i++)
                    {
                        _tmpNodes[i] = _selectedNodes[i];
                    }
                    _selectedNodes = _tmpNodes;
                    _selectedNodes[_tmpNodes.Length - 1] = _nodes[Convert.ToInt32(e.RowIndex.ToString())];
                    //MessageBox.Show(_selectedNodes[0].nodeName + "  %%=%%  " + _selectedNodes.Length);
                    _tmpNodes = null;
                }
                catch
                {
                    _selectedNodes = new Node.Node[1];
                    _selectedNodes[0] = _nodes[Convert.ToInt32(e.RowIndex.ToString())];
                }
                showAllNodes();
                bindNodedata();
            }
        }

        private void cmdShowSelectedNodes_Click(object sender, EventArgs e)
        {
            String tmpString;
            try
            {
                tmpString = "U heeft de volgende nodes geselecteerd:\n";

                for (int i = 0; i < _selectedNodes.Length; i++)
                {
                    tmpString = tmpString + "- " + _selectedNodes[i].nodeName + "\n";
                }
            }
            catch
            {
                tmpString = "Er zijn momenteel geen nodes geselecteerd";
            }
            MessageBox.Show(tmpString);
        }

        private void txtControllerPort_TextChanged(object sender, EventArgs e)
        {
            checkSubmit();
        }

        private void txtControllerPort_KeyDown(object sender, KeyEventArgs e)
        {
            checkSubmit();
        }

        private void cmbController_KeyDown(object sender, KeyEventArgs e)
        {
            checkSubmit();
        }

        private void txtEntryName_KeyDown(object sender, KeyEventArgs e)
        {
            checkSubmit();
        }

        private void cmbEntryCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSubmit();
        }

        private void cmbController_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSubmit();
        }
    }
}