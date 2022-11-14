namespace FlexAccess.FingerReader
{
  partial class frmAddFinger
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
      System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Pink");
      System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ringvinger");
      System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Middelvinger");
      System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Wijsvinger");
      System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Duim");
      System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Linkerhand", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
      System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Pink");
      System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Ringvinger");
      System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Middelvinger");
      System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Wijsvinger");
      System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Duim");
      System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Rechterhand", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFinger));
      this.trvFingers = new System.Windows.Forms.TreeView();
      this.lblPersonValue = new System.Windows.Forms.Label();
      this.lblPerson = new System.Windows.Forms.Label();
      this.axGrFingerXCtrl1 = new AxGrFingerXLib.AxGrFingerXCtrl();
      this.pbDelete = new System.Windows.Forms.PictureBox();
      this.pbFingerPrint = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbFingerPrint)).BeginInit();
      this.SuspendLayout();
      // 
      // trvFingers
      // 
      this.trvFingers.Location = new System.Drawing.Point(11, 20);
      this.trvFingers.Name = "trvFingers";
      treeNode1.Name = "ndeFinger1";
      treeNode1.Tag = "1";
      treeNode1.Text = "Pink";
      treeNode2.Name = "ndeFinger2";
      treeNode2.Tag = "2";
      treeNode2.Text = "Ringvinger";
      treeNode3.Name = "ndeFinger3";
      treeNode3.Tag = "3";
      treeNode3.Text = "Middelvinger";
      treeNode4.Name = "ndeFinger4";
      treeNode4.Tag = "4";
      treeNode4.Text = "Wijsvinger";
      treeNode5.Name = "ndeFinger5";
      treeNode5.Tag = "5";
      treeNode5.Text = "Duim";
      treeNode6.Name = "ndeHandLeft";
      treeNode6.Text = "Linkerhand";
      treeNode7.Name = "ndeFinger6";
      treeNode7.Tag = "6";
      treeNode7.Text = "Pink";
      treeNode8.Name = "ndeFinger7";
      treeNode8.Tag = "7";
      treeNode8.Text = "Ringvinger";
      treeNode9.Name = "ndeFinger8";
      treeNode9.Tag = "8";
      treeNode9.Text = "Middelvinger";
      treeNode10.Name = "ndeFinger9";
      treeNode10.Tag = "9";
      treeNode10.Text = "Wijsvinger";
      treeNode11.Name = "ndeFinger10";
      treeNode11.Tag = "10";
      treeNode11.Text = "Duim";
      treeNode12.Name = "ndeRightHand";
      treeNode12.Text = "Rechterhand";
      this.trvFingers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12});
      this.trvFingers.Size = new System.Drawing.Size(121, 204);
      this.trvFingers.TabIndex = 10;
      this.trvFingers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvFingers_AfterSelect);
      // 
      // lblPersonValue
      // 
      this.lblPersonValue.AutoSize = true;
      this.lblPersonValue.Location = new System.Drawing.Point(64, 4);
      this.lblPersonValue.Name = "lblPersonValue";
      this.lblPersonValue.Size = new System.Drawing.Size(96, 13);
      this.lblPersonValue.TabIndex = 9;
      this.lblPersonValue.Text = "Rob op den Kelder";
      // 
      // lblPerson
      // 
      this.lblPerson.AutoSize = true;
      this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPerson.Location = new System.Drawing.Point(8, 3);
      this.lblPerson.Name = "lblPerson";
      this.lblPerson.Size = new System.Drawing.Size(57, 13);
      this.lblPerson.TabIndex = 8;
      this.lblPerson.Text = "Persoon:";
      // 
      // axGrFingerXCtrl1
      // 
      this.axGrFingerXCtrl1.Enabled = true;
      this.axGrFingerXCtrl1.Location = new System.Drawing.Point(290, 183);
      this.axGrFingerXCtrl1.Name = "axGrFingerXCtrl1";
      this.axGrFingerXCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrFingerXCtrl1.OcxState")));
      this.axGrFingerXCtrl1.Size = new System.Drawing.Size(32, 32);
      this.axGrFingerXCtrl1.TabIndex = 7;
      this.axGrFingerXCtrl1.SensorPlug += new AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEventHandler(this.axGrFingerXCtrl1_SensorPlug);
      this.axGrFingerXCtrl1.FingerUp += new AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEventHandler(this.axGrFingerXCtrl1_FingerUp);
      this.axGrFingerXCtrl1.FingerDown += new AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEventHandler(this.axGrFingerXCtrl1_FingerDown);
      this.axGrFingerXCtrl1.ImageAcquired += new AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEventHandler(this.axGrFingerXCtrl1_ImageAcquired);
      // 
      // pbDelete
      // 
      this.pbDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.pbDelete.Image = global::FlexAccess.Properties.Resources.Verwijderen;
      this.pbDelete.Location = new System.Drawing.Point(328, 20);
      this.pbDelete.Name = "pbDelete";
      this.pbDelete.Size = new System.Drawing.Size(16, 23);
      this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbDelete.TabIndex = 12;
      this.pbDelete.TabStop = false;
      this.pbDelete.Visible = false;
      this.pbDelete.MouseLeave += new System.EventHandler(this.pbDelete_MouseLeave);
      this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
      this.pbDelete.MouseEnter += new System.EventHandler(this.pbDelete_MouseEnter);
      // 
      // pbFingerPrint
      // 
      this.pbFingerPrint.BackColor = System.Drawing.Color.Transparent;
      this.pbFingerPrint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pbFingerPrint.Location = new System.Drawing.Point(138, 20);
      this.pbFingerPrint.Name = "pbFingerPrint";
      this.pbFingerPrint.Size = new System.Drawing.Size(184, 204);
      this.pbFingerPrint.TabIndex = 11;
      this.pbFingerPrint.TabStop = false;
      this.pbFingerPrint.Visible = false;
      // 
      // frmAddFinger
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(349, 227);
      this.Controls.Add(this.axGrFingerXCtrl1);
      this.Controls.Add(this.pbDelete);
      this.Controls.Add(this.pbFingerPrint);
      this.Controls.Add(this.trvFingers);
      this.Controls.Add(this.lblPersonValue);
      this.Controls.Add(this.lblPerson);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "frmAddFinger";
      this.Text = "Vinger beheer - FlexAccess";
      ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbFingerPrint)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pbDelete;
    private System.Windows.Forms.PictureBox pbFingerPrint;
    private System.Windows.Forms.TreeView trvFingers;
    private System.Windows.Forms.Label lblPersonValue;
    private System.Windows.Forms.Label lblPerson;
    private AxGrFingerXLib.AxGrFingerXCtrl axGrFingerXCtrl1;
  }
}