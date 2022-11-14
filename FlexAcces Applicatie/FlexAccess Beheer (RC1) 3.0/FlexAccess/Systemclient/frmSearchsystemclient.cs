using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Systemclient
{
    public partial class frmSearchsystemclient : Form
    {

        private Systemclient[] _systemclient;
        private DataTable dt = new DataTable();
        private Boolean allSystemclientsRepresented = false;

        public frmSearchsystemclient()
        {
            InitializeComponent();
            DataColumn col0 = new DataColumn("Naam", System.Type.GetType("System.String"));
            DataColumn col1 = new DataColumn("IP", System.Type.GetType("System.String"));
            dt.Columns.Add(col0);
            dt.Columns.Add(col1);
            showAllSystemclients();
        }

        private void showAllSystemclients()
        {
            dt.Clear();
            _systemclient = null;
            FlexAccessDataSet.systemclientDataTable systemclientDataTable = taSystemclient.getAllActiveSystemclients();
            _systemclient = new Systemclient[systemclientDataTable.Count];
            int i = 0;
            foreach (FlexAccessDataSet.systemclientRow systemclientRow in systemclientDataTable)
            {
                _systemclient[i] = new Systemclient();
                _systemclient[i].systemclientId = systemclientRow.smc_id;
                _systemclient[i].systemclientIp = systemclientRow.smc_ip;
                _systemclient[i].systemclientName = systemclientRow.smc_name;
                _systemclient[i].systemclientRemark = systemclientRow.smc_remark;

                object[] row = { _systemclient[i].systemclientName, _systemclient[i].systemclientIp };
                dt.Rows.Add(row);
                i++;
            }
            allSystemclientsRepresented = true;
            binddata();
        }

        private void binddata()
        {
            dgSystemclient.DataSource = dt;
            dgSystemclient.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgSystemclient.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dgSystemclient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                frmDetailsystemclient childDetailsystemclient = new frmDetailsystemclient(_systemclient[Convert.ToInt32(e.RowIndex.ToString())]);
                childDetailsystemclient.MdiParent = this.ParentForm;
                childDetailsystemclient.Show();
                _systemclient = null;
                this.Close();

            }
        }

        private void txtAll_Click(object sender, EventArgs e)
        {
            showAllSystemclients();
            binddata();
        }

        private void cmdZoek_Click(object sender, EventArgs e)
        {
            if (allSystemclientsRepresented == false)
            {
                showAllSystemclients();
            }
            Systemclient[] _tmpSystemclient;
            _tmpSystemclient = new Systemclient[_systemclient.Length];
            dt.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _systemclient.Length; i++)
            {
                Boolean finish = false;
                if (_systemclient[i].systemclientName.ToLower() == txtname.Text.ToString().ToLower())
                {
                    MessageBox.Show("1");
                    _tmpSystemclient[j] = new Systemclient();
                    _tmpSystemclient[j] = _systemclient[i];
                    object[] row = { _tmpSystemclient[j].systemclientName, _tmpSystemclient[j].systemclientIp };
                    dt.Rows.Add(row);
                    j++;
                    finish = true;
                }
                if ((_systemclient[i].systemclientIp.Trim() == txtip.Text.ToLower().Trim()) && (finish == false) && (txtip.Text != ""))
                {
                    _tmpSystemclient[j] = new Systemclient();
                    _tmpSystemclient[j] = _systemclient[i];
                    object[] row = { _tmpSystemclient[j].systemclientName, _tmpSystemclient[j].systemclientIp };
                    dt.Rows.Add(row);
                    j++;
                    finish = true;
                }
            }
            _systemclient = null;
            _systemclient = _tmpSystemclient;
            _tmpSystemclient = null;
            allSystemclientsRepresented = false;
            binddata();
        }
    }
}