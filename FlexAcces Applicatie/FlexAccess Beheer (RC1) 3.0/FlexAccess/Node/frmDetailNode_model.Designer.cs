namespace FlexAccess.Node
{
    partial class frmDetailNode_model
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
            this.taNode_category = new FlexAccess.FlexAccessDataSetTableAdapters.node_categoryTableAdapter();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.lblversion = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.txtversion = new System.Windows.Forms.TextBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.lblnodecategorie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taNode_model
            // 
            this.taNode_model.ClearBeforeFill = true;
            // 
            // taNode_category
            // 
            this.taNode_category.ClearBeforeFill = true;
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(104, 186);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(174, 23);
            this.cmdSubmit.TabIndex = 0;
            this.cmdSubmit.Text = "Wijzigen";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(12, 186);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(79, 23);
            this.cmdDelete.TabIndex = 1;
            this.cmdDelete.Text = "Verwijderen";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Location = new System.Drawing.Point(20, 129);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(36, 13);
            this.lblversion.TabIndex = 2;
            this.lblversion.Text = "Versie";
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.Location = new System.Drawing.Point(20, 80);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(31, 13);
            this.lblbrand.TabIndex = 3;
            this.lblbrand.Text = "Merk";
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(81, 73);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(197, 20);
            this.txtbrand.TabIndex = 4;
            // 
            // txtversion
            // 
            this.txtversion.Location = new System.Drawing.Point(81, 122);
            this.txtversion.Name = "txtversion";
            this.txtversion.Size = new System.Drawing.Size(197, 20);
            this.txtversion.TabIndex = 5;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(81, 22);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(197, 21);
            this.cmbCategorie.TabIndex = 7;
            // 
            // lblnodecategorie
            // 
            this.lblnodecategorie.AutoSize = true;
            this.lblnodecategorie.Location = new System.Drawing.Point(20, 25);
            this.lblnodecategorie.Name = "lblnodecategorie";
            this.lblnodecategorie.Size = new System.Drawing.Size(52, 13);
            this.lblnodecategorie.TabIndex = 8;
            this.lblnodecategorie.Text = "Categorie";
            // 
            // frmDetailNode_model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 221);
            this.Controls.Add(this.lblnodecategorie);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.txtversion);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdSubmit);
            this.MaximizeBox = false;
            this.Name = "frmDetailNode_model";
            this.ShowIcon = false;
            this.Text = "Wijzig  Node Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlexAccess.FlexAccessDataSetTableAdapters.node_modelTableAdapter taNode_model;
        private FlexAccess.FlexAccessDataSetTableAdapters.node_categoryTableAdapter taNode_category;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.TextBox txtversion;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Label lblnodecategorie;
    }
}