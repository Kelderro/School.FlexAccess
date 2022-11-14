namespace FlexAccess
{
    partial class frmSearchPerson
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
            this.dgPerson = new System.Windows.Forms.DataGridView();
            this.taPerson = new FlexAccess.FlexAccessDataSetTableAdapters.personTableAdapter();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblFristname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.cmdAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPerson
            // 
            this.dgPerson.AllowUserToAddRows = false;
            this.dgPerson.AllowUserToDeleteRows = false;
            this.dgPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPerson.Location = new System.Drawing.Point(12, 53);
            this.dgPerson.Name = "dgPerson";
            this.dgPerson.ReadOnly = true;
            this.dgPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPerson.Size = new System.Drawing.Size(518, 396);
            this.dgPerson.TabIndex = 2;
            this.dgPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPerson_CellClick);
            // 
            // taPerson
            // 
            this.taPerson.ClearBeforeFill = true;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(208, 26);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(143, 20);
            this.txtLastname.TabIndex = 3;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(357, 26);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(65, 23);
            this.cmdSearch.TabIndex = 4;
            this.cmdSearch.Text = "Zoek";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Location = new System.Drawing.Point(139, 26);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(63, 20);
            this.txtMiddlename.TabIndex = 5;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(13, 26);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(120, 20);
            this.txtFirstname.TabIndex = 6;
            // 
            // lblFristname
            // 
            this.lblFristname.AutoSize = true;
            this.lblFristname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFristname.Location = new System.Drawing.Point(10, 10);
            this.lblFristname.Name = "lblFristname";
            this.lblFristname.Size = new System.Drawing.Size(55, 13);
            this.lblFristname.TabIndex = 7;
            this.lblFristname.Text = "Voornaam";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(208, 9);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(64, 13);
            this.lblLastname.TabIndex = 8;
            this.lblLastname.Text = "Achternaam";
            // 
            // cmdAll
            // 
            this.cmdAll.Location = new System.Drawing.Point(428, 26);
            this.cmdAll.Name = "cmdAll";
            this.cmdAll.Size = new System.Drawing.Size(102, 23);
            this.cmdAll.TabIndex = 9;
            this.cmdAll.Text = "Iedereen";
            this.cmdAll.UseVisualStyleBackColor = true;
            this.cmdAll.Click += new System.EventHandler(this.cmdAll_Click);
            // 
            // frmSearchPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 460);
            this.Controls.Add(this.cmdAll);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFristname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtMiddlename);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.dgPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmSearchPerson";
            this.ShowIcon = false;
            this.Text = "Zoek persoon";
            ((System.ComponentModel.ISupportInitialize)(this.dgPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPerson;
        private FlexAccess.FlexAccessDataSetTableAdapters.personTableAdapter taPerson;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblFristname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Button cmdAll;
    }
}