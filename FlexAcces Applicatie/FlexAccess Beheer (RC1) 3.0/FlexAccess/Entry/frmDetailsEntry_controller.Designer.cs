namespace FlexAccess.Entry
{
    partial class frmDetailsEntry_controller
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
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.taEntry_controller = new FlexAccess.FlexAccessDataSetTableAdapters.entry_controllerTableAdapter();
            this.SuspendLayout();
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(12, 214);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 0;
            this.cmdDelete.Text = "verwijderen";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(103, 214);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(200, 23);
            this.cmdSubmit.TabIndex = 1;
            this.cmdSubmit.Text = "wijzigen";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(90, 45);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(213, 20);
            this.txtIp.TabIndex = 3;
            this.txtIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp_KeyPress);
            this.txtIp.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(90, 79);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(213, 114);
            this.txtRemark.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Naam";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(12, 45);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(57, 13);
            this.lblIp.TabIndex = 6;
            this.lblIp.Text = "IP-address";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(12, 82);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(58, 13);
            this.lblRemark.TabIndex = 7;
            this.lblRemark.Text = "Opmerking";
            // 
            // taEntry_controller
            // 
            this.taEntry_controller.ClearBeforeFill = true;
            // 
            // frmDetailsEntry_controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 257);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.cmdDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDetailsEntry_controller";
            this.Text = "Controller aanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblRemark;
        private FlexAccess.FlexAccessDataSetTableAdapters.entry_controllerTableAdapter taEntry_controller;
    }
}