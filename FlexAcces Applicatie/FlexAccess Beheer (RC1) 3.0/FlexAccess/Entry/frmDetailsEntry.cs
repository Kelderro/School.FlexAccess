using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Entry
{
    public partial class frmDetailsEntry : Form
    {
        private Node.Node[] _nodes;
        private Entry _entry;
        private Node.Node[] _selectedNodes;
        private Node.Node[] _dbNodes;
        private Boolean allNodesRepresented = false;
        private DataTable dtSystemClient = new DataTable();
        private DataTable dtNodes = new DataTable();

        public frmDetailsEntry(Entry WijzigEntry)
        {
            InitializeComponent();

            _entry = WijzigEntry;
            WijzigEntry = null;

            dtSystemClient.Columns.Add(new DataColumn("naam", System.Type.GetType("System.String")));
            dtSystemClient.Columns.Add(new DataColumn("ip", System.Type.GetType("System.String")));
            dtNodes.Columns.Add(new DataColumn("naam", System.Type.GetType("System.String")));

            cmbController.DataSource = taEntry_controller.GetActiveEntry_controllers();
            cmbController.ValueMember = "ecn_id";
            cmbController.DisplayMember = "ecn_name";

            cmbZone.DataSource = taZone.GetActiveZones();
            cmbZone.ValueMember = "zne_id";
            cmbZone.DisplayMember = "zne_name";

            cmbEntryCategory.DataSource = taEntry_category.getAllActiveEntryCategorys();
            cmbEntryCategory.ValueMember = "enc_id";
            cmbEntryCategory.DisplayMember = "enc_name";

            Entry_Categorie _tmpEntryCategorie;
            Entry_Controller _tmpEntryController;
            Zone.Zone _tmpEntryZone;
            _tmpEntryCategorie = _entry.entryCategorie;
            _tmpEntryController = _entry.entryController;
            _tmpEntryZone = _entry.entryZone;

            txtEntryName.Text = _entry.entryName;
            txtRemark.Text = _entry.entryRemark;
            txtControllerPort.Text = _entry.entryPortnummer.ToString();
            cmbController.SelectedValue = _tmpEntryController.entryControllerID;
            cmbEntryCategory.SelectedValue = _tmpEntryCategorie.entryCategorieID;
            cmbZone.SelectedValue = _tmpEntryZone.ZoneID;
            lblSelectedEntryValue.Text = _entry.entryName;

            _tmpEntryCategorie = null;
            _tmpEntryController = null;
            _tmpEntryZone = null;

            FlexAccessDataSet.nodeDataTable nodeDataTable = taNode.GetNodesByEntryID(_entry.entryID);
            _selectedNodes = new Node.Node[nodeDataTable.Rows.Count];
            int i = 0;
            foreach (FlexAccessDataSet.nodeRow nodeRow in nodeDataTable)
            {
                Node.Node node = new Node.Node();
                node.nodeID = nodeRow.nde_id;
                node.nodeName = nodeRow.nde_name;

                _selectedNodes[i] = node;
                i++;
            }
            _dbNodes = _selectedNodes;
            showAllNodes();
            checkSubmit();
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
                                cmdChangeEntry.Enabled = true;
                            }
                            else
                            {
                                cmdChangeEntry.Enabled = false;
                            }
                        }
                        else
                        {
                            cmdChangeEntry.Enabled = false;
                        }
                    }
                    else
                    {
                        cmdChangeEntry.Enabled = false;
                    }
                }
                else
                {
                    cmdChangeEntry.Enabled = false;
                }
            }
            catch
            {
                cmdChangeEntry.Enabled = false;
            }
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

        private void txtControllerPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSubmit();
        }

        private void txtControllerPort_KeyDown(object sender, KeyEventArgs e)
        {
            checkSubmit();
        }

        private void txtEntryName_KeyDown(object sender, KeyEventArgs e)
        {
            checkSubmit();
        }

        private void txtEntryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSubmit();
        }

        private void cmbEntryCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSubmit();
        }

        private void cmbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSubmit();
        }

        private void cmbController_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSubmit();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wilt u deze entry echt verwijderen?", "Bevestig verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taEntry.DeleteEntry(_entry.entryID);
                CustomMessage childCustomMessage = new CustomMessage("entry: " + _entry.entryName + " is verwijderd");
                childCustomMessage.Show();
                this.Close();
            }
        }

        private void cmdChangeEntry_Click(object sender, EventArgs e)
        {
            //try
            //{
                taEntry.Update(Convert.ToInt32(cmbEntryCategory.SelectedValue), Convert.ToInt32(cmbZone.SelectedValue), Convert.ToInt32(cmbController.SelectedValue), txtEntryName.Text, txtRemark.Text, false, true, Convert.ToInt32(txtControllerPort.Text), _entry.entryID);
                //taLink.DeleteByEntryID(_entry.entryID);
                /*try
                {
                    if (_selectedNodes.Length >= 1)
                    {
                        for (int i = 0; i < _selectedNodes.Length; i++)
                        {

                            int SystemClientID = Convert.ToInt32(taLink.GetSystemClientByNodeID(_selectedNodes[i].nodeID));
                            taLink.DeleteAllNULLentrysByNodeID(_selectedNodes[i].nodeID);
                            taLink.Insert(SystemClientID, _selectedNodes[i].nodeID, _entry.entryID);
                        }
                    }
                }
                catch { }
                 * */

                //Node.Node[] _DeleteNodes = ;
                for (int i = 0; i < _selectedNodes.Length; i++)
                {
                    Boolean complete = false;
                    for (int j = 0; j < _dbNodes.Length; j++)
                    {
                        if (_dbNodes[j].nodeID == _selectedNodes[i].nodeID)
                        {
                            complete = true;
                        }
                    }
                    if (complete == false)
                    {
                        taLink.Insert(Convert.ToInt32(taLink.GetSystemClientByNodeID(_selectedNodes[i].nodeID)), _selectedNodes[i].nodeID, _entry.entryID);
                    }
                }
                //Node.Node[] _AddNodes;
                for (int i = 0; i < _dbNodes.Length; i++)
                {
                    Boolean complete = false;
                    for (int j = 0; j < _selectedNodes.Length; j++)
                    {
                        if (_dbNodes[i].nodeID == _selectedNodes[j].nodeID)
                        {
                            complete = true;
                        }
                    }
                    if (complete == false)
                    {
                        taLink.DeleteByNodeAndEntryID(_entry.entryID, _dbNodes[i].nodeID);
                    }
                }

                CustomMessage childCustomMessage = new CustomMessage("entry: " + _entry.entryName + " is gewijzigd");
                childCustomMessage.Show();
                this.Close();
            //}
            //catch
            //{
                //MessageBox.Show("het systeem heeft een ongeldige waarde ontvangen\nKan bewerking niet voltooien");
              //  this.Close();
            //}
        }
    }
}