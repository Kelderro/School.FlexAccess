namespace FlexAccess.Systemclient
{
    partial class frmAddsystemclient
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
            this.taSystemclient = new FlexAccess.FlexAccessDataSetTableAdapters.systemclientTableAdapter();
            this.lblname = new System.Windows.Forms.Label();
            this.lblip = new System.Windows.Forms.Label();
            this.lblremark = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtip = new System.Windows.Forms.TextBox();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.cmdsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taSystemclient
            // 
            this.taSystemclient.ClearBeforeFill = true;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(12, 27);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Naam";
            // 
            // lblip
            // 
            this.lblip.AutoSize = true;
            this.lblip.Location = new System.Drawing.Point(13, 67);
            this.lblip.Name = "lblip";
            this.lblip.Size = new System.Drawing.Size(17, 13);
            this.lblip.TabIndex = 1;
            this.lblip.Text = "IP";
            // 
            // lblremark
            // 
            this.lblremark.AutoSize = true;
            this.lblremark.Location = new System.Drawing.Point(13, 105);
            this.lblremark.Name = "lblremark";
            this.lblremark.Size = new System.Drawing.Size(64, 13);
            this.lblremark.TabIndex = 2;
            this.lblremark.Text = "Omschijving";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(83, 20);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(197, 20);
            this.txtname.TabIndex = 3;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(83, 60);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(197, 20);
            this.txtip.TabIndex = 4;
            this.txtip.TextChanged += new System.EventHandler(this.txtip_TextChanged);
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(83, 105);
            this.txtremark.Multiline = true;
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(197, 97);
            this.txtremark.TabIndex = 5;
            this.txtremark.TextChanged += new System.EventHandler(this.txtremark_TextChanged);
            // 
            // cmdsubmit
            // 
            this.cmdsubmit.Enabled = false;
            this.cmdsubmit.Location = new System.Drawing.Point(83, 222);
            this.cmdsubmit.Name = "cmdsubmit";
            this.cmdsubmit.Size = new System.Drawing.Size(197, 23);
            this.cmdsubmit.TabIndex = 6;
            this.cmdsubmit.Text = "Toevoegen";
            this.cmdsubmit.UseVisualStyleBackColor = true;
            this.cmdsubmit.Click += new System.EventHandler(this.cmdsubmit_Click);
            // 
            // frmAddsystemclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 263);
            this.Controls.Add(this.cmdsubmit);
            this.Controls.Add(this.txtremark);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblremark);
            this.Controls.Add(this.lblip);
            this.Controls.Add(this.lblname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddsystemclient";
            this.ShowIcon = false;
            this.Text = "Toevoegen Systemclient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlexAccess.FlexAccessDataSetTableAdapters.systemclientTableAdapter taSystemclient;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblip;
        private System.Windows.Forms.Label lblremark;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.Button cmdsubmit;
    }
}