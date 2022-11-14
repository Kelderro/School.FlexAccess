namespace FlexAccess.Person
{
    partial class frmGroupPersons
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
            this.dgPerson_groep = new System.Windows.Forms.DataGridView();
            this.gbPersons = new System.Windows.Forms.GroupBox();
            this.dgPersons = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAddPersonGroup = new System.Windows.Forms.Button();
            this.cmdChangePersonGroup = new System.Windows.Forms.Button();
            this.lbGrouplSelected = new System.Windows.Forms.Label();
            this.lblGroupSelectedValue = new System.Windows.Forms.Label();
            this.txtSearchPersonGroup = new System.Windows.Forms.TextBox();
            this.cmdSearchPersonGroup = new System.Windows.Forms.Button();
            this.cmdShowAllPersonGroups = new System.Windows.Forms.Button();
            this.cmdDeletePersonGroup = new System.Windows.Forms.Button();
            this.txtChangesGroupPerson = new System.Windows.Forms.TextBox();
            this.taPerson_group = new FlexAccess.FlexAccessDataSetTableAdapters.person_groupTableAdapter();
            this.taPerson = new FlexAccess.FlexAccessDataSetTableAdapters.personTableAdapter();
            this.taPerson_has_person_group = new FlexAccess.FlexAccessDataSetTableAdapters.person_has_person_groupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerson_groep)).BeginInit();
            this.gbPersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPerson_groep
            // 
            this.dgPerson_groep.AllowUserToAddRows = false;
            this.dgPerson_groep.AllowUserToDeleteRows = false;
            this.dgPerson_groep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPerson_groep.Location = new System.Drawing.Point(12, 63);
            this.dgPerson_groep.MultiSelect = false;
            this.dgPerson_groep.Name = "dgPerson_groep";
            this.dgPerson_groep.ReadOnly = true;
            this.dgPerson_groep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPerson_groep.Size = new System.Drawing.Size(253, 190);
            this.dgPerson_groep.TabIndex = 0;
            this.dgPerson_groep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPerson_groep_CellClick);
            // 
            // gbPersons
            // 
            this.gbPersons.Controls.Add(this.dgPersons);
            this.gbPersons.Location = new System.Drawing.Point(296, 12);
            this.gbPersons.Name = "gbPersons";
            this.gbPersons.Size = new System.Drawing.Size(446, 311);
            this.gbPersons.TabIndex = 1;
            this.gbPersons.TabStop = false;
            this.gbPersons.Text = "Personen in de groep";
            // 
            // dgPersons
            // 
            this.dgPersons.AllowUserToAddRows = false;
            this.dgPersons.AllowUserToDeleteRows = false;
            this.dgPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersons.Location = new System.Drawing.Point(15, 19);
            this.dgPersons.MultiSelect = false;
            this.dgPersons.Name = "dgPersons";
            this.dgPersons.ReadOnly = true;
            this.dgPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPersons.Size = new System.Drawing.Size(413, 276);
            this.dgPersons.TabIndex = 0;
            this.dgPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersons_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Persoons groepen";
            // 
            // cmdAddPersonGroup
            // 
            this.cmdAddPersonGroup.Location = new System.Drawing.Point(15, 296);
            this.cmdAddPersonGroup.Name = "cmdAddPersonGroup";
            this.cmdAddPersonGroup.Size = new System.Drawing.Size(76, 23);
            this.cmdAddPersonGroup.TabIndex = 3;
            this.cmdAddPersonGroup.Text = "toevoegen";
            this.cmdAddPersonGroup.UseVisualStyleBackColor = true;
            this.cmdAddPersonGroup.Click += new System.EventHandler(this.cmdAddPersonGroup_Click);
            // 
            // cmdChangePersonGroup
            // 
            this.cmdChangePersonGroup.Location = new System.Drawing.Point(104, 296);
            this.cmdChangePersonGroup.Name = "cmdChangePersonGroup";
            this.cmdChangePersonGroup.Size = new System.Drawing.Size(75, 23);
            this.cmdChangePersonGroup.TabIndex = 4;
            this.cmdChangePersonGroup.Text = "wijzigen";
            this.cmdChangePersonGroup.UseVisualStyleBackColor = true;
            this.cmdChangePersonGroup.Click += new System.EventHandler(this.cmdChangePersonGroup_Click);
            // 
            // lbGrouplSelected
            // 
            this.lbGrouplSelected.AutoSize = true;
            this.lbGrouplSelected.Location = new System.Drawing.Point(12, 267);
            this.lbGrouplSelected.Name = "lbGrouplSelected";
            this.lbGrouplSelected.Size = new System.Drawing.Size(125, 13);
            this.lbGrouplSelected.TabIndex = 5;
            this.lbGrouplSelected.Text = "momenteel geselecteerd:";
            // 
            // lblGroupSelectedValue
            // 
            this.lblGroupSelectedValue.AutoSize = true;
            this.lblGroupSelectedValue.Location = new System.Drawing.Point(143, 267);
            this.lblGroupSelectedValue.Name = "lblGroupSelectedValue";
            this.lblGroupSelectedValue.Size = new System.Drawing.Size(0, 13);
            this.lblGroupSelectedValue.TabIndex = 6;
            // 
            // txtSearchPersonGroup
            // 
            this.txtSearchPersonGroup.Location = new System.Drawing.Point(15, 24);
            this.txtSearchPersonGroup.Name = "txtSearchPersonGroup";
            this.txtSearchPersonGroup.Size = new System.Drawing.Size(191, 20);
            this.txtSearchPersonGroup.TabIndex = 7;
            // 
            // cmdSearchPersonGroup
            // 
            this.cmdSearchPersonGroup.Location = new System.Drawing.Point(212, 22);
            this.cmdSearchPersonGroup.Name = "cmdSearchPersonGroup";
            this.cmdSearchPersonGroup.Size = new System.Drawing.Size(53, 23);
            this.cmdSearchPersonGroup.TabIndex = 8;
            this.cmdSearchPersonGroup.Text = "zoek";
            this.cmdSearchPersonGroup.UseVisualStyleBackColor = true;
            this.cmdSearchPersonGroup.Click += new System.EventHandler(this.cmdSearchPersonGroup_Click);
            // 
            // cmdShowAllPersonGroups
            // 
            this.cmdShowAllPersonGroups.Location = new System.Drawing.Point(212, 51);
            this.cmdShowAllPersonGroups.Name = "cmdShowAllPersonGroups";
            this.cmdShowAllPersonGroups.Size = new System.Drawing.Size(53, 23);
            this.cmdShowAllPersonGroups.TabIndex = 9;
            this.cmdShowAllPersonGroups.Text = "alles";
            this.cmdShowAllPersonGroups.UseVisualStyleBackColor = true;
            this.cmdShowAllPersonGroups.Click += new System.EventHandler(this.cmdShowAllPersonGroups_Click);
            // 
            // cmdDeletePersonGroup
            // 
            this.cmdDeletePersonGroup.Location = new System.Drawing.Point(190, 296);
            this.cmdDeletePersonGroup.Name = "cmdDeletePersonGroup";
            this.cmdDeletePersonGroup.Size = new System.Drawing.Size(75, 23);
            this.cmdDeletePersonGroup.TabIndex = 10;
            this.cmdDeletePersonGroup.Text = "verwijderen";
            this.cmdDeletePersonGroup.UseVisualStyleBackColor = true;
            this.cmdDeletePersonGroup.Click += new System.EventHandler(this.cmdDeletePersonGroup_Click);
            // 
            // txtChangesGroupPerson
            // 
            this.txtChangesGroupPerson.Location = new System.Drawing.Point(12, 264);
            this.txtChangesGroupPerson.Name = "txtChangesGroupPerson";
            this.txtChangesGroupPerson.Size = new System.Drawing.Size(253, 20);
            this.txtChangesGroupPerson.TabIndex = 11;
            this.txtChangesGroupPerson.Visible = false;
            this.txtChangesGroupPerson.TextChanged += new System.EventHandler(this.txtChangesGroupPerson_TextChanged);
            // 
            // taPerson_group
            // 
            this.taPerson_group.ClearBeforeFill = true;
            // 
            // taPerson
            // 
            this.taPerson.ClearBeforeFill = true;
            // 
            // taPerson_has_person_group
            // 
            this.taPerson_has_person_group.ClearBeforeFill = true;
            // 
            // frmGroupPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 335);
            this.Controls.Add(this.txtChangesGroupPerson);
            this.Controls.Add(this.cmdDeletePersonGroup);
            this.Controls.Add(this.cmdShowAllPersonGroups);
            this.Controls.Add(this.cmdSearchPersonGroup);
            this.Controls.Add(this.txtSearchPersonGroup);
            this.Controls.Add(this.lblGroupSelectedValue);
            this.Controls.Add(this.lbGrouplSelected);
            this.Controls.Add(this.cmdChangePersonGroup);
            this.Controls.Add(this.cmdAddPersonGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPersons);
            this.Controls.Add(this.dgPerson_groep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGroupPersons";
            this.Text = "Persoon groepen";
            ((System.ComponentModel.ISupportInitialize)(this.dgPerson_groep)).EndInit();
            this.gbPersons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlexAccess.FlexAccessDataSetTableAdapters.person_groupTableAdapter taPerson_group;
        private System.Windows.Forms.DataGridView dgPerson_groep;
        private System.Windows.Forms.GroupBox gbPersons;
        private System.Windows.Forms.DataGridView dgPersons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAddPersonGroup;
        private System.Windows.Forms.Button cmdChangePersonGroup;
        private System.Windows.Forms.Label lbGrouplSelected;
        private System.Windows.Forms.Label lblGroupSelectedValue;
        private System.Windows.Forms.TextBox txtSearchPersonGroup;
        private System.Windows.Forms.Button cmdSearchPersonGroup;
        private System.Windows.Forms.Button cmdShowAllPersonGroups;
        private System.Windows.Forms.Button cmdDeletePersonGroup;
        private System.Windows.Forms.TextBox txtChangesGroupPerson;
        private FlexAccess.FlexAccessDataSetTableAdapters.personTableAdapter taPerson;
        private FlexAccess.FlexAccessDataSetTableAdapters.person_has_person_groupTableAdapter taPerson_has_person_group;
    }
}