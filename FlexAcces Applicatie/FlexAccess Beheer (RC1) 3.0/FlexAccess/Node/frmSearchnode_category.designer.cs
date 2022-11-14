namespace FlexAccess.Node
{
    partial class frmSearchnode_category
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
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdAll = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgNodeCategorie = new System.Windows.Forms.DataGridView();
            this.taNodeCategory = new FlexAccess.FlexAccessDataSetTableAdapters.node_categoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgNodeCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(187, 9);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 0;
            this.cmdSearch.Text = "Zoek";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cmdAll
            // 
            this.cmdAll.Location = new System.Drawing.Point(187, 38);
            this.cmdAll.Name = "cmdAll";
            this.cmdAll.Size = new System.Drawing.Size(75, 23);
            this.cmdAll.TabIndex = 1;
            this.cmdAll.Text = "Alles";
            this.cmdAll.UseVisualStyleBackColor = true;
            this.cmdAll.Click += new System.EventHandler(this.cmdAll_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Naam";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 20);
            this.txtName.TabIndex = 4;
            // 
            // dgNodeCategorie
            // 
            this.dgNodeCategorie.AllowUserToAddRows = false;
            this.dgNodeCategorie.AllowUserToDeleteRows = false;
            this.dgNodeCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNodeCategorie.Location = new System.Drawing.Point(12, 75);
            this.dgNodeCategorie.Name = "dgNodeCategorie";
            this.dgNodeCategorie.ReadOnly = true;
            this.dgNodeCategorie.Size = new System.Drawing.Size(250, 289);
            this.dgNodeCategorie.TabIndex = 6;
            this.dgNodeCategorie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNodeCategorie_CellClick);
            // 
            // taNodeCategory
            // 
            this.taNodeCategory.ClearBeforeFill = true;
            // 
            // frmSearchnode_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 376);
            this.Controls.Add(this.dgNodeCategorie);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmdAll);
            this.Controls.Add(this.cmdSearch);
            this.MaximizeBox = false;
            this.Name = "frmSearchnode_category";
            this.Text = "Zoek Node Categorie";
            ((System.ComponentModel.ISupportInitialize)(this.dgNodeCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlexAccess.FlexAccessDataSetTableAdapters.node_categoryTableAdapter taNodeCategory;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdAll;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgNodeCategorie;
    }
}