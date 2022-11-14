using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess
{
  public partial class frmAbout : Form
  {
    public frmAbout()
    {
      InitializeComponent();
      tmrScroll.Enabled = true;
      picHolyWest.Top   = (this.Height / 2) - 90;
      rtbAbout.Top      = this.Height;
    }

    private void tmrScroll_Tick(object sender, EventArgs e)
    {
      if (picHolyWest.Top == (this.Height / 2) - 89)
      {
        // Timer "pauze"
        tmrScroll.Interval = 3000;
      }
      else
      {
        tmrScroll.Interval = 10;
      }

      if (rtbAbout.Top > (rtbAbout.Height * -1))
      {
        rtbAbout.Top--;
        picHolyWest.Top--;
      }
      else
      {
        picHolyWest.Top = this.Height;
        rtbAbout.Top = picHolyWest.Top + picHolyWest.Height + 30;
      }
    }

      private void frmAbout_Load(object sender, EventArgs e)
      {

      }
  }
}