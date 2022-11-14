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
    public partial class frmAddZone : Form
    {
        private String PlanLocation;

        public frmAddZone()
        {
            InitializeComponent();
        }

        private void controle()
        {
            if (txtZoneName.Text != "")
            {
                cmdAddZone.Enabled = true;
            }
            else
            {
                cmdAddZone.Enabled = false;
            }
        }

        private void cmdAddZone_Click(object sender, EventArgs e)
        {
            
            byte[] imagedata = null;
            if (PlanLocation != null)
            {
                if (PlanLocation.Equals(""))
                {
                    imagedata = imageToByteArray(FlexAccess.Properties.Resources.noImage);
                }
                else
                {
                    imagedata = imageToByteArray(Image.FromFile(PlanLocation));
                }
            }
            else
            {
                imagedata = imageToByteArray(FlexAccess.Properties.Resources.noImage);
            }
            taZone.Insert(txtZoneName.Text, txtZoneRemark.Text,imagedata, true);
            CustomMessage childCustomMessage = new CustomMessage(txtZoneName.Text + "toegevoegd");
            childCustomMessage.Show();
            this.Close();
        }

        private void cmdAddPlan_Click(object sender, EventArgs e)
        {
            ofdPlan.ShowDialog();
        }

        private void ofdPlan_FileOk(object sender, CancelEventArgs e)
        {
            ofdPlan.InitialDirectory = PlanLocation;
            PlanLocation = ofdPlan.FileName;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }



        private void txtZoneName_KeyPress(object sender, KeyPressEventArgs e)
        {
            controle();
        }

        private void txtZoneName_TextChanged(object sender, EventArgs e)
        {
            controle();


        }
    }

}