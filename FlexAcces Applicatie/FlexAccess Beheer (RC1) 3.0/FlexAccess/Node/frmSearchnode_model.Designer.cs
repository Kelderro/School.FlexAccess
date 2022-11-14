namespace FlexAccess.Node
{
    partial class frmSearchnode_model
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
            this.taNode_model = new FlexAccess.FlexAccessDataSetTableAdapters.node_modelTableAdapter();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdAll = new System.Windows.Forms.Button();
            this.lblbrand = new System.Windows.Forms.Label();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.dgNodeModel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgNodeModel)).BeginInit();
            this.SuspendLayout();
            // 
            // taNode_model
            // 
            this.taNode_model.ClearBeforeFill = true;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(106, 38);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 0;
            this.cmdSearch.Text = "Zoeken";
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
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.Location = new System.Drawing.Point(12, 15);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(31, 13);
            this.lblbrand.TabIndex = 2;
            this.lblbrand.Text = "Merk";
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(63, 12);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(199, 20);
            this.txtbrand.TabIndex = 3;
            // 
            // dgNodeModel
            // 
            this.dgNodeModel.AllowUserToAddRows = false;
            this.dgNodeModel.AllowUserToDeleteRows = false;
            this.dgNodeModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNodeModel.Location = new System.Drawing.Point(12, 67);
            this.dgNodeModel.Name = "dgNodeModel";
            this.dgNodeModel.ReadOnly = true;
            this.dgNodeModel.Size = new System.Drawing.Size(250, 315);
            this.dgNodeModel.TabIndex = 4;
            this.dgNodeModel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNodeModel_CellClick);
            // 
            // frmSearchnode_model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 394);
            this.Controls.Add(this.dgNodeModel);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.cmdAll);
            this.Controls.Add(this.cmdSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSearchnode_model";
            this.ShowIcon = false;
            this.Text = "Zoek node Model";
            ((System.ComponentModel.ISupportInitialize)(this.dgNodeModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlexAccess.FlexAccessDataSetTableAdapters.node_modelTableAdapter taNode_model;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdAll;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.DataGridView dgNodeModel;
    }
}