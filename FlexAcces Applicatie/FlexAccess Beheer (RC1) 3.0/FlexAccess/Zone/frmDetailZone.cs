using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FlexAccess
{
    public partial class frmDetailZone : Form
    {
        private Zone.Zone _zone;

        public frmDetailZone(Zone.Zone objZone)
        {
            InitializeComponent();
            _zone = objZone;

            this.Text = this.Text + _zone.ZoneName;

            txtName.Text = _zone.ZoneName;
            txtRemark.Text = _zone.ZoneRemark;
            pbPlan.Image = byteArrayToImage(_zone.ZonePlan);
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wilt u deze zone echt verwijderen?", "Beverstig verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taZone.DeleteZone(_zone.ZoneID);
                CustomMessage childCustomMessage = new CustomMessage(_zone.ZoneName + " verwijderd");
                childCustomMessage.Show();
                frmSearchZone childSearchZone = new frmSearchZone();
                childSearchZone.MdiParent = this.ParentForm;
                childSearchZone.Show();
                this.Close();
            }
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            taZone.Update(_zone.ZonePlan, txtName.Text, txtRemark.Text,_zone.ZoneID);
            CustomMessage childCustomMessage = new CustomMessage(_zone.ZoneName+ " gewijzigd");
            childCustomMessage.Show();
            this.Close();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            frmSearchZone childfrmSearchZone = new frmSearchZone();
            
            childfrmSearchZone.Show();
            this.Close();
        }
    }
}