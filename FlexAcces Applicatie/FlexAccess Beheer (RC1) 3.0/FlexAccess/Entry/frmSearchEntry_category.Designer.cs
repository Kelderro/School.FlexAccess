namespace FlexAccess.Entry
{
    partial class frmSearchEntry_category
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
            this.dgEntryCategorie = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmdAll = new System.Windows.Forms.Button();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.taEntryCategory = new FlexAccess.FlexAccessDataSetTableAdapters.entry_categoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntryCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEntryCategorie
            // 
            this.dgEntryCategorie.AllowUserToAddRows = false;
            this.dgEntryCategorie.AllowUserToDeleteRows = false;
            this.dgEntryCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntryCategorie.Location = new System.Drawing.Point(12, 82);
            this.dgEntryCategorie.Name = "dgEntryCategorie";
            this.dgEntryCategorie.ReadOnly = true;
            this.dgEntryCategorie.Size = new System.Drawing.Size(250, 289);
            this.dgEntryCategorie.TabIndex = 11;
            this.dgEntryCategorie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntryCategorie_CellClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 20);
            this.txtName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Naam";
            // 
            // cmdAll
            // 
            this.cmdAll.Location = new System.Drawing.Point(187, 59);
            this.cmdAll.Name = "cmdAll";
            this.cmdAll.Size = new System.Drawing.Size(75, 23);
            this.cmdAll.TabIndex = 8;
            this.cmdAll.Text = "Alles";
            this.cmdAll.UseVisualStyleBackColor = true;
            this.cmdAll.Click += new System.EventHandler(this.cmdAll_Click);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(187, 30);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 7;
            this.cmdSearch.Text = "Zoek";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // taEntryCategory
            // 
            this.taEntryCategory.ClearBeforeFill = true;
            // 
            // frmSearchEntry_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 385);
            this.Controls.Add(this.dgEntryCategorie);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmdAll);
            this.Controls.Add(this.cmdSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSearchEntry_category";
            this.ShowIcon = false;
            this.Text = "Zoek Categorie";
            ((System.ComponentModel.ISupportInitialize)(this.dgEntryCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEntryCategorie;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button cmdAll;
        private System.Windows.Forms.Button cmdSearch;
        private FlexAccess.FlexAccessDataSetTableAdapters.entry_categoryTableAdapter taEntryCategory;
    }
}