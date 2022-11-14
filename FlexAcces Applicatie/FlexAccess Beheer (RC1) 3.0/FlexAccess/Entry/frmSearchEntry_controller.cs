using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Entry
{
    public partial class frmSearchEntry_controller : Form
    {
        private Entry_Controller[] _controllers;
        private DataTable dt = new DataTable();
        private Boolean allEntryControllersRepresented = false;

        public frmSearchEntry_controller()
        {
            InitializeComponent();

            DataColumn col0 = new DataColumn("Naam", System.Type.GetType("System.String"));
            dt.Columns.Add(col0);
            showAllControllers();
            binddata();
        }

        private void showAllControllers()
        {
            dt.Clear();
            _controllers = null;

            FlexAccessDataSet.entry_controllerDataTable entry_controllerDataTable = taEntry_controller.GetActiveEntry_controllers();
            _controllers = new Entry_Controller[entry_controllerDataTable.Count];

            int i = 0;
            foreach (FlexAccessDataSet.entry_controllerRow entry_controllerRow in entry_controllerDataTable)
            {
                _controllers[i] = new Entry_Controller();
                _controllers[i].entryControllerID = entry_controllerRow.ecn_id;
                _controllers[i].entryControllerIP = entry_controllerRow.ecn_ip;
                _controllers[i].entryControllerName = entry_controllerRow.ecn_name;
                _controllers[i].entryControllerRemark = entry_controllerRow.ecn_remark;

                object[] row = { _controllers[i].entryControllerName};
                dt.Rows.Add(row);
                i++;
            }
            allEntryControllersRepresented = true;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (allEntryControllersRepresented == false)
            {
                showAllControllers();
            }
            Entry_Controller[] _tmpEntryController;
            _tmpEntryController = new Entry_Controller[_controllers.Length];
            dt.Rows.Clear();
            int j = 0;
            for (int i = 0; i < _controllers.Length; i++)
            {
                if (_controllers[i].entryControllerName.ToLower() == txtName.Text.ToLower())
                {
                    _tmpEntryController[j] = new Entry_Controller();
                    _tmpEntryController[j] = _controllers[i];
                    object[] row = { _tmpEntryController[j].entryControllerName };
                    dt.Rows.Add(row);
                    j++;
                }
            }
            _controllers = null;
            _controllers = _tmpEntryController;
            _tmpEntryController = null;
            allEntryControllersRepresented = false;
            binddata();
        }

        private void binddata()
        {
            dgEntryController.DataSource = dt;
            dgEntryController.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void cmdAll_Click(object sender, EventArgs e)
        {
            showAllControllers();
            binddata();
        }

        private void dgEntryController_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                frmDetailsEntry_controller childfrmDetailsEntry_controller = new frmDetailsEntry_controller(_controllers[Convert.ToInt32(e.RowIndex.ToString())]);
                childfrmDetailsEntry_controller.MdiParent = this.ParentForm;
                childfrmDetailsEntry_controller.Show();
                _controllers = null;
                this.Close();
            }
        }
    }
}