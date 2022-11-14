using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace FlexAccess.Emergency
{
    public partial class EmergencyClose : Form
    {
        private static Boolean Activaded;
        private FlexClient connection;
        private SoundPlayer player;

        public EmergencyClose(FlexClient connectie)
        {
            InitializeComponent();
            connection = connectie;
            Activaded = false;
            player = new SoundPlayer();
            player.Stream = FlexAccess.Properties.Resources.siren;
        }

        private void pbExecuteEmergency_Click(object sender, EventArgs e)
        {
            if (Activaded == false)
            {
                player.PlayLooping();
                lblOpenAlldoors.Text = "Stop noodprocedure";
                Activaded = true;
                tmrEmergency.Start();
                Connection.Send.CloseAllDoorsEmergencyOverride(connection.getClient());
                CustomMessage childCustomMessage = new CustomMessage("Noodprocedure actief");
                childCustomMessage.Show();
            }
            else
            {
                endEmergency();
                this.Dispose(false);
            }
        }

        private void endEmergency()
        {
            player.Stop();
            FlexAccess.Program.frmMain.enableEmergencyButtons();
            Connection.Send.StopEmergencyOverride(connection.getClient());
        }

        private void tmrEmergency_Tick(object sender, EventArgs e)
        {
            CustomMessage childCustomMessage = new CustomMessage("Noodprocedure actief");
            childCustomMessage.Show();
        }
    }
}