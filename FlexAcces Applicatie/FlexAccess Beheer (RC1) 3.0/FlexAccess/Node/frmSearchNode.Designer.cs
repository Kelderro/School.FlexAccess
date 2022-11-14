namespace FlexAccess.Node
{
    partial class frmSearchNode
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
            this.cmdAll = new System.Windows.Forms.Button();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearchNode = new System.Windows.Forms.TextBox();
            this.dgNode = new System.Windows.Forms.DataGridView();
            this.taNode = new FlexAccess.FlexAccessDataSetTableAdapters.nodeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgNode)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAll
            // 
            this.cmdAll.Location = new System.Drawing.Point(191, 36);
            this.cmdAll.Name = "cmdAll";
            this.cmdAll.Size = new System.Drawing.Size(75, 23);
            this.cmdAll.TabIndex = 0;
            this.cmdAll.Text = "Alles";
            this.cmdAll.UseVisualStyleBackColor = true;
            this.cmdAll.Click += new System.EventHandler(this.cmdAll_Click);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(191, 7);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 1;
            this.cmdSearch.Text = "Zoek";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Naam";
            // 
            // txtSearchNode
            // 
            this.txtSearchNode.Location = new System.Drawing.Point(12, 36);
            this.txtSearchNode.Name = "txtSearchNode";
            this.txtSearchNode.Size = new System.Drawing.Size(173, 20);
            this.txtSearchNode.TabIndex = 3;
            // 
            // dgNode
            // 
            this.dgNode.AllowUserToAddRows = false;
            this.dgNode.AllowUserToDeleteRows = false;
            this.dgNode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNode.Location = new System.Drawing.Point(12, 75);
            this.dgNode.Name = "dgNode";
            this.dgNode.ReadOnly = true;
            this.dgNode.Size = new System.Drawing.Size(250, 289);
            this.dgNode.TabIndex = 4;
            this.dgNode.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNode_CellClick);
            // 
            // taNode
            // 
            this.taNode.ClearBeforeFill = true;
            // 
            // frmSearchNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 376);
            this.Controls.Add(this.dgNode);
            this.Controls.Add(this.txtSearchNode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.cmdAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSearchNode";
            this.ShowIcon = false;
            this.Text = "Zoek Node";
            ((System.ComponentModel.ISupportInitialize)(this.dgNode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAll;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSearchNode;
        private System.Windows.Forms.DataGridView dgNode;
        private FlexAccess.FlexAccessDataSetTableAdapters.nodeTableAdapter taNode;
    }
}