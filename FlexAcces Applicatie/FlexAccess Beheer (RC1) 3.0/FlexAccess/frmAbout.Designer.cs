namespace FlexAccess
{
  partial class frmAbout
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
        this.tmrScroll = new System.Windows.Forms.Timer(this.components);
        this.rtbAbout = new System.Windows.Forms.RichTextBox();
        this.picHolyWest = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.picHolyWest)).BeginInit();
        this.SuspendLayout();
        // 
        // tmrScroll
        // 
        this.tmrScroll.Interval = 3000;
        this.tmrScroll.Tick += new System.EventHandler(this.tmrScroll_Tick);
        // 
        // rtbAbout
        // 
        this.rtbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.rtbAbout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.rtbAbout.Location = new System.Drawing.Point(1, 218);
        this.rtbAbout.Name = "rtbAbout";
        this.rtbAbout.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
        this.rtbAbout.Size = new System.Drawing.Size(450, 360);
        this.rtbAbout.TabIndex = 0;
        this.rtbAbout.Text = resources.GetString("rtbAbout.Text");
        // 
        // picHolyWest
        // 
        this.picHolyWest.Image = global::FlexAccess.Properties.Resources.HolyWest;
        this.picHolyWest.Location = new System.Drawing.Point(135, 35);
        this.picHolyWest.Name = "picHolyWest";
        this.picHolyWest.Size = new System.Drawing.Size(174, 158);
        this.picHolyWest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.picHolyWest.TabIndex = 1;
        this.picHolyWest.TabStop = false;
        // 
        // frmAbout
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(448, 220);
        this.Controls.Add(this.picHolyWest);
        this.Controls.Add(this.rtbAbout);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "frmAbout";
        this.Opacity = 0.7;
        this.Text = "Over FlexAccess";
        ((System.ComponentModel.ISupportInitialize)(this.picHolyWest)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer tmrScroll;
    private System.Windows.Forms.RichTextBox rtbAbout;
    private System.Windows.Forms.PictureBox picHolyWest;
  }
}