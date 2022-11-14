using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Node
{
    public partial class frmAddnode : Form
    {
        private Systemclient.Systemclient[] _systemclients;
        private Entry.Entry[] _entrys;
        private Systemclient.Systemclient _selectedSystemclient = new Systemclient.Systemclient();
        private Entry.Entry[] _selectedEntrys;
        private Boolean allSystemclientsRepresented = false;
        private Boolean allEntrysRepresented = false;
        private DataTable dtSystemClient = new DataTable();
        private DataTable dtEntry = new DataTable();

        public frmAddnode()
        {
            InitializeComponent();
            dtSystemClient.Columns.Add(new DataColumn("naam", System.Type.GetType("System.String")));
            dtSystemClient.Columns.Add(new DataColumn("ip", System.Type.GetType("System.String")));
            dtEntry.Columns.Add(new DataColumn("naam", System.Type.GetType("System.String")));

            cmbModel.DataSource = taNode_model.GetAllActiveNodeModulesAsName();
            cmbModel.ValueMember = "ndm_id";
            cmbModel.DisplayMember = "ndm_name";

            showAllSystemClients();
            showAllEntrys();
        }

        private void showAllSystemClients()
        {
            dtSystemClient.Clear();
            _systemclients = null;
            FlexAccessDataSet.systemclientDataTable systemclientDataTable = taSystemclient.GetData();
            _systemclients = new Systemclient.Systemclient[systemclientDataTable.Count];
            int i = 0;
            foreach (FlexAccessDataSet.systemclientRow systemclientRow in systemclientDataTable)
            {
                _systemclients[i] = new Systemclient.Systemclient();
                _systemclients[i].systemclientId = systemclientRow.smc_id;
                _systemclients[i].systemclientIp = systemclientRow.smc_ip;
                _systemclients[i].systemclientName = systemclientRow.smc_name;
                try
                {
                    _systemclients[i].systemclientRemark = systemclientRow.smc_remark;
                }
                catch
                {
                    _systemclients[i].systemclientRemark = "";
                }
                object[] row = { _systemclients[i].systemclientName, _systemclients[i].systemclientIp };
                dtSystemClient.Rows.Add(row);
                i++;
            }
            allSystemclientsRepresented = true;
            bindSystemClientData();
        }

        private void showAllEntrys()
        {
            dtEntry.Clear();
            _entrys = null;
            FlexAccessDataSet.entryDataTable entryDataTable = taEntry.GetAllActiveEntrys();
            _entrys = new Entry.Entry[entryDataTable.Count];
            int i = 0;
            foreach (FlexAccessDataSet.entryRow entryRow in entryDataTable)
            {
                try
                {
                    Boolean checkSelected = true;
                    for (int j = 0; j < this._selectedEntrys.Length; j++)
                    {
                        if (entryRow.ent_id == _selectedEntrys[j].entryID)
                        {
                            checkSelected = false;
                        }
                    }
                    if (checkSelected)
                    {
                        _entrys[i] = new Entry.Entry();
                        _entrys[i].entryID = entryRow.ent_id;
                        _entrys[i].entryName = entryRow.ent_name;
                        object[] row = { _entrys[i].entryName };
                        dtEntry.Rows.Add(row);
                        i++;
                    }
                }
                catch
                {
                    _entrys[i] = new Entry.Entry();
                    _entrys[i].entryID = entryRow.ent_id;
                    _entrys[i].entryName = entryRow.ent_name;
                    object[] row = { _entrys[i].entryName };
                    dtEntry.Rows.Add(row);
                    i++;
                }
            }
            allEntrysRepresented = true;
            bindEntrydata();
        }

        private void bindSystemClientData()
        {
            dgSystemclients.DataSource = dtSystemClient;
            dgSystemclients.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void bindEntrydata()
        {
            dgEntrys.DataSource = dtEntry;
            dgEntrys.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void controle()
        {
            if (txtname.Text != "")
            {
                if (cmbModel.Text != "")
                {
                    cmdSubmit.Enabled = true;
                }
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

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtmodel_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtRemark_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void txtmodel_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {
            controle();
        }

        private void cmdShowAllSystemClients_Click(object sender, EventArgs e)
        {
            showAllSystemClients();
            bindSystemClientData();
        }

        private void dgSystemclients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                _selectedSystemclient = _systemclients[Convert.ToInt32(e.RowIndex.ToString())];
                lblSystemclientValue.Text = _selectedSystemclient.systemclientName;
                controle();
            }
        }

        private void cmdSearchSystemClient_Click(object sender, EventArgs e)
        {
            if (allSystemclientsRepresented == false)
            {
                showAllSystemClients();
            }
            Systemclient.Systemclient[] _tmpSystemclient;
            _tmpSystemclient = new Systemclient.Systemclient[_systemclients.Length];
            dtSystemClient.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _systemclients.Length; i++)
            {
                if (_systemclients[i].systemclientName.ToLower() == txtSearchSystemClient.Text.ToLower())
                {
                    _tmpSystemclient[j] = new Systemclient.Systemclient();
                    _tmpSystemclient[j] = _systemclients[i];
                    object[] row = { _tmpSystemclient[j].systemclientName, _tmpSystemclient[j].systemclientIp };
                    dtSystemClient.Rows.Add(row);
                    j++;
                }
            }
            _systemclients = null;
            _systemclients = _tmpSystemclient;
            _tmpSystemclient = null;
            allSystemclientsRepresented = false;
            bindSystemClientData();
        }

        private void cmdShowAllEntrys_Click(object sender, EventArgs e)
        {
            showAllEntrys();
            bindEntrydata();
        }

        private void cmdDeselectEntrys_Click(object sender, EventArgs e)
        {
            _selectedEntrys = null;
            showAllEntrys();
            bindEntrydata();
        }

        private void cmdShowSelectedEntrys_Click(object sender, EventArgs e)
        {
            String tmpString;
            try
            {
                tmpString = "U heeft de volgende entry(-s) geselecteerd:\n";

                for (int i = 0; i < _selectedEntrys.Length; i++)
                {
                    tmpString = tmpString + "- " + _selectedEntrys[i].entryName + "\n";
                }
            }
            catch
            {
                tmpString = "Er zijn momenteel geen entrys geselecteerd";
            }
            MessageBox.Show(tmpString);
        }

        private void cmdSearchEntry_Click(object sender, EventArgs e)
        {
            if (allEntrysRepresented == false)
            {
                showAllEntrys();
            }
            Entry.Entry[] _tmpEntry;
            _tmpEntry = new Entry.Entry[_entrys.Length];
            dtEntry.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _entrys.Length; i++)
            {
                if (_entrys[i].entryName.ToLower().Trim() == txtSearchEntry.Text.ToLower().Trim())
                {
                    _tmpEntry[j] = new Entry.Entry();
                    _tmpEntry[j] = _entrys[i];
                    object[] row = { _tmpEntry[j].entryName };
                    dtEntry.Rows.Add(row);
                    j++;
                }
            }
            _entrys = null;
            _entrys = _tmpEntry;
            _tmpEntry = null;
            allEntrysRepresented = false;
            bindEntrydata();
        }

        private void dgEntrys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    Entry.Entry[] _tmpEntry;
                    _tmpEntry = new Entry.Entry[_selectedEntrys.Length + 1];
                    for (int i = 0; i < _selectedEntrys.Length; i++)
                    {
                        _tmpEntry[i] = _selectedEntrys[i];
                    }
                    _selectedEntrys = _tmpEntry;
                    _selectedEntrys[_tmpEntry.Length - 1] = _entrys[Convert.ToInt32(e.RowIndex.ToString())];
                    //MessageBox.Show(_selectedNodes[0].nodeName + "  %%=%%  " + _selectedNodes.Length);
                    _tmpEntry = null;
                }
                catch
                {
                    _selectedEntrys = new Entry.Entry[1];
                    _selectedEntrys[0] = _entrys[Convert.ToInt32(e.RowIndex.ToString())];
                }
                showAllEntrys();
                bindEntrydata();
            }
        }

        private void cmbModel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateCategory();
        }

        private void frmAddnode_Load(object sender, EventArgs e)
        {
            updateCategory();
        }

        private void updateCategory()
        {
            FlexAccessDataSet.node_categoryDataTable node_categoryDataTable = taNode_category.GetDetailsNodeCategoryBy_NodeModelID(Convert.ToInt32(cmbModel.SelectedValue));
            foreach (FlexAccessDataSet.node_categoryRow node_categoryRow in node_categoryDataTable)
            {
                lblCategorieValue.Text = node_categoryRow.ndc_name;
            }
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            taNode.Insert(txtname.Text, Convert.ToInt32(cmbModel.SelectedValue), true, txtRemark.Text);
            try
            {
                if (_selectedEntrys.Length >= 1)
                {
                    for (int i = 0; i < _selectedEntrys.Length; i++)
                    {
                        taLink.Insert(_selectedSystemclient.systemclientId, Convert.ToInt32(taNode.GetLastNodeID()), _selectedEntrys[i].entryID);
                    }
                }
                else
                {
                    taLink.Insert(_selectedSystemclient.systemclientId, Convert.ToInt32(taNode.GetLastNodeID()), null);
                }
            }
            catch
            {
                taLink.Insert(_selectedSystemclient.systemclientId, Convert.ToInt32(taNode.GetLastNodeID()), null);
            }
            CustomMessage childCustomMessage = new CustomMessage("Er is een node toegevoegd");
            childCustomMessage.Show();
            this.Close();
        }
    }
}