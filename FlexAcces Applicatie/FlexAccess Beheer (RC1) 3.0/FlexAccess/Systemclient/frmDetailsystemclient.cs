using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Systemclient
{
    public partial class frmDetailsystemclient : Form
    {
        private Systemclient _systemclient = new Systemclient();
        private DataTable dt = new DataTable();

        public frmDetailsystemclient(Systemclient client)
        {
            InitializeComponent();
            _systemclient = client;
            client = null;
            txtip.Text = _systemclient.systemclientIp;
            txtname.Text = _systemclient.systemclientName;
            txtremark.Text = _systemclient.systemclientRemark;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            frmSearchsystemclient childfrmSearchsystemclient = new frmSearchsystemclient();
            childfrmSearchsystemclient.Show();
            this.Close();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wilt u deze systemclient echt verwijderen?\nDit houd in dat alle apparaten op deze systemclient\nook onbruikbaar worden", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taSystemclient.DeleteSystemclient(_systemclient.systemclientId);
                CustomMessage childCustomMessage = new CustomMessage(_systemclient.systemclientName + " is verwijderd");
                childCustomMessage.Show();
                this.Close();
            }
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            taSystemclient.Update(txtip.Text, txtname.Text, txtremark.Text, _systemclient.systemclientId);
            CustomMessage childCustomMessage = new CustomMessage(_systemclient.systemclientName + " is gewijzigd");
            childCustomMessage.Show();
            this.Close();
        }
    }
}