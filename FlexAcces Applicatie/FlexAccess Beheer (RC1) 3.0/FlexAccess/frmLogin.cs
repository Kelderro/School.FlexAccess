using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace FlexAccess
{
    public partial class frmLogin : Form
    {
        Boolean Fade = false;
        int prs_id;
        SoundPlayer player;

        public frmLogin()
        {
            InitializeComponent();
            OpaqueTimer.Start(); 
            player = new SoundPlayer();
            player.Stream = FlexAccess.Properties.Resources.login1;
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                player.Play();
                cmdLogin.Enabled = false;
                prs_id = Convert.ToInt32(taSystemuser.getPersonID(txtLoginname.Text, txtPassword.Text));
                if (prs_id != 0)
                {
                    
                    Fade = true;
                    OpaqueTimer.Start();
                }
                else
                {
                    cmdLogin.Enabled = true;
                    MessageBox.Show("Sorry, uw login gegevens komen niet overeen. Probeer het nogmaals");
                }
            }
            catch
            {
                MessageBox.Show("De database is momenteel niet bereikbaar.\nneem contact op met uw systeembeheerder");
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player.Play();
            Fade = true;
            OpaqueTimer.Start();
        }

        private void txtLoginname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.GetHashCode() == 851981)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.GetHashCode() == 851981)
            {
                SendKeys.Send("{TAB}");
                SendKeys.Send("{ENTER}");
            }
        }

        private void frmLogin_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("U dient in te loggen, dit kunt u doen om uw gebruikersnaam en wachtwoord in het vorige venster in te vullen. mocht u geen gebruikersnaam en wachwoord hebben neem dan contact op met de manager / systeembeheerder");
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpaqueTimer_Tick(object sender, EventArgs e)
        {
            if (Fade)
            {
                this.Opacity -= 0.05;
                if (this.Opacity == 0)
                {
                    Program.inlogPerson = prs_id;
                    this.DialogResult = DialogResult.OK;
                    OpaqueTimer.Stop();
                    this.Close();
                }
            }
            else
            {
                this.Opacity += 0.05;
                if (this.Opacity == 1)
                {
                    OpaqueTimer.Stop();
                }
            }
        }
    }
}