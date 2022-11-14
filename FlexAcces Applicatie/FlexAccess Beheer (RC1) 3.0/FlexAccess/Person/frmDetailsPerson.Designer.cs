namespace FlexAccess
{
    partial class frmDetailsPerson
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
            this.cmdChangePerson = new System.Windows.Forms.Button();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.lblFrontname = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtFristname = new System.Windows.Forms.TextBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.taPerson = new FlexAccess.FlexAccessDataSetTableAdapters.personTableAdapter();
            this.cmdFingerprints = new System.Windows.Forms.Button();
            this.lblExtra = new System.Windows.Forms.Label();
            this.cmdExtendScreen = new System.Windows.Forms.Button();
            this.dgSelectedPersonGroup = new System.Windows.Forms.DataGridView();
            this.dgNonSelectedPersonGroups = new System.Windows.Forms.DataGridView();
            this.cmdRightToLeft = new System.Windows.Forms.Button();
            this.cmdLeftToRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectedPersonGroupItemValue = new System.Windows.Forms.Label();
            this.taPerson_group = new FlexAccess.FlexAccessDataSetTableAdapters.person_groupTableAdapter();
            this.taPerson_has_person_group = new FlexAccess.FlexAccessDataSetTableAdapters.person_has_person_groupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectedPersonGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNonSelectedPersonGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdChangePerson
            // 
            this.cmdChangePerson.Location = new System.Drawing.Point(12, 165);
            this.cmdChangePerson.Name = "cmdChangePerson";
            this.cmdChangePerson.Size = new System.Drawing.Size(233, 23);
            this.cmdChangePerson.TabIndex = 20;
            this.cmdChangePerson.Text = "Wijzigen van gebruiker";
            this.cmdChangePerson.UseVisualStyleBackColor = true;
            this.cmdChangePerson.Click += new System.EventHandler(this.cmdChangePerson_Click);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(28, 68);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(64, 13);
            this.lblLastname.TabIndex = 19;
            this.lblLastname.Text = "Achternaam";
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.Location = new System.Drawing.Point(12, 41);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(80, 13);
            this.lblMiddlename.TabIndex = 18;
            this.lblMiddlename.Text = "tussenvoegsels";
            // 
            // lblFrontname
            // 
            this.lblFrontname.AutoSize = true;
            this.lblFrontname.Location = new System.Drawing.Point(37, 15);
            this.lblFrontname.Name = "lblFrontname";
            this.lblFrontname.Size = new System.Drawing.Size(55, 13);
            this.lblFrontname.TabIndex = 17;
            this.lblFrontname.Text = "Voornaam";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(98, 65);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(200, 20);
            this.txtLastname.TabIndex = 16;
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Location = new System.Drawing.Point(98, 38);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(100, 20);
            this.txtMiddlename.TabIndex = 15;
            // 
            // txtFristname
            // 
            this.txtFristname.Location = new System.Drawing.Point(98, 12);
            this.txtFristname.Name = "txtFristname";
            this.txtFristname.Size = new System.Drawing.Size(200, 20);
            this.txtFristname.TabIndex = 14;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(251, 165);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 21;
            this.cmdDelete.Text = "Verwijderen";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // taPerson
            // 
            this.taPerson.ClearBeforeFill = true;
            // 
            // cmdFingerprints
            // 
            this.cmdFingerprints.Location = new System.Drawing.Point(98, 91);
            this.cmdFingerprints.Name = "cmdFingerprints";
            this.cmdFingerprints.Size = new System.Drawing.Size(200, 23);
            this.cmdFingerprints.TabIndex = 22;
            this.cmdFingerprints.Text = "Wijzig vingerafdruk";
            this.cmdFingerprints.UseVisualStyleBackColor = true;
            this.cmdFingerprints.Click += new System.EventHandler(this.cmdFingerprints_Click);
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(28, 96);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(62, 13);
            this.lblExtra.TabIndex = 23;
            this.lblExtra.Text = "Extra opties";
            // 
            // cmdExtendScreen
            // 
            this.cmdExtendScreen.Location = new System.Drawing.Point(98, 120);
            this.cmdExtendScreen.Name = "cmdExtendScreen";
            this.cmdExtendScreen.Size = new System.Drawing.Size(200, 23);
            this.cmdExtendScreen.TabIndex = 24;
            this.cmdExtendScreen.Text = "Wijzig persoonlijke groep(-en)";
            this.cmdExtendScreen.UseVisualStyleBackColor = true;
            this.cmdExtendScreen.Click += new System.EventHandler(this.cmdExtendScreen_Click);
            // 
            // dgSelectedPersonGroup
            // 
            this.dgSelectedPersonGroup.AllowUserToAddRows = false;
            this.dgSelectedPersonGroup.AllowUserToDeleteRows = false;
            this.dgSelectedPersonGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelectedPersonGroup.Location = new System.Drawing.Point(15, 232);
            this.dgSelectedPersonGroup.MultiSelect = false;
            this.dgSelectedPersonGroup.Name = "dgSelectedPersonGroup";
            this.dgSelectedPersonGroup.ReadOnly = true;
            this.dgSelectedPersonGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSelectedPersonGroup.Size = new System.Drawing.Size(230, 194);
            this.dgSelectedPersonGroup.TabIndex = 25;
            this.dgSelectedPersonGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSelectedPersonGroup_CellClick);
            // 
            // dgNonSelectedPersonGroups
            // 
            this.dgNonSelectedPersonGroups.AllowUserToAddRows = false;
            this.dgNonSelectedPersonGroups.AllowUserToDeleteRows = false;
            this.dgNonSelectedPersonGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNonSelectedPersonGroups.Location = new System.Drawing.Point(378, 142);
            this.dgNonSelectedPersonGroups.MultiSelect = false;
            this.dgNonSelectedPersonGroups.Name = "dgNonSelectedPersonGroups";
            this.dgNonSelectedPersonGroups.ReadOnly = true;
            this.dgNonSelectedPersonGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNonSelectedPersonGroups.Size = new System.Drawing.Size(230, 284);
            this.dgNonSelectedPersonGroups.TabIndex = 26;
            this.dgNonSelectedPersonGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNonSelectedPersonGroups_CellClick);
            // 
            // cmdRightToLeft
            // 
            this.cmdRightToLeft.Enabled = false;
            this.cmdRightToLeft.Location = new System.Drawing.Point(251, 277);
            this.cmdRightToLeft.Name = "cmdRightToLeft";
            this.cmdRightToLeft.Size = new System.Drawing.Size(121, 23);
            this.cmdRightToLeft.TabIndex = 27;
            this.cmdRightToLeft.Text = "<--- Toevoegen";
            this.cmdRightToLeft.UseVisualStyleBackColor = true;
            this.cmdRightToLeft.Click += new System.EventHandler(this.cmdRightToLeft_Click);
            // 
            // cmdLeftToRight
            // 
            this.cmdLeftToRight.Enabled = false;
            this.cmdLeftToRight.Location = new System.Drawing.Point(251, 340);
            this.cmdLeftToRight.Name = "cmdLeftToRight";
            this.cmdLeftToRight.Size = new System.Drawing.Size(121, 23);
            this.cmdLeftToRight.TabIndex = 28;
            this.cmdLeftToRight.Text = "Verwijderen --->";
            this.cmdLeftToRight.UseVisualStyleBackColor = true;
            this.cmdLeftToRight.Click += new System.EventHandler(this.cmdLeftToRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Overige groepen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "De persoon is lid van de volgende groepen:";
            // 
            // lblSelectedPersonGroupItemValue
            // 
            this.lblSelectedPersonGroupItemValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedPersonGroupItemValue.Location = new System.Drawing.Point(251, 303);
            this.lblSelectedPersonGroupItemValue.Name = "lblSelectedPersonGroupItemValue";
            this.lblSelectedPersonGroupItemValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSelectedPersonGroupItemValue.Size = new System.Drawing.Size(121, 34);
            this.lblSelectedPersonGroupItemValue.TabIndex = 31;
            this.lblSelectedPersonGroupItemValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taPerson_group
            // 
            this.taPerson_group.ClearBeforeFill = true;
            // 
            // taPerson_has_person_group
            // 
            this.taPerson_has_person_group.ClearBeforeFill = true;
            // 
            // frmDetailsPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 442);
            this.Controls.Add(this.lblSelectedPersonGroupItemValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdLeftToRight);
            this.Controls.Add(this.cmdRightToLeft);
            this.Controls.Add(this.dgNonSelectedPersonGroups);
            this.Controls.Add(this.dgSelectedPersonGroup);
            this.Controls.Add(this.cmdExtendScreen);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.cmdFingerprints);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdChangePerson);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblMiddlename);
            this.Controls.Add(this.lblFrontname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtMiddlename);
            this.Controls.Add(this.txtFristname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDetailsPerson";
            this.ShowIcon = false;
            this.Text = "Gegevens persoon: ";
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectedPersonGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNonSelectedPersonGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdChangePerson;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.Label lblFrontname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.TextBox txtFristname;
        private FlexAccess.FlexAccessDataSetTableAdapters.personTableAdapter taPerson;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdFingerprints;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.Button cmdExtendScreen;
        private System.Windows.Forms.DataGridView dgSelectedPersonGroup;
        private System.Windows.Forms.DataGridView dgNonSelectedPersonGroups;
        private System.Windows.Forms.Button cmdRightToLeft;
        private System.Windows.Forms.Button cmdLeftToRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedPersonGroupItemValue;
        private FlexAccess.FlexAccessDataSetTableAdapters.person_groupTableAdapter taPerson_group;
        private FlexAccess.FlexAccessDataSetTableAdapters.person_has_person_groupTableAdapter taPerson_has_person_group;
    }
}