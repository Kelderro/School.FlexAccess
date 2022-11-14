namespace FlexAccess.Admin
{
    partial class frmChangePassword
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
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblPersonValue = new System.Windows.Forms.Label();
            this.lblOldpassword = new System.Windows.Forms.Label();
            this.lblNewpassword = new System.Windows.Forms.Label();
            this.lblnewpassword2 = new System.Windows.Forms.Label();
            this.cmdChangePassword = new System.Windows.Forms.Button();
            this.txtOldpassword = new System.Windows.Forms.TextBox();
            this.txtNewpassword1 = new System.Windows.Forms.TextBox();
            this.txtNewpassword2 = new System.Windows.Forms.TextBox();
            this.taSystemuser = new FlexAccess.FlexAccessDataSetTableAdapters.systemuserTableAdapter();
            this.SuspendLayout();
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(12, 9);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(56, 13);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "Gebruiker:";
            // 
            // lblPersonValue
            // 
            this.lblPersonValue.AutoSize = true;
            this.lblPersonValue.Location = new System.Drawing.Point(125, 9);
            this.lblPersonValue.Name = "lblPersonValue";
            this.lblPersonValue.Size = new System.Drawing.Size(0, 13);
            this.lblPersonValue.TabIndex = 1;
            // 
            // lblOldpassword
            // 
            this.lblOldpassword.AutoSize = true;
            this.lblOldpassword.Location = new System.Drawing.Point(12, 38);
            this.lblOldpassword.Name = "lblOldpassword";
            this.lblOldpassword.Size = new System.Drawing.Size(97, 13);
            this.lblOldpassword.TabIndex = 2;
            this.lblOldpassword.Text = "Oude wachtwoord:";
            // 
            // lblNewpassword
            // 
            this.lblNewpassword.AutoSize = true;
            this.lblNewpassword.Location = new System.Drawing.Point(12, 67);
            this.lblNewpassword.Name = "lblNewpassword";
            this.lblNewpassword.Size = new System.Drawing.Size(101, 13);
            this.lblNewpassword.TabIndex = 3;
            this.lblNewpassword.Text = "Nieuw wachtwoord:";
            // 
            // lblnewpassword2
            // 
            this.lblnewpassword2.AutoSize = true;
            this.lblnewpassword2.Location = new System.Drawing.Point(12, 97);
            this.lblnewpassword2.Name = "lblnewpassword2";
            this.lblnewpassword2.Size = new System.Drawing.Size(108, 13);
            this.lblnewpassword2.TabIndex = 4;
            this.lblnewpassword2.Text = "Herhaal wachtwoord:";
            // 
            // cmdChangePassword
            // 
            this.cmdChangePassword.Enabled = false;
            this.cmdChangePassword.Location = new System.Drawing.Point(31, 141);
            this.cmdChangePassword.Name = "cmdChangePassword";
            this.cmdChangePassword.Size = new System.Drawing.Size(250, 23);
            this.cmdChangePassword.TabIndex = 5;
            this.cmdChangePassword.Text = "wijzig wachtwoord";
            this.cmdChangePassword.UseVisualStyleBackColor = true;
            this.cmdChangePassword.Click += new System.EventHandler(this.cmdChangePassword_Click);
            // 
            // txtOldpassword
            // 
            this.txtOldpassword.Location = new System.Drawing.Point(128, 35);
            this.txtOldpassword.Name = "txtOldpassword";
            this.txtOldpassword.Size = new System.Drawing.Size(178, 20);
            this.txtOldpassword.TabIndex = 6;
            this.txtOldpassword.UseSystemPasswordChar = true;
            this.txtOldpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOldpassword_KeyPress);
            this.txtOldpassword.TextChanged += new System.EventHandler(this.txtOldpassword_TextChanged);
            // 
            // txtNewpassword1
            // 
            this.txtNewpassword1.Location = new System.Drawing.Point(128, 64);
            this.txtNewpassword1.Name = "txtNewpassword1";
            this.txtNewpassword1.Size = new System.Drawing.Size(178, 20);
            this.txtNewpassword1.TabIndex = 7;
            this.txtNewpassword1.UseSystemPasswordChar = true;
            this.txtNewpassword1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewpassword1_KeyPress);
            this.txtNewpassword1.TextChanged += new System.EventHandler(this.txtNewpassword1_TextChanged);
            // 
            // txtNewpassword2
            // 
            this.txtNewpassword2.Location = new System.Drawing.Point(128, 90);
            this.txtNewpassword2.Name = "txtNewpassword2";
            this.txtNewpassword2.Size = new System.Drawing.Size(178, 20);
            this.txtNewpassword2.TabIndex = 8;
            this.txtNewpassword2.UseSystemPasswordChar = true;
            this.txtNewpassword2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewpassword2_KeyPress);
            this.txtNewpassword2.TextChanged += new System.EventHandler(this.txtNewpassword2_TextChanged);
            // 
            // taSystemuser
            // 
            this.taSystemuser.ClearBeforeFill = true;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 176);
            this.Controls.Add(this.txtNewpassword2);
            this.Controls.Add(this.txtNewpassword1);
            this.Controls.Add(this.txtOldpassword);
            this.Controls.Add(this.cmdChangePassword);
            this.Controls.Add(this.lblnewpassword2);
            this.Controls.Add(this.lblNewpassword);
            this.Controls.Add(this.lblOldpassword);
            this.Controls.Add(this.lblPersonValue);
            this.Controls.Add(this.lblPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.ShowIcon = false;
            this.Text = "Verander password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblPersonValue;
        private System.Windows.Forms.Label lblOldpassword;
        private System.Windows.Forms.Label lblNewpassword;
        private System.Windows.Forms.Label lblnewpassword2;
        private System.Windows.Forms.Button cmdChangePassword;
        private System.Windows.Forms.TextBox txtOldpassword;
        private System.Windows.Forms.TextBox txtNewpassword1;
        private System.Windows.Forms.TextBox txtNewpassword2;
        private FlexAccess.FlexAccessDataSetTableAdapters.systemuserTableAdapter taSystemuser;
    }
}