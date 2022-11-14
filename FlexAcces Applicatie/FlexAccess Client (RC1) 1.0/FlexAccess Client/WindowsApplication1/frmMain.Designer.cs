namespace FlexAccess
{
    partial class frmMain
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
          this.axGrFingerXCtrl1 = new AxGrFingerXLib.AxGrFingerXCtrl();
          this.gbClientInformation = new System.Windows.Forms.GroupBox();
          this.cmdShowAllExternalDivices = new System.Windows.Forms.Button();
          this.lblFlexAccessServerValue = new System.Windows.Forms.Label();
          this.lblisConnectedValue = new System.Windows.Forms.Label();
          this.lblisConnected = new System.Windows.Forms.Label();
          this.lblFlexAccessServer = new System.Windows.Forms.Label();
          this.pbFingerPrint = new System.Windows.Forms.PictureBox();
          this.tmrCheckConnection = new System.Windows.Forms.Timer(this.components);
          ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).BeginInit();
          this.gbClientInformation.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.pbFingerPrint)).BeginInit();
          this.SuspendLayout();
          // 
          // axGrFingerXCtrl1
          // 
          this.axGrFingerXCtrl1.Enabled = true;
          this.axGrFingerXCtrl1.Location = new System.Drawing.Point(87, 195);
          this.axGrFingerXCtrl1.Name = "axGrFingerXCtrl1";
          this.axGrFingerXCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrFingerXCtrl1.OcxState")));
          this.axGrFingerXCtrl1.Size = new System.Drawing.Size(32, 32);
          this.axGrFingerXCtrl1.TabIndex = 2;
          this.axGrFingerXCtrl1.SensorPlug += new AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEventHandler(this.axGrFingerXCtrl1_SensorPlug);
          this.axGrFingerXCtrl1.ImageAcquired += new AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEventHandler(this.axGrFingerXCtrl1_ImageAcquired);
          // 
          // gbClientInformation
          // 
          this.gbClientInformation.Controls.Add(this.cmdShowAllExternalDivices);
          this.gbClientInformation.Controls.Add(this.lblFlexAccessServerValue);
          this.gbClientInformation.Controls.Add(this.lblisConnectedValue);
          this.gbClientInformation.Controls.Add(this.lblisConnected);
          this.gbClientInformation.Controls.Add(this.lblFlexAccessServer);
          this.gbClientInformation.Location = new System.Drawing.Point(210, 7);
          this.gbClientInformation.Name = "gbClientInformation";
          this.gbClientInformation.Size = new System.Drawing.Size(233, 224);
          this.gbClientInformation.TabIndex = 4;
          this.gbClientInformation.TabStop = false;
          this.gbClientInformation.Text = "Gegevens Client";
          // 
          // cmdShowAllExternalDivices
          // 
          this.cmdShowAllExternalDivices.Location = new System.Drawing.Point(77, 195);
          this.cmdShowAllExternalDivices.Name = "cmdShowAllExternalDivices";
          this.cmdShowAllExternalDivices.Size = new System.Drawing.Size(150, 23);
          this.cmdShowAllExternalDivices.TabIndex = 6;
          this.cmdShowAllExternalDivices.Text = "Toon externe apparaten";
          this.cmdShowAllExternalDivices.UseVisualStyleBackColor = true;
          this.cmdShowAllExternalDivices.Visible = false;
          this.cmdShowAllExternalDivices.Click += new System.EventHandler(this.cmdShowAllExternalDivices_Click);
          // 
          // lblFlexAccessServerValue
          // 
          this.lblFlexAccessServerValue.Location = new System.Drawing.Point(74, 26);
          this.lblFlexAccessServerValue.Name = "lblFlexAccessServerValue";
          this.lblFlexAccessServerValue.Size = new System.Drawing.Size(153, 13);
          this.lblFlexAccessServerValue.TabIndex = 3;
          // 
          // lblisConnectedValue
          // 
          this.lblisConnectedValue.Location = new System.Drawing.Point(74, 45);
          this.lblisConnectedValue.Name = "lblisConnectedValue";
          this.lblisConnectedValue.Size = new System.Drawing.Size(132, 14);
          this.lblisConnectedValue.TabIndex = 2;
          this.lblisConnectedValue.Text = "Nog niet bekend";
          // 
          // lblisConnected
          // 
          this.lblisConnected.AutoSize = true;
          this.lblisConnected.Location = new System.Drawing.Point(13, 45);
          this.lblisConnected.Name = "lblisConnected";
          this.lblisConnected.Size = new System.Drawing.Size(62, 13);
          this.lblisConnected.TabIndex = 1;
          this.lblisConnected.Text = "Verbonden:";
          // 
          // lblFlexAccessServer
          // 
          this.lblFlexAccessServer.AutoSize = true;
          this.lblFlexAccessServer.Location = new System.Drawing.Point(34, 26);
          this.lblFlexAccessServer.Name = "lblFlexAccessServer";
          this.lblFlexAccessServer.Size = new System.Drawing.Size(41, 13);
          this.lblFlexAccessServer.TabIndex = 0;
          this.lblFlexAccessServer.Text = "Server:";
          // 
          // pbFingerPrint
          // 
          this.pbFingerPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.pbFingerPrint.Location = new System.Drawing.Point(12, 12);
          this.pbFingerPrint.Name = "pbFingerPrint";
          this.pbFingerPrint.Size = new System.Drawing.Size(187, 219);
          this.pbFingerPrint.TabIndex = 3;
          this.pbFingerPrint.TabStop = false;
          // 
          // tmrCheckConnection
          // 
          this.tmrCheckConnection.Enabled = true;
          this.tmrCheckConnection.Interval = 500;
          this.tmrCheckConnection.Tick += new System.EventHandler(this.tmrCheckConnection_Tick);
          // 
          // frmMain
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(456, 244);
          this.Controls.Add(this.gbClientInformation);
          this.Controls.Add(this.pbFingerPrint);
          this.Controls.Add(this.axGrFingerXCtrl1);
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.MaximizeBox = false;
          this.Name = "frmMain";
          this.Text = "FlexAccess Client";
          this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
          this.Load += new System.EventHandler(this.Form1_Load);
          ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).EndInit();
          this.gbClientInformation.ResumeLayout(false);
          this.gbClientInformation.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.pbFingerPrint)).EndInit();
          this.ResumeLayout(false);

        }

        #endregion

        private AxGrFingerXLib.AxGrFingerXCtrl axGrFingerXCtrl1;
        private System.Windows.Forms.PictureBox pbFingerPrint;
        private System.Windows.Forms.GroupBox gbClientInformation;
        private System.Windows.Forms.Label lblisConnectedValue;
        private System.Windows.Forms.Label lblisConnected;
        private System.Windows.Forms.Label lblFlexAccessServer;
      private System.Windows.Forms.Label lblFlexAccessServerValue;
        private System.Windows.Forms.Button cmdShowAllExternalDivices;
      private System.Windows.Forms.Timer tmrCheckConnection;
    }
}

