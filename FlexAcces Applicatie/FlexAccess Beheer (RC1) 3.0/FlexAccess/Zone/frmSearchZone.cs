using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess
{
    public partial class frmSearchZone : Form
    {
        private Zone.Zone[] _zone;
        DataTable dt = new DataTable();
        private Boolean allZonesRepresented = false;

        public frmSearchZone()
        {
            InitializeComponent();

            DataColumn col0 = new DataColumn("Zone naam", System.Type.GetType("System.String"));
            dt.Columns.Add(col0);

            showAllZones();
            binddata();
        }

        private void dgSearchZone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                frmDetailZone childDetailsZone = new frmDetailZone(_zone[Convert.ToInt32(e.RowIndex.ToString())]);
                childDetailsZone.MdiParent = this.ParentForm;
                childDetailsZone.Show();
                _zone = null;
                this.Close();
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            if (cmdSearch.Text == "Alles")
            {
                _zone = null;
                showAllZones();
                binddata();
            }
            else
            {
                if (allZonesRepresented == false)
                {
                    showAllZones();
                }
                Zone.Zone[] _tmpZone;
                _tmpZone = new Zone.Zone[_zone.Length];
                int j = 0;
                for (int i = 0; i < _zone.Length; i++)
                {
                    if (_zone[i].ZoneName.ToLower() == txtZonename.Text.ToLower())
                    {
                        _tmpZone[j] = new Zone.Zone();
                        _tmpZone[j] = _zone[i];
                        object[] row = { _tmpZone[i].ZoneName };
                        dt.Rows.Add(row);
                        j++;
                    }
                }
                _zone = null;
                _zone = _tmpZone;
                _tmpZone = null;
                allZonesRepresented = false;
                binddata();
            }

            switch (cmdSearch.Text)
            {
                case "Zoek":
                    cmdSearch.Text = "Alles";
                    break;
                case "Alles":
                    cmdSearch.Text = "Zoek";
                    break;
            }
        }

        private void showAllZones()
        {
            FlexAccessDataSet.zoneDataTable zoneDataTable = taZone.GetActiveZones();
            _zone = new Zone.Zone[zoneDataTable.Count];

            int i = 0;
            foreach (FlexAccessDataSet.zoneRow zoneRow in zoneDataTable)
            {
                _zone[i] = new Zone.Zone();
                _zone[i].ZoneID = zoneRow.zne_id;
                _zone[i].ZoneName = zoneRow.zne_name;
                _zone[i].ZoneRemark = zoneRow.zne_remark;
                if (zoneRow.zne_plan == null)
                {
                    _zone[i].ZonePlan = null;
                }
                else
                {
                    _zone[i].ZonePlan = zoneRow.zne_plan;
                }
                object[] row = { _zone[i].ZoneName };
                dt.Rows.Add(row);
                i++;
            }
            allZonesRepresented = true;
        }

        private void binddata()
        {
            dgSearchZone.DataSource = dt;
            dgSearchZone.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}