namespace FlexAccess
{
    partial class frmAddZone
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
            this.lblZoneName = new System.Windows.Forms.Label();
            this.txtZoneName = new System.Windows.Forms.TextBox();
            this.txtZoneRemark = new System.Windows.Forms.TextBox();
            this.lblZoneRemark = new System.Windows.Forms.Label();
            this.cmdAddPlan = new System.Windows.Forms.Button();
            this.cmdAddZone = new System.Windows.Forms.Button();
            this.ofdPlan = new System.Windows.Forms.OpenFileDialog();
            this.taZone = new FlexAccess.FlexAccessDataSetTableAdapters.zoneTableAdapter();
            this.SuspendLayout();
            // 
            // lblZoneName
            // 
            this.lblZoneName.AutoSize = true;
            this.lblZoneName.Location = new System.Drawing.Point(37, 15);
            this.lblZoneName.Name = "lblZoneName";
            this.lblZoneName.Size = new System.Drawing.Size(35, 13);
            this.lblZoneName.TabIndex = 0;
            this.lblZoneName.Text = "Naam";
            // 
            // txtZoneName
            // 
            this.txtZoneName.Location = new System.Drawing.Point(124, 12);
            this.txtZoneName.Name = "txtZoneName";
            this.txtZoneName.Size = new System.Drawing.Size(220, 20);
            this.txtZoneName.TabIndex = 1;
            this.txtZoneName.TextChanged += new System.EventHandler(this.txtZoneName_TextChanged);
            // 
            // txtZoneRemark
            // 
            this.txtZoneRemark.Location = new System.Drawing.Point(124, 38);
            this.txtZoneRemark.Multiline = true;
            this.txtZoneRemark.Name = "txtZoneRemark";
            this.txtZoneRemark.Size = new System.Drawing.Size(220, 151);
            this.txtZoneRemark.TabIndex = 3;
            // 
            // lblZoneRemark
            // 
            this.lblZoneRemark.AutoSize = true;
            this.lblZoneRemark.Location = new System.Drawing.Point(37, 41);
            this.lblZoneRemark.Name = "lblZoneRemark";
            this.lblZoneRemark.Size = new System.Drawing.Size(58, 13);
            this.lblZoneRemark.TabIndex = 2;
            this.lblZoneRemark.Text = "Opmerking";
            // 
            // cmdAddPlan
            // 
            this.cmdAddPlan.Location = new System.Drawing.Point(124, 195);
            this.cmdAddPlan.Name = "cmdAddPlan";
            this.cmdAddPlan.Size = new System.Drawing.Size(220, 23);
            this.cmdAddPlan.TabIndex = 4;
            this.cmdAddPlan.Text = "Plategrond toevoegen";
            this.cmdAddPlan.UseVisualStyleBackColor = true;
            this.cmdAddPlan.Click += new System.EventHandler(this.cmdAddPlan_Click);
            // 
            // cmdAddZone
            // 
            this.cmdAddZone.Enabled = false;
            this.cmdAddZone.Location = new System.Drawing.Point(12, 252);
            this.cmdAddZone.Name = "cmdAddZone";
            this.cmdAddZone.Size = new System.Drawing.Size(332, 23);
            this.cmdAddZone.TabIndex = 5;
            this.cmdAddZone.Text = "voeg nieuwe zone toe";
            this.cmdAddZone.UseVisualStyleBackColor = true;
            this.cmdAddZone.Click += new System.EventHandler(this.cmdAddZone_Click);
            
            // 
            // ofdPlan
            // 
            this.ofdPlan.DefaultExt = "jpg";
            this.ofdPlan.Filter = "Plategrond bestanden (jpg,jpeg,bmp)|*.jpg;*.jpeg;*.bmp";
            this.ofdPlan.ShowHelp = true;
            this.ofdPlan.Title = "Plategrond voor nieuwe zone";
            this.ofdPlan.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdPlan_FileOk);
            // 
            // taZone
            // 
            this.taZone.ClearBeforeFill = true;
            // 
            // frmAddZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 287);
            this.Controls.Add(this.cmdAddZone);
            this.Controls.Add(this.cmdAddPlan);
            this.Controls.Add(this.txtZoneRemark);
            this.Controls.Add(this.lblZoneRemark);
            this.Controls.Add(this.txtZoneName);
            this.Controls.Add(this.lblZoneName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddZone";
            this.ShowIcon = false;
            this.Text = "Zone toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZoneName;
        private System.Windows.Forms.TextBox txtZoneName;
        private System.Windows.Forms.TextBox txtZoneRemark;
        private System.Windows.Forms.Label lblZoneRemark;
        private System.Windows.Forms.Button cmdAddPlan;
        private System.Windows.Forms.Button cmdAddZone;
        private System.Windows.Forms.OpenFileDialog ofdPlan;
        private FlexAccess.FlexAccessDataSetTableAdapters.zoneTableAdapter taZone;
    }
}