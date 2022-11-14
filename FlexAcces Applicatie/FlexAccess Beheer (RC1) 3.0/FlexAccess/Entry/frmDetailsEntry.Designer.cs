namespace FlexAccess.Entry
{
    partial class frmDetailsEntry
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
            this.lblZone = new System.Windows.Forms.Label();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.grbConnection = new System.Windows.Forms.GroupBox();
            this.lblControllerport = new System.Windows.Forms.Label();
            this.txtControllerPort = new System.Windows.Forms.TextBox();
            this.lblController = new System.Windows.Forms.Label();
            this.cmbController = new System.Windows.Forms.ComboBox();
            this.lblSelectedEntry = new System.Windows.Forms.Label();
            this.gbNode = new System.Windows.Forms.GroupBox();
            this.cmdDeselectNodes = new System.Windows.Forms.Button();
            this.cmdShowAllNodes = new System.Windows.Forms.Button();
            this.dgNodes = new System.Windows.Forms.DataGridView();
            this.lblSelectedNode = new System.Windows.Forms.Label();
            this.lblSearchNode = new System.Windows.Forms.Label();
            this.txtSearchNode = new System.Windows.Forms.TextBox();
            this.cmdSearchNode = new System.Windows.Forms.Button();
            this.cmdShowSelectedNodes = new System.Windows.Forms.Button();
            this.lblRemark = new System.Windows.Forms.Label();
            this.cmdChangeEntry = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblEntryName = new System.Windows.Forms.Label();
            this.txtEntryName = new System.Windows.Forms.TextBox();
            this.lblEntryCategory = new System.Windows.Forms.Label();
            this.cmbEntryCategory = new System.Windows.Forms.ComboBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.lblSelectedEntryValue = new System.Windows.Forms.Label();
            this.taZone = new FlexAccess.FlexAccessDataSetTableAdapters.zoneTableAdapter();
            this.taSystemclient = new FlexAccess.FlexAccessDataSetTableAdapters.systemclientTableAdapter();
            this.taEntry = new FlexAccess.FlexAccessDataSetTableAdapters.entryTableAdapter();
            this.taEntry_controller = new FlexAccess.FlexAccessDataSetTableAdapters.entry_controllerTableAdapter();
            this.taEntry_category = new FlexAccess.FlexAccessDataSetTableAdapters.entry_categoryTableAdapter();
            this.taLink = new FlexAccess.FlexAccessDataSetTableAdapters.nde_ent_smc_linkTableAdapter();
            this.taNode = new FlexAccess.FlexAccessDataSetTableAdapters.nodeTableAdapter();
            this.grbConnection.SuspendLayout();
            this.gbNode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNodes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.Location = new System.Drawing.Point(22, 322);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(32, 13);
            this.lblZone.TabIndex = 24;
            this.lblZone.Text = "Zone";
            // 
            // cmbZone
            // 
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(98, 319);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(251, 21);
            this.cmbZone.TabIndex = 23;
            this.cmbZone.SelectedIndexChanged += new System.EventHandler(this.cmbZone_SelectedIndexChanged);
            // 
            // grbConnection
            // 
            this.grbConnection.Controls.Add(this.lblControllerport);
            this.grbConnection.Controls.Add(this.txtControllerPort);
            this.grbConnection.Controls.Add(this.lblController);
            this.grbConnection.Controls.Add(this.cmbController);
            this.grbConnection.Location = new System.Drawing.Point(2, 361);
            this.grbConnection.Name = "grbConnection";
            this.grbConnection.Size = new System.Drawing.Size(347, 173);
            this.grbConnection.TabIndex = 22;
            this.grbConnection.TabStop = false;
            this.grbConnection.Text = "Verbinding";
            // 
            // lblControllerport
            // 
            this.lblControllerport.AutoSize = true;
            this.lblControllerport.Location = new System.Drawing.Point(20, 104);
            this.lblControllerport.Name = "lblControllerport";
            this.lblControllerport.Size = new System.Drawing.Size(72, 13);
            this.lblControllerport.TabIndex = 3;
            this.lblControllerport.Text = "Poort nummer";
            // 
            // txtControllerPort
            // 
            this.txtControllerPort.Location = new System.Drawing.Point(95, 101);
            this.txtControllerPort.Name = "txtControllerPort";
            this.txtControllerPort.Size = new System.Drawing.Size(73, 20);
            this.txtControllerPort.TabIndex = 2;
            this.txtControllerPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControllerPort_KeyPress);
            this.txtControllerPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtControllerPort_KeyDown);
            // 
            // lblController
            // 
            this.lblController.AutoSize = true;
            this.lblController.Location = new System.Drawing.Point(19, 67);
            this.lblController.Name = "lblController";
            this.lblController.Size = new System.Drawing.Size(51, 13);
            this.lblController.TabIndex = 1;
            this.lblController.Text = "Controller";
            // 
            // cmbController
            // 
            this.cmbController.FormattingEnabled = true;
            this.cmbController.Location = new System.Drawing.Point(95, 64);
            this.cmbController.Name = "cmbController";
            this.cmbController.Size = new System.Drawing.Size(240, 21);
            this.cmbController.TabIndex = 0;
            this.cmbController.SelectedIndexChanged += new System.EventHandler(this.cmbController_SelectedIndexChanged);
            // 
            // lblSelectedEntry
            // 
            this.lblSelectedEntry.AutoSize = true;
            this.lblSelectedEntry.Location = new System.Drawing.Point(10, 18);
            this.lblSelectedEntry.Name = "lblSelectedEntry";
            this.lblSelectedEntry.Size = new System.Drawing.Size(158, 13);
            this.lblSelectedEntry.TabIndex = 21;
            this.lblSelectedEntry.Text = "Momenteel geselecteerde entry:";
            // 
            // gbNode
            // 
            this.gbNode.Controls.Add(this.cmdDeselectNodes);
            this.gbNode.Controls.Add(this.cmdShowAllNodes);
            this.gbNode.Controls.Add(this.dgNodes);
            this.gbNode.Controls.Add(this.lblSelectedNode);
            this.gbNode.Controls.Add(this.lblSearchNode);
            this.gbNode.Controls.Add(this.txtSearchNode);
            this.gbNode.Controls.Add(this.cmdSearchNode);
            this.gbNode.Controls.Add(this.cmdShowSelectedNodes);
            this.gbNode.Location = new System.Drawing.Point(367, 21);
            this.gbNode.Name = "gbNode";
            this.gbNode.Size = new System.Drawing.Size(357, 513);
            this.gbNode.TabIndex = 20;
            this.gbNode.TabStop = false;
            this.gbNode.Text = "(Optioneel) selecteer node(\'s)";
            // 
            // cmdDeselectNodes
            // 
            this.cmdDeselectNodes.Location = new System.Drawing.Point(228, 468);
            this.cmdDeselectNodes.Name = "cmdDeselectNodes";
            this.cmdDeselectNodes.Size = new System.Drawing.Size(110, 23);
            this.cmdDeselectNodes.TabIndex = 8;
            this.cmdDeselectNodes.Text = "deselecteer nodes";
            this.cmdDeselectNodes.UseVisualStyleBackColor = true;
            this.cmdDeselectNodes.Click += new System.EventHandler(this.cmdDeselectNodes_Click);
            // 
            // cmdShowAllNodes
            // 
            this.cmdShowAllNodes.Location = new System.Drawing.Point(263, 47);
            this.cmdShowAllNodes.Name = "cmdShowAllNodes";
            this.cmdShowAllNodes.Size = new System.Drawing.Size(75, 23);
            this.cmdShowAllNodes.TabIndex = 7;
            this.cmdShowAllNodes.Text = "toon alles";
            this.cmdShowAllNodes.UseVisualStyleBackColor = true;
            this.cmdShowAllNodes.Click += new System.EventHandler(this.cmdShowAllNodes_Click);
            // 
            // dgNodes
            // 
            this.dgNodes.AllowUserToAddRows = false;
            this.dgNodes.AllowUserToDeleteRows = false;
            this.dgNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNodes.Location = new System.Drawing.Point(20, 77);
            this.dgNodes.Name = "dgNodes";
            this.dgNodes.ReadOnly = true;
            this.dgNodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNodes.Size = new System.Drawing.Size(318, 385);
            this.dgNodes.TabIndex = 6;
            this.dgNodes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNodes_CellClick);
            // 
            // lblSelectedNode
            // 
            this.lblSelectedNode.AutoSize = true;
            this.lblSelectedNode.Location = new System.Drawing.Point(24, 473);
            this.lblSelectedNode.Name = "lblSelectedNode";
            this.lblSelectedNode.Size = new System.Drawing.Size(117, 13);
            this.lblSelectedNode.TabIndex = 5;
            this.lblSelectedNode.Text = "geselecteerde node(\'s):";
            // 
            // lblSearchNode
            // 
            this.lblSearchNode.AutoSize = true;
            this.lblSearchNode.Location = new System.Drawing.Point(17, 24);
            this.lblSearchNode.Name = "lblSearchNode";
            this.lblSearchNode.Size = new System.Drawing.Size(91, 13);
            this.lblSearchNode.TabIndex = 4;
            this.lblSearchNode.Text = "Zoeken op naam:";
            // 
            // txtSearchNode
            // 
            this.txtSearchNode.Location = new System.Drawing.Point(113, 21);
            this.txtSearchNode.Name = "txtSearchNode";
            this.txtSearchNode.Size = new System.Drawing.Size(225, 20);
            this.txtSearchNode.TabIndex = 3;
            // 
            // cmdSearchNode
            // 
            this.cmdSearchNode.Location = new System.Drawing.Point(174, 48);
            this.cmdSearchNode.Name = "cmdSearchNode";
            this.cmdSearchNode.Size = new System.Drawing.Size(75, 23);
            this.cmdSearchNode.TabIndex = 2;
            this.cmdSearchNode.Text = "zoek";
            this.cmdSearchNode.UseVisualStyleBackColor = true;
            this.cmdSearchNode.Click += new System.EventHandler(this.cmdSearchNode_Click);
            // 
            // cmdShowSelectedNodes
            // 
            this.cmdShowSelectedNodes.Location = new System.Drawing.Point(147, 468);
            this.cmdShowSelectedNodes.Name = "cmdShowSelectedNodes";
            this.cmdShowSelectedNodes.Size = new System.Drawing.Size(75, 23);
            this.cmdShowSelectedNodes.TabIndex = 0;
            this.cmdShowSelectedNodes.Text = "laat zien";
            this.cmdShowSelectedNodes.UseVisualStyleBackColor = true;
            this.cmdShowSelectedNodes.Click += new System.EventHandler(this.cmdShowSelectedNodes_Click);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(19, 152);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(61, 13);
            this.lblRemark.TabIndex = 19;
            this.lblRemark.Text = "Opmerking:";
            // 
            // cmdChangeEntry
            // 
            this.cmdChangeEntry.Location = new System.Drawing.Point(13, 547);
            this.cmdChangeEntry.Name = "cmdChangeEntry";
            this.cmdChangeEntry.Size = new System.Drawing.Size(548, 23);
            this.cmdChangeEntry.TabIndex = 18;
            this.cmdChangeEntry.Text = "wijzigen";
            this.cmdChangeEntry.UseVisualStyleBackColor = true;
            this.cmdChangeEntry.Click += new System.EventHandler(this.cmdChangeEntry_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(98, 152);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(240, 161);
            this.txtRemark.TabIndex = 17;
            // 
            // lblEntryName
            // 
            this.lblEntryName.AutoSize = true;
            this.lblEntryName.Location = new System.Drawing.Point(19, 102);
            this.lblEntryName.Name = "lblEntryName";
            this.lblEntryName.Size = new System.Drawing.Size(38, 13);
            this.lblEntryName.TabIndex = 16;
            this.lblEntryName.Text = "Naam:";
            // 
            // txtEntryName
            // 
            this.txtEntryName.Location = new System.Drawing.Point(98, 99);
            this.txtEntryName.Name = "txtEntryName";
            this.txtEntryName.Size = new System.Drawing.Size(240, 20);
            this.txtEntryName.TabIndex = 15;
            this.txtEntryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntryName_KeyPress);
            this.txtEntryName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntryName_KeyDown);
            // 
            // lblEntryCategory
            // 
            this.lblEntryCategory.AutoSize = true;
            this.lblEntryCategory.Location = new System.Drawing.Point(19, 128);
            this.lblEntryCategory.Name = "lblEntryCategory";
            this.lblEntryCategory.Size = new System.Drawing.Size(35, 13);
            this.lblEntryCategory.TabIndex = 14;
            this.lblEntryCategory.Text = "Soort:";
            // 
            // cmbEntryCategory
            // 
            this.cmbEntryCategory.DisplayMember = "enc_id";
            this.cmbEntryCategory.FormattingEnabled = true;
            this.cmbEntryCategory.Location = new System.Drawing.Point(98, 125);
            this.cmbEntryCategory.Name = "cmbEntryCategory";
            this.cmbEntryCategory.Size = new System.Drawing.Size(251, 21);
            this.cmbEntryCategory.TabIndex = 13;
            this.cmbEntryCategory.ValueMember = "enc_id";
            this.cmbEntryCategory.SelectedIndexChanged += new System.EventHandler(this.cmbEntryCategory_SelectedIndexChanged);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(567, 547);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(157, 23);
            this.cmdDelete.TabIndex = 25;
            this.cmdDelete.Text = "verwijderen";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // lblSelectedEntryValue
            // 
            this.lblSelectedEntryValue.AutoSize = true;
            this.lblSelectedEntryValue.Location = new System.Drawing.Point(174, 18);
            this.lblSelectedEntryValue.Name = "lblSelectedEntryValue";
            this.lblSelectedEntryValue.Size = new System.Drawing.Size(54, 13);
            this.lblSelectedEntryValue.TabIndex = 26;
            this.lblSelectedEntryValue.Text = "<waarde>";
            // 
            // taZone
            // 
            this.taZone.ClearBeforeFill = true;
            // 
            // taSystemclient
            // 
            this.taSystemclient.ClearBeforeFill = true;
            // 
            // taEntry
            // 
            this.taEntry.ClearBeforeFill = true;
            // 
            // taEntry_controller
            // 
            this.taEntry_controller.ClearBeforeFill = true;
            // 
            // taEntry_category
            // 
            this.taEntry_category.ClearBeforeFill = true;
            // 
            // taLink
            // 
            this.taLink.ClearBeforeFill = true;
            // 
            // taNode
            // 
            this.taNode.ClearBeforeFill = true;
            // 
            // frmDetailsEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 576);
            this.Controls.Add(this.lblSelectedEntryValue);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.lblZone);
            this.Controls.Add(this.cmbZone);
            this.Controls.Add(this.grbConnection);
            this.Controls.Add(this.lblSelectedEntry);
            this.Controls.Add(this.gbNode);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.cmdChangeEntry);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblEntryName);
            this.Controls.Add(this.txtEntryName);
            this.Controls.Add(this.lblEntryCategory);
            this.Controls.Add(this.cmbEntryCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDetailsEntry";
            this.ShowIcon = false;
            this.Text = "Wijzigen doorgang";
            this.grbConnection.ResumeLayout(false);
            this.grbConnection.PerformLayout();
            this.gbNode.ResumeLayout(false);
            this.gbNode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.GroupBox grbConnection;
        private System.Windows.Forms.Label lblControllerport;
        private System.Windows.Forms.TextBox txtControllerPort;
        private System.Windows.Forms.Label lblController;
        private System.Windows.Forms.ComboBox cmbController;
        private System.Windows.Forms.Label lblSelectedEntry;
        private System.Windows.Forms.GroupBox gbNode;
        private System.Windows.Forms.Button cmdDeselectNodes;
        private System.Windows.Forms.Button cmdShowAllNodes;
        private System.Windows.Forms.DataGridView dgNodes;
        private System.Windows.Forms.Label lblSelectedNode;
        private System.Windows.Forms.Label lblSearchNode;
        private System.Windows.Forms.TextBox txtSearchNode;
        private System.Windows.Forms.Button cmdSearchNode;
        private System.Windows.Forms.Button cmdShowSelectedNodes;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Button cmdChangeEntry;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblEntryName;
        private System.Windows.Forms.TextBox txtEntryName;
        private System.Windows.Forms.Label lblEntryCategory;
        private System.Windows.Forms.ComboBox cmbEntryCategory;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Label lblSelectedEntryValue;
        private FlexAccess.FlexAccessDataSetTableAdapters.zoneTableAdapter taZone;
        private FlexAccess.FlexAccessDataSetTableAdapters.systemclientTableAdapter taSystemclient;
        private FlexAccess.FlexAccessDataSetTableAdapters.entryTableAdapter taEntry;
        private FlexAccess.FlexAccessDataSetTableAdapters.entry_controllerTableAdapter taEntry_controller;
        private FlexAccess.FlexAccessDataSetTableAdapters.entry_categoryTableAdapter taEntry_category;
        private FlexAccess.FlexAccessDataSetTableAdapters.nde_ent_smc_linkTableAdapter taLink;
        private FlexAccess.FlexAccessDataSetTableAdapters.nodeTableAdapter taNode;
    }
}