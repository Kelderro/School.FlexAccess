using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess
{
    public partial class CustomMessage : Form
    {
        int i = 0;
        public CustomMessage(string Message)
        {
            InitializeComponent();
            this.Opacity = 0.0;
            lblMessage.Text = Message;
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            if (i < 20)
            {
                this.Opacity += 0.05;
            }
            if ((i > 30) && (i<=50))
            {
                this.Opacity -= 0.05;
            }
            if (i == 50)
            {
                this.Close();
            }
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}