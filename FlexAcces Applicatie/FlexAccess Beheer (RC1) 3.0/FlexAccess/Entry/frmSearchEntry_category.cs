using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Entry
{
    public partial class frmSearchEntry_category : Form
    {

        private Entry_Categorie[] _category;
        private DataTable dt = new DataTable();
        private Boolean allEntryCategoryRepresented = false;

        public frmSearchEntry_category()
        {
            InitializeComponent();
            DataColumn col0 = new DataColumn("Naam", System.Type.GetType("System.String"));
            dt.Columns.Add(col0);
            showAllCategorys();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (allEntryCategoryRepresented == false)
            {
                showAllCategorys();
            }
            Entry_Categorie[] _tmpEntryCategorie;
            _tmpEntryCategorie = new Entry_Categorie[_category.Length];
            dt.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _category.Length; i++)
            {
                if (_category[i].entryCategorieName.ToLower() == txtName.Text.ToLower())
                {
                    _tmpEntryCategorie[j] = new Entry_Categorie();
                    _tmpEntryCategorie[j] = _category[i];
                    object[] row = { _tmpEntryCategorie[j].entryCategorieName };
                    dt.Rows.Add(row);
                    j++;
                }
            }
            _category = null;
            _category = _tmpEntryCategorie;
            _tmpEntryCategorie = null;
            allEntryCategoryRepresented = false;
            binddata();
        }

        private void cmdAll_Click(object sender, EventArgs e)
        {
            showAllCategorys();
            binddata();
        }

        private void dgEntryCategorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                frmDetailsEntry_category childAddEntry_category = new frmDetailsEntry_category(_category[Convert.ToInt32(e.RowIndex.ToString())]);
                childAddEntry_category.MdiParent = this.ParentForm;
                childAddEntry_category.Show();
                _category = null;
                this.Close();
            }
        }

        private void showAllCategorys()
        {
            dt.Clear();
            _category = null;

            FlexAccessDataSet.entry_categoryDataTable entry_categoryDataTable = taEntryCategory.getAllActiveEntryCategorys();
            _category = new Entry_Categorie[entry_categoryDataTable.Count];

            int i = 0;
            foreach (FlexAccessDataSet.entry_categoryRow categoryRow in entry_categoryDataTable)
            {
                _category[i] = new Entry_Categorie();
                _category[i].entryCategorieID = categoryRow.enc_id;
                _category[i].entryCategorieName = categoryRow.enc_name;
                _category[i].entryCategorieRemark = categoryRow.enc_description;

                object[] row = { _category[i].entryCategorieName };
                dt.Rows.Add(row);
                i++;
            }
            allEntryCategoryRepresented = true;
            binddata();
        }
        private void binddata()
        {
            dgEntryCategorie.DataSource = dt;
            dgEntryCategorie.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

    }
}