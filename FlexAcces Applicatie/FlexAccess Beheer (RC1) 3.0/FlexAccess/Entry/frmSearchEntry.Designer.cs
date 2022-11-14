namespace FlexAccess.Entry
{
    partial class frmSearchEntry
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
            this.dgEntrys = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmdAll = new System.Windows.Forms.Button();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.taEntry = new FlexAccess.FlexAccessDataSetTableAdapters.entryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrys)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEntrys
            // 
            this.dgEntrys.AllowUserToAddRows = false;
            this.dgEntrys.AllowUserToDeleteRows = false;
            this.dgEntrys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntrys.Location = new System.Drawing.Point(12, 84);
            this.dgEntrys.MultiSelect = false;
            this.dgEntrys.Name = "dgEntrys";
            this.dgEntrys.ReadOnly = true;
            this.dgEntrys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEntrys.Size = new System.Drawing.Size(250, 289);
            this.dgEntrys.TabIndex = 16;
            this.dgEntrys.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntrys_CellClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 20);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Naam";
            // 
            // cmdAll
            // 
            this.cmdAll.Location = new System.Drawing.Point(187, 61);
            this.cmdAll.Name = "cmdAll";
            this.cmdAll.Size = new System.Drawing.Size(75, 23);
            this.cmdAll.TabIndex = 13;
            this.cmdAll.Text = "Alles";
            this.cmdAll.UseVisualStyleBackColor = true;
            this.cmdAll.Click += new System.EventHandler(this.cmdAll_Click);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(187, 32);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 12;
            this.cmdSearch.Text = "Zoek";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // taEntry
            // 
            this.taEntry.ClearBeforeFill = true;
            // 
            // frmSearchEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 390);
            this.Controls.Add(this.dgEntrys);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmdAll);
            this.Controls.Add(this.cmdSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSearchEntry";
            this.Text = "Zoek doorgang";
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEntrys;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button cmdAll;
        private System.Windows.Forms.Button cmdSearch;
        private FlexAccess.FlexAccessDataSetTableAdapters.entryTableAdapter taEntry;
    }
}