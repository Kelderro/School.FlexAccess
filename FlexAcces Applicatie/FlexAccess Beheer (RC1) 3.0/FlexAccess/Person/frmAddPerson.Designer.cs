namespace FlexAccess
{
    partial class frmAddPerson
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
            this.txtFristname = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblFristname = new System.Windows.Forms.Label();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.cmdAddPerson = new System.Windows.Forms.Button();
            this.taPerson = new FlexAccess.FlexAccessDataSetTableAdapters.personTableAdapter();
            this.taPerson_group = new FlexAccess.FlexAccessDataSetTableAdapters.person_groupTableAdapter();
            this.taPerson_has_person_group = new FlexAccess.FlexAccessDataSetTableAdapters.person_has_person_groupTableAdapter();
            this.gbPersonGroups = new System.Windows.Forms.GroupBox();
            this.cmdEmptyPersonGroups = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtSearchPersongroups = new System.Windows.Forms.TextBox();
            this.cmdShowAllPersonGroups = new System.Windows.Forms.Button();
            this.dgPersonGroups = new System.Windows.Forms.DataGridView();
            this.cmdShowSelectedPersonGroups = new System.Windows.Forms.Button();
            this.cmdSearchPersonGroups = new System.Windows.Forms.Button();
            this.gbPersonGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFristname
            // 
            this.txtFristname.Location = new System.Drawing.Point(101, 10);
            this.txtFristname.Name = "txtFristname";
            this.txtFristname.Size = new System.Drawing.Size(200, 20);
            this.txtFristname.TabIndex = 0;
            this.txtFristname.TextChanged += new System.EventHandler(this.txtFristname_TextChanged);
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Location = new System.Drawing.Point(101, 36);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(100, 20);
            this.txtMiddlename.TabIndex = 1;
            this.txtMiddlename.TextChanged += new System.EventHandler(this.txtMiddlename_TextChanged);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(101, 63);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(200, 20);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.TextChanged += new System.EventHandler(this.txtLastname_TextChanged);
            // 
            // lblFristname
            // 
            this.lblFristname.AutoSize = true;
            this.lblFristname.Location = new System.Drawing.Point(40, 13);
            this.lblFristname.Name = "lblFristname";
            this.lblFristname.Size = new System.Drawing.Size(55, 13);
            this.lblFristname.TabIndex = 3;
            this.lblFristname.Text = "Voornaam";
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.Location = new System.Drawing.Point(15, 39);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(80, 13);
            this.lblMiddlename.TabIndex = 4;
            this.lblMiddlename.Text = "tussenvoegsels";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(31, 66);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(64, 13);
            this.lblLastname.TabIndex = 5;
            this.lblLastname.Text = "Achternaam";
            // 
            // cmdAddPerson
            // 
            this.cmdAddPerson.Enabled = false;
            this.cmdAddPerson.Location = new System.Drawing.Point(12, 389);
            this.cmdAddPerson.Name = "cmdAddPerson";
            this.cmdAddPerson.Size = new System.Drawing.Size(289, 23);
            this.cmdAddPerson.TabIndex = 6;
            this.cmdAddPerson.Text = "Toevoegen van gebruiker";
            this.cmdAddPerson.UseVisualStyleBackColor = true;
            this.cmdAddPerson.Click += new System.EventHandler(this.cmdAddPerson_Click);
            // 
            // taPerson
            // 
            this.taPerson.ClearBeforeFill = true;
            // 
            // taPerson_group
            // 
            this.taPerson_group.ClearBeforeFill = true;
            // 
            // taPerson_has_person_group
            // 
            this.taPerson_has_person_group.ClearBeforeFill = true;
            // 
            // gbPersonGroups
            // 
            this.gbPersonGroups.Controls.Add(this.cmdEmptyPersonGroups);
            this.gbPersonGroups.Controls.Add(this.lbl);
            this.gbPersonGroups.Controls.Add(this.txtSearchPersongroups);
            this.gbPersonGroups.Controls.Add(this.cmdShowAllPersonGroups);
            this.gbPersonGroups.Controls.Add(this.dgPersonGroups);
            this.gbPersonGroups.Controls.Add(this.cmdShowSelectedPersonGroups);
            this.gbPersonGroups.Controls.Add(this.cmdSearchPersonGroups);
            this.gbPersonGroups.Location = new System.Drawing.Point(18, 106);
            this.gbPersonGroups.Name = "gbPersonGroups";
            this.gbPersonGroups.Size = new System.Drawing.Size(283, 267);
            this.gbPersonGroups.TabIndex = 7;
            this.gbPersonGroups.TabStop = false;
            this.gbPersonGroups.Text = "Persoons groepen";
            // 
            // cmdEmptyPersonGroups
            // 
            this.cmdEmptyPersonGroups.Location = new System.Drawing.Point(59, 238);
            this.cmdEmptyPersonGroups.Name = "cmdEmptyPersonGroups";
            this.cmdEmptyPersonGroups.Size = new System.Drawing.Size(209, 23);
            this.cmdEmptyPersonGroups.TabIndex = 7;
            this.cmdEmptyPersonGroups.Text = "de- selecteer alle persoonsgroepen";
            this.cmdEmptyPersonGroups.UseVisualStyleBackColor = true;
            this.cmdEmptyPersonGroups.Click += new System.EventHandler(this.cmdEmptyPersonGroups_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(13, 212);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(174, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Momenteel geselecteerde groepen:";
            // 
            // txtSearchPersongroups
            // 
            this.txtSearchPersongroups.Location = new System.Drawing.Point(16, 22);
            this.txtSearchPersongroups.Name = "txtSearchPersongroups";
            this.txtSearchPersongroups.Size = new System.Drawing.Size(167, 20);
            this.txtSearchPersongroups.TabIndex = 5;
            // 
            // cmdShowAllPersonGroups
            // 
            this.cmdShowAllPersonGroups.Location = new System.Drawing.Point(193, 53);
            this.cmdShowAllPersonGroups.Name = "cmdShowAllPersonGroups";
            this.cmdShowAllPersonGroups.Size = new System.Drawing.Size(75, 23);
            this.cmdShowAllPersonGroups.TabIndex = 4;
            this.cmdShowAllPersonGroups.Text = "alle";
            this.cmdShowAllPersonGroups.UseVisualStyleBackColor = true;
            this.cmdShowAllPersonGroups.Click += new System.EventHandler(this.cmdShowAllPersonGroups_Click);
            // 
            // dgPersonGroups
            // 
            this.dgPersonGroups.AllowUserToAddRows = false;
            this.dgPersonGroups.AllowUserToDeleteRows = false;
            this.dgPersonGroups.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgPersonGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonGroups.Location = new System.Drawing.Point(16, 65);
            this.dgPersonGroups.MultiSelect = false;
            this.dgPersonGroups.Name = "dgPersonGroups";
            this.dgPersonGroups.ReadOnly = true;
            this.dgPersonGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPersonGroups.Size = new System.Drawing.Size(252, 134);
            this.dgPersonGroups.TabIndex = 3;
            this.dgPersonGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersonGroups_CellClick);
            // 
            // cmdShowSelectedPersonGroups
            // 
            this.cmdShowSelectedPersonGroups.Location = new System.Drawing.Point(193, 207);
            this.cmdShowSelectedPersonGroups.Name = "cmdShowSelectedPersonGroups";
            this.cmdShowSelectedPersonGroups.Size = new System.Drawing.Size(75, 23);
            this.cmdShowSelectedPersonGroups.TabIndex = 2;
            this.cmdShowSelectedPersonGroups.Text = "toon";
            this.cmdShowSelectedPersonGroups.UseVisualStyleBackColor = true;
            this.cmdShowSelectedPersonGroups.Click += new System.EventHandler(this.cmdShowSelectedPersonGroups_Click);
            // 
            // cmdSearchPersonGroups
            // 
            this.cmdSearchPersonGroups.Location = new System.Drawing.Point(193, 20);
            this.cmdSearchPersonGroups.Name = "cmdSearchPersonGroups";
            this.cmdSearchPersonGroups.Size = new System.Drawing.Size(75, 23);
            this.cmdSearchPersonGroups.TabIndex = 0;
            this.cmdSearchPersonGroups.Text = "zoek";
            this.cmdSearchPersonGroups.UseVisualStyleBackColor = true;
            this.cmdSearchPersonGroups.Click += new System.EventHandler(this.cmdSearchPersonGroups_Click);
            // 
            // frmAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 424);
            this.Controls.Add(this.gbPersonGroups);
            this.Controls.Add(this.cmdAddPerson);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblMiddlename);
            this.Controls.Add(this.lblFristname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtMiddlename);
            this.Controls.Add(this.txtFristname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddPerson";
            this.ShowIcon = false;
            this.Text = "Peroon toevoegen";
            this.gbPersonGroups.ResumeLayout(false);
            this.gbPersonGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFristname;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblFristname;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Button cmdAddPerson;
        private FlexAccess.FlexAccessDataSetTableAdapters.personTableAdapter taPerson;
        private FlexAccess.FlexAccessDataSetTableAdapters.person_groupTableAdapter taPerson_group;
        private FlexAccess.FlexAccessDataSetTableAdapters.person_has_person_groupTableAdapter taPerson_has_person_group;
        private System.Windows.Forms.GroupBox gbPersonGroups;
        private System.Windows.Forms.TextBox txtSearchPersongroups;
        private System.Windows.Forms.Button cmdShowAllPersonGroups;
        private System.Windows.Forms.Button cmdShowSelectedPersonGroups;
        private System.Windows.Forms.Button cmdSearchPersonGroups;
        private System.Windows.Forms.Button cmdEmptyPersonGroups;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridView dgPersonGroups;
    }
}