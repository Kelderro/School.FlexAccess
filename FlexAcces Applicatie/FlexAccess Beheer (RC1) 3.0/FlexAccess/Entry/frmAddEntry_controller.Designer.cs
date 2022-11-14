namespace FlexAccess.Entry
{
    partial class frmAddEntry_controller
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
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.taEntry_controller = new FlexAccess.FlexAccessDataSetTableAdapters.entry_controllerTableAdapter();
            this.SuspendLayout();
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(11, 82);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(58, 13);
            this.lblRemark.TabIndex = 15;
            this.lblRemark.Text = "Opmerking";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(11, 45);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(57, 13);
            this.lblIp.TabIndex = 14;
            this.lblIp.Text = "IP-address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Naam";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(89, 79);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(213, 114);
            this.txtRemark.TabIndex = 12;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(89, 45);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(213, 20);
            this.txtIp.TabIndex = 11;
            this.txtIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp_KeyPress);
            this.txtIp.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 10;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Enabled = false;
            this.cmdSubmit.Location = new System.Drawing.Point(14, 214);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(288, 23);
            this.cmdSubmit.TabIndex = 9;
            this.cmdSubmit.Text = "toevoegen";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // taEntry_controller
            // 
            this.taEntry_controller.ClearBeforeFill = true;
            // 
            // frmAddEntry_controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 253);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmdSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddEntry_controller";
            this.ShowIcon = false;
            this.Text = "Toevoegen controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdSubmit;
        private FlexAccess.FlexAccessDataSetTableAdapters.entry_controllerTableAdapter taEntry_controller;
    }
}