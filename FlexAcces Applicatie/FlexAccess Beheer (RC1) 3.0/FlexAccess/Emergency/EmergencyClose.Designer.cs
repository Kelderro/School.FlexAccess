namespace FlexAccess.Emergency
{
    partial class EmergencyClose
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmergencyClose));
            this.lblOpenAlldoors = new System.Windows.Forms.Label();
            this.tmrEmergency = new System.Windows.Forms.Timer(this.components);
            this.pbExecuteEmergency = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExecuteEmergency)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpenAlldoors
            // 
            this.lblOpenAlldoors.AutoSize = true;
            this.lblOpenAlldoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenAlldoors.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOpenAlldoors.Location = new System.Drawing.Point(87, 32);
            this.lblOpenAlldoors.Name = "lblOpenAlldoors";
            this.lblOpenAlldoors.Size = new System.Drawing.Size(185, 18);
            this.lblOpenAlldoors.TabIndex = 3;
            this.lblOpenAlldoors.Text = "Sluit alle deuren/ ramen";
            // 
            // tmrEmergency
            // 
            this.tmrEmergency.Interval = 15000;
            this.tmrEmergency.Tick += new System.EventHandler(this.tmrEmergency_Tick);
            // 
            // pbExecuteEmergency
            // 
            this.pbExecuteEmergency.Image = ((System.Drawing.Image)(resources.GetObject("pbExecuteEmergency.Image")));
            this.pbExecuteEmergency.Location = new System.Drawing.Point(56, 62);
            this.pbExecuteEmergency.Name = "pbExecuteEmergency";
            this.pbExecuteEmergency.Size = new System.Drawing.Size(258, 258);
            this.pbExecuteEmergency.TabIndex = 2;
            this.pbExecuteEmergency.TabStop = false;
            this.pbExecuteEmergency.Click += new System.EventHandler(this.pbExecuteEmergency_Click);
            // 
            // EmergencyClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(376, 372);
            this.Controls.Add(this.lblOpenAlldoors);
            this.Controls.Add(this.pbExecuteEmergency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmergencyClose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmergencyClose";
            ((System.ComponentModel.ISupportInitialize)(this.pbExecuteEmergency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpenAlldoors;
        private System.Windows.Forms.Timer tmrEmergency;
        private System.Windows.Forms.PictureBox pbExecuteEmergency;
    }
}