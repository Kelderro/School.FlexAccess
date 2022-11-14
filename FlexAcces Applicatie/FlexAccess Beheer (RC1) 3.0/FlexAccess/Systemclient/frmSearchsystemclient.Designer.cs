namespace FlexAccess.Systemclient
{
    partial class frmSearchsystemclient
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtip = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblip = new System.Windows.Forms.Label();
            this.dgSystemclient = new System.Windows.Forms.DataGridView();
            this.cmdZoek = new System.Windows.Forms.Button();
            this.cmdAll = new System.Windows.Forms.Button();
            this.taSystemclient = new FlexAccess.FlexAccessDataSetTableAdapters.systemclientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgSystemclient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(41, 17);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(213, 20);
            this.txtname.TabIndex = 0;
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(41, 52);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(213, 20);
            this.txtip.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblname.Location = new System.Drawing.Point(1, 21);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Naam";
            // 
            // lblip
            // 
            this.lblip.AutoSize = true;
            this.lblip.Location = new System.Drawing.Point(12, 56);
            this.lblip.Name = "lblip";
            this.lblip.Size = new System.Drawing.Size(17, 13);
            this.lblip.TabIndex = 3;
            this.lblip.Text = "IP";
            // 
            // dgSystemclient
            // 
            this.dgSystemclient.AllowUserToAddRows = false;
            this.dgSystemclient.AllowUserToDeleteRows = false;
            this.dgSystemclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSystemclient.Location = new System.Drawing.Point(15, 82);
            this.dgSystemclient.MultiSelect = false;
            this.dgSystemclient.Name = "dgSystemclient";
            this.dgSystemclient.ReadOnly = true;
            this.dgSystemclient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSystemclient.Size = new System.Drawing.Size(320, 289);
            this.dgSystemclient.TabIndex = 4;
            this.dgSystemclient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSystemclient_CellClick);
            // 
            // cmdZoek
            // 
            this.cmdZoek.Location = new System.Drawing.Point(260, 15);
            this.cmdZoek.Name = "cmdZoek";
            this.cmdZoek.Size = new System.Drawing.Size(75, 23);
            this.cmdZoek.TabIndex = 5;
            this.cmdZoek.Text = "Zoek";
            this.cmdZoek.UseVisualStyleBackColor = true;
            this.cmdZoek.Click += new System.EventHandler(this.cmdZoek_Click);
            // 
            // cmdAll
            // 
            this.cmdAll.Location = new System.Drawing.Point(260, 50);
            this.cmdAll.Name = "cmdAll";
            this.cmdAll.Size = new System.Drawing.Size(75, 23);
            this.cmdAll.TabIndex = 6;
            this.cmdAll.Text = "Alles";
            this.cmdAll.UseVisualStyleBackColor = true;
            this.cmdAll.Click += new System.EventHandler(this.txtAll_Click);
            // 
            // taSystemclient
            // 
            this.taSystemclient.ClearBeforeFill = true;
            // 
            // frmSearchsystemclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 384);
            this.Controls.Add(this.cmdAll);
            this.Controls.Add(this.cmdZoek);
            this.Controls.Add(this.dgSystemclient);
            this.Controls.Add(this.lblip);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.txtname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSearchsystemclient";
            this.Text = "Zoek Systemclient";
            ((System.ComponentModel.ISupportInitialize)(this.dgSystemclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlexAccess.FlexAccessDataSetTableAdapters.systemclientTableAdapter taSystemclient;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblip;
        private System.Windows.Forms.DataGridView dgSystemclient;
        private System.Windows.Forms.Button cmdZoek;
        private System.Windows.Forms.Button cmdAll;
    }
}