namespace FlexAccess
{
    partial class frmAddManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
      //  private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxPerson = new System.Windows.Forms.GroupBox();
            this.lblSelectedPersonValue = new System.Windows.Forms.Label();
            this.lblSelectedPerson = new System.Windows.Forms.Label();
            this.cmdAll = new System.Windows.Forms.Button();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFristname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.dgPerson = new System.Windows.Forms.DataGridView();
            this.lblLoginname = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.cmdAddSystemUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLoginname = new System.Windows.Forms.TextBox();
            this.cmdGeneratePassword = new System.Windows.Forms.Button();
            this.taPerson = new FlexAccess.FlexAccessDataSetTableAdapters.personTableAdapter();
            this.taSystemuser = new FlexAccess.FlexAccessDataSetTableAdapters.systemuserTableAdapter();
            this.gbxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPerson
            // 
            this.gbxPerson.Controls.Add(this.lblSelectedPersonValue);
            this.gbxPerson.Controls.Add(this.lblSelectedPerson);
            this.gbxPerson.Controls.Add(this.cmdAll);
            this.gbxPerson.Controls.Add(this.lblLastname);
            this.gbxPerson.Controls.Add(this.lblFristname);
            this.gbxPerson.Controls.Add(this.txtFirstname);
            this.gbxPerson.Controls.Add(this.txtMiddlename);
            this.gbxPerson.Controls.Add(this.cmdSearch);
            this.gbxPerson.Controls.Add(this.txtLastname);
            this.gbxPerson.Controls.Add(this.dgPerson);
            this.gbxPerson.Location = new System.Drawing.Point(12, 12);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Size = new System.Drawing.Size(546, 305);
            this.gbxPerson.TabIndex = 1;
            this.gbxPerson.TabStop = false;
            this.gbxPerson.Text = "Persoon:";
            // 
            // lblSelectedPersonValue
            // 
            this.lblSelectedPersonValue.AutoSize = true;
            this.lblSelectedPersonValue.Location = new System.Drawing.Point(178, 271);
            this.lblSelectedPersonValue.Name = "lblSelectedPersonValue";
            this.lblSelectedPersonValue.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedPersonValue.TabIndex = 19;
            // 
            // lblSelectedPerson
            // 
            this.lblSelectedPerson.AutoSize = true;
            this.lblSelectedPerson.Location = new System.Drawing.Point(11, 271);
            this.lblSelectedPerson.Name = "lblSelectedPerson";
            this.lblSelectedPerson.Size = new System.Drawing.Size(161, 13);
            this.lblSelectedPerson.TabIndex = 18;
            this.lblSelectedPerson.Text = "Momenteel geslecteerd persoon:";
            // 
            // cmdAll
            // 
            this.cmdAll.Location = new System.Drawing.Point(429, 36);
            this.cmdAll.Name = "cmdAll";
            this.cmdAll.Size = new System.Drawing.Size(102, 23);
            this.cmdAll.TabIndex = 17;
            this.cmdAll.Text = "Iedereen";
            this.cmdAll.UseVisualStyleBackColor = true;
            this.cmdAll.Click += new System.EventHandler(this.cmdAll_Click);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(209, 19);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(64, 13);
            this.lblLastname.TabIndex = 16;
            this.lblLastname.Text = "Achternaam";
            // 
            // lblFristname
            // 
            this.lblFristname.AutoSize = true;
            this.lblFristname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFristname.Location = new System.Drawing.Point(11, 20);
            this.lblFristname.Name = "lblFristname";
            this.lblFristname.Size = new System.Drawing.Size(55, 13);
            this.lblFristname.TabIndex = 15;
            this.lblFristname.Text = "Voornaam";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(14, 36);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(120, 20);
            this.txtFirstname.TabIndex = 14;
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Location = new System.Drawing.Point(140, 36);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(63, 20);
            this.txtMiddlename.TabIndex = 13;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(358, 36);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(65, 23);
            this.cmdSearch.TabIndex = 12;
            this.cmdSearch.Text = "Zoek";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(209, 36);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(143, 20);
            this.txtLastname.TabIndex = 11;
            // 
            // dgPerson
            // 
            this.dgPerson.AllowUserToAddRows = false;
            this.dgPerson.AllowUserToDeleteRows = false;
            this.dgPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPerson.Location = new System.Drawing.Point(13, 63);
            this.dgPerson.Name = "dgPerson";
            this.dgPerson.ReadOnly = true;
            this.dgPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPerson.Size = new System.Drawing.Size(518, 193);
            this.dgPerson.TabIndex = 10;
            this.dgPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPerson_CellClick);
            // 
            // lblLoginname
            // 
            this.lblLoginname.AutoSize = true;
            this.lblLoginname.Location = new System.Drawing.Point(23, 353);
            this.lblLoginname.Name = "lblLoginname";
            this.lblLoginname.Size = new System.Drawing.Size(59, 13);
            this.lblLoginname.TabIndex = 2;
            this.lblLoginname.Text = "Loginnaam";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(23, 388);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lblWachtwoord.TabIndex = 3;
            this.lblWachtwoord.Text = "Wachtwoord";
            // 
            // cmdAddSystemUser
            // 
            this.cmdAddSystemUser.Location = new System.Drawing.Point(191, 439);
            this.cmdAddSystemUser.Name = "cmdAddSystemUser";
            this.cmdAddSystemUser.Size = new System.Drawing.Size(173, 23);
            this.cmdAddSystemUser.TabIndex = 5;
            this.cmdAddSystemUser.Text = "Toevoegen nieuwe beheerder";
            this.cmdAddSystemUser.UseVisualStyleBackColor = true;
            this.cmdAddSystemUser.Click += new System.EventHandler(this.cmdAddSystemUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 385);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(159, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtLoginname
            // 
            this.txtLoginname.Location = new System.Drawing.Point(100, 350);
            this.txtLoginname.Name = "txtLoginname";
            this.txtLoginname.Size = new System.Drawing.Size(159, 20);
            this.txtLoginname.TabIndex = 7;
            // 
            // cmdGeneratePassword
            // 
            this.cmdGeneratePassword.Location = new System.Drawing.Point(294, 383);
            this.cmdGeneratePassword.Name = "cmdGeneratePassword";
            this.cmdGeneratePassword.Size = new System.Drawing.Size(141, 23);
            this.cmdGeneratePassword.TabIndex = 8;
            this.cmdGeneratePassword.Text = "Genereer paswoord";
            this.cmdGeneratePassword.UseVisualStyleBackColor = true;
            this.cmdGeneratePassword.Click += new System.EventHandler(this.cmdGeneratePassword_Click);
            // 
            // taPerson
            // 
            this.taPerson.ClearBeforeFill = true;
            // 
            // taSystemuser
            // 
            this.taSystemuser.ClearBeforeFill = true;
            // 
            // frmAddManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 474);
            this.Controls.Add(this.cmdGeneratePassword);
            this.Controls.Add(this.txtLoginname);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmdAddSystemUser);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblLoginname);
            this.Controls.Add(this.gbxPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddManager";
            this.Text = "Beheerder toevoegen";
            this.gbxPerson.ResumeLayout(false);
            this.gbxPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.Label lblSelectedPerson;
        private System.Windows.Forms.Button cmdAll;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFristname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.DataGridView dgPerson;
        private System.Windows.Forms.Label lblSelectedPersonValue;
        private FlexAccess.FlexAccessDataSetTableAdapters.personTableAdapter taPerson;
        private System.Windows.Forms.Label lblLoginname;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.Button cmdAddSystemUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLoginname;
        private System.Windows.Forms.Button cmdGeneratePassword;
        private FlexAccess.FlexAccessDataSetTableAdapters.systemuserTableAdapter taSystemuser;
    }
}