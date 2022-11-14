namespace FlexAccess
{
    partial class frmDetailZone
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
            this.pbPlan = new System.Windows.Forms.PictureBox();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.taZone = new FlexAccess.FlexAccessDataSetTableAdapters.zoneTableAdapter();
            this.cmdBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlan
            // 
            this.pbPlan.Location = new System.Drawing.Point(274, 12);
            this.pbPlan.Name = "pbPlan";
            this.pbPlan.Size = new System.Drawing.Size(631, 496);
            this.pbPlan.TabIndex = 0;
            this.pbPlan.TabStop = false;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(68, 282);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(200, 23);
            this.cmdUpdate.TabIndex = 1;
            this.cmdUpdate.Text = "Zone wijzigen";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Naam";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(4, 41);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(58, 13);
            this.lblRemark.TabIndex = 3;
            this.lblRemark.Text = "Opmerking";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(68, 38);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(200, 228);
            this.txtRemark.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 5;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(68, 391);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(200, 23);
            this.cmdDelete.TabIndex = 6;
            this.cmdDelete.Text = "Zone verwijderen";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // taZone
            // 
            this.taZone.ClearBeforeFill = true;
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(68, 485);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(200, 23);
            this.cmdBack.TabIndex = 7;
            this.cmdBack.Text = "Terug";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // frmDetailZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 520);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.pbPlan);
            this.Name = "frmDetailZone";
            this.Text = "Zone: ";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlexAccess.FlexAccessDataSetTableAdapters.zoneTableAdapter taZone;
        private System.Windows.Forms.PictureBox pbPlan;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdBack;
    }
}