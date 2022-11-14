namespace FlexAccess
{
    partial class frmSearchZone
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
            this.dgSearchZone = new System.Windows.Forms.DataGridView();
            this.taZone = new FlexAccess.FlexAccessDataSetTableAdapters.zoneTableAdapter();
            this.txtZonename = new System.Windows.Forms.TextBox();
            this.lblZonename = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchZone)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSearchZone
            // 
            this.dgSearchZone.AllowUserToAddRows = false;
            this.dgSearchZone.AllowUserToDeleteRows = false;
            this.dgSearchZone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearchZone.Location = new System.Drawing.Point(12, 50);
            this.dgSearchZone.MultiSelect = false;
            this.dgSearchZone.Name = "dgSearchZone";
            this.dgSearchZone.ReadOnly = true;
            this.dgSearchZone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSearchZone.Size = new System.Drawing.Size(224, 370);
            this.dgSearchZone.TabIndex = 0;
            this.dgSearchZone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearchZone_CellClick);
            // 
            // taZone
            // 
            this.taZone.ClearBeforeFill = true;
            // 
            // txtZonename
            // 
            this.txtZonename.Location = new System.Drawing.Point(12, 24);
            this.txtZonename.Name = "txtZonename";
            this.txtZonename.Size = new System.Drawing.Size(128, 20);
            this.txtZonename.TabIndex = 1;
            // 
            // lblZonename
            // 
            this.lblZonename.AutoSize = true;
            this.lblZonename.Location = new System.Drawing.Point(12, 8);
            this.lblZonename.Name = "lblZonename";
            this.lblZonename.Size = new System.Drawing.Size(100, 13);
            this.lblZonename.TabIndex = 2;
            this.lblZonename.Text = "Naam van de zone:";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(146, 22);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(90, 23);
            this.cmdSearch.TabIndex = 3;
            this.cmdSearch.Text = "Zoek";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // frmSearchZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 432);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.lblZonename);
            this.Controls.Add(this.txtZonename);
            this.Controls.Add(this.dgSearchZone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchZone";
            this.Text = "Zoek zone";
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSearchZone;
        private FlexAccess.FlexAccessDataSetTableAdapters.zoneTableAdapter taZone;
        private System.Windows.Forms.TextBox txtZonename;
        private System.Windows.Forms.Label lblZonename;
        private System.Windows.Forms.Button cmdSearch;
    }
}