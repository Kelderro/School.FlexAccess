namespace FlexAccess.Node
{
    partial class frmAddnode_model
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
            this.lblversion = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.txtversion = new System.Windows.Forms.TextBox();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.lblcategorie = new System.Windows.Forms.Label();
            this.taNode_model = new FlexAccess.FlexAccessDataSetTableAdapters.node_modelTableAdapter();
            this.taNode_category = new FlexAccess.FlexAccessDataSetTableAdapters.node_categoryTableAdapter();
            this.SuspendLayout();
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Location = new System.Drawing.Point(10, 110);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(36, 13);
            this.lblversion.TabIndex = 0;
            this.lblversion.Text = "Versie";
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.Location = new System.Drawing.Point(10, 67);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(31, 13);
            this.lblbrand.TabIndex = 1;
            this.lblbrand.Text = "Merk";
            // 
            // txtversion
            // 
            this.txtversion.Location = new System.Drawing.Point(108, 107);
            this.txtversion.Name = "txtversion";
            this.txtversion.Size = new System.Drawing.Size(216, 20);
            this.txtversion.TabIndex = 2;
            this.txtversion.TextChanged += new System.EventHandler(this.txtversion_TextChanged);
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(108, 64);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(216, 20);
            this.txtbrand.TabIndex = 3;
            this.txtbrand.TextChanged += new System.EventHandler(this.txtbrand_TextChanged);
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Enabled = false;
            this.cmdSubmit.Location = new System.Drawing.Point(108, 150);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(216, 23);
            this.cmdSubmit.TabIndex = 4;
            this.cmdSubmit.Text = "Toevoegen";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(110, 23);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(232, 21);
            this.cmbCategorie.TabIndex = 5;
            // 
            // lblcategorie
            // 
            this.lblcategorie.AutoSize = true;
            this.lblcategorie.Location = new System.Drawing.Point(10, 26);
            this.lblcategorie.Name = "lblcategorie";
            this.lblcategorie.Size = new System.Drawing.Size(52, 13);
            this.lblcategorie.TabIndex = 6;
            this.lblcategorie.Text = "Categorie";
            // 
            // taNode_model
            // 
            this.taNode_model.ClearBeforeFill = true;
            // 
            // taNode_category
            // 
            this.taNode_category.ClearBeforeFill = true;
            // 
            // frmAddnode_model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 194);
            this.Controls.Add(this.lblcategorie);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.txtversion);
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.lblversion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddnode_model";
            this.ShowIcon = false;
            this.Text = "Toevoegen Node Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlexAccess.FlexAccessDataSetTableAdapters.node_modelTableAdapter taNode_model;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.TextBox txtversion;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.Button cmdSubmit;
        private FlexAccess.FlexAccessDataSetTableAdapters.node_categoryTableAdapter taNode_category;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Label lblcategorie;
    }
}