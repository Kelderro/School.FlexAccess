using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Entry
{
    public partial class frmViewOpenEntrys : Form
    {
        private DataTable dt = new DataTable();

        public frmViewOpenEntrys()
        {
            InitializeComponent();

            DataColumn col0 = new DataColumn("Opening", System.Type.GetType("System.String"));
            DataColumn col1 = new DataColumn("Open/Dicht", System.Type.GetType("System.String"));
            dt.Columns.Add(col0);
            dt.Columns.Add(col1);

            tmrCheckEntrys.Enabled = true;
            tmrCheckEntrys.Start();
            CheckEntrys();
        }

        private void CheckEntrys()
        {
            dt.Clear();
            FlexAccessDataSet.entryDataTable entryDataTable = taEntry.GetPowerdEntrys();
            foreach (FlexAccessDataSet.entryRow entryRow in entryDataTable)
            {
                String powerd;
                if (entryRow.enc_powered)
                {
                    powerd = "Open";
                }
                else
                {
                    powerd = "Dicht";
                }
                object[] row = { entryRow.ent_name,  powerd};
                dt.Rows.Add(row);
            }
            dgOpenEntrys.DataSource = dt;
            dgOpenEntrys.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgOpenEntrys.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void tmrCheckEntrys_Tick(object sender, EventArgs e)
        {
            CheckEntrys();
        }
    }
}