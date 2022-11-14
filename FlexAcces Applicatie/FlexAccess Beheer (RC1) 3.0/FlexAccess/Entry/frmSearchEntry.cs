using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Entry
{
    public partial class frmSearchEntry : Form
    {
        private Entry[] _Entry;
        private DataTable dt = new DataTable();
        private Boolean allEntrysRepresented = false;

        public frmSearchEntry()
        {
            InitializeComponent();
            DataColumn col0 = new DataColumn("Naam", System.Type.GetType("System.String"));
            dt.Columns.Add(col0);
            showAllEntrys();
        }

        private void showAllEntrys()
        {
            dt.Clear();
            _Entry = null;

            FlexAccessDataSet.entryDataTable entryDataTable = taEntry.GetAllActiveEntrys();
            _Entry = new Entry[entryDataTable.Count];

            int i = 0;
            foreach (FlexAccessDataSet.entryRow entryRow in entryDataTable)
            {
                Entry_Categorie _tmpEntryCategorie = new Entry_Categorie();
                Entry_Controller _tmpEntryController = new Entry_Controller();
                Zone.Zone _tmpEntryZone = new FlexAccess.Zone.Zone();
                _Entry[i] = new Entry();
                _Entry[i].entryID = entryRow.ent_id;
                _Entry[i].entryName = entryRow.ent_name;
                _Entry[i].entryRemark = entryRow.ent_remark;
                _Entry[i].entryPortnummer = entryRow.ecn_port_number;
                _tmpEntryCategorie.entryCategorieID = entryRow.enc_id;
                _tmpEntryController.entryControllerID = entryRow.ecn_id;
                _tmpEntryZone.ZoneID = entryRow.zne_id;
                _Entry[i].entryCategorie = _tmpEntryCategorie;
                _Entry[i].entryController = _tmpEntryController;
                _Entry[i].entryZone = _tmpEntryZone;

                object[] row = { _Entry[i].entryName };
                dt.Rows.Add(row);
                i++;
            }
            allEntrysRepresented = true;
            binddata();
        }
        private void binddata()
        {
            dgEntrys.DataSource = dt;
            dgEntrys.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (allEntrysRepresented == false)
            {
                showAllEntrys();
            }
            Entry[] _tmpEntrys;
            _tmpEntrys = new Entry[_Entry.Length];
            dt.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _Entry.Length; i++)
            {
                if (_Entry[i].entryName.ToLower().Trim() == txtName.Text.ToLower().Trim())
                {
                    _tmpEntrys[j] = new Entry();
                    _tmpEntrys[j] = _Entry[i];
                    object[] row = { _tmpEntrys[j].entryName };
                    dt.Rows.Add(row);
                    j++;
                }
            }
            _Entry = null;
            _Entry = _tmpEntrys;
            _tmpEntrys = null;
            allEntrysRepresented = false;
            binddata();
        }

        private void cmdAll_Click(object sender, EventArgs e)
        {
            showAllEntrys();
            binddata();
        }

        private void dgEntrys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                frmDetailsEntry childDetailsEntry = new frmDetailsEntry(_Entry[Convert.ToInt32(e.RowIndex.ToString())]);
                childDetailsEntry.MdiParent = this.ParentForm;
                childDetailsEntry.Show();
                _Entry = null;
                this.Close();
            }
        }
    }
}