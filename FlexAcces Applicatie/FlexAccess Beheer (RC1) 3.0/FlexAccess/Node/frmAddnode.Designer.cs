namespace FlexAccess.Node
{
    partial class frmAddnode
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.gbSystemclient = new System.Windows.Forms.GroupBox();
            this.cmdSearchSystemClient = new System.Windows.Forms.Button();
            this.cmdShowAllSystemClients = new System.Windows.Forms.Button();
            this.lblSystemclientValue = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchSystemClient = new System.Windows.Forms.TextBox();
            this.dgSystemclients = new System.Windows.Forms.DataGridView();
            this.gbNode = new System.Windows.Forms.GroupBox();
            this.cmdDeselectEntrys = new System.Windows.Forms.Button();
            this.cmdShowAllEntrys = new System.Windows.Forms.Button();
            this.dgEntrys = new System.Windows.Forms.DataGridView();
            this.lblSelectedEntry = new System.Windows.Forms.Label();
            this.lblSearchEntry = new System.Windows.Forms.Label();
            this.txtSearchEntry = new System.Windows.Forms.TextBox();
            this.cmdSearchEntry = new System.Windows.Forms.Button();
            this.cmdShowSelectedEntrys = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCategorieValue = new System.Windows.Forms.Label();
            this.taSystemclient = new FlexAccess.FlexAccessDataSetTableAdapters.systemclientTableAdapter();
            this.taNode_model = new FlexAccess.FlexAccessDataSetTableAdapters.node_modelTableAdapter();
            this.taNode_category = new FlexAccess.FlexAccessDataSetTableAdapters.node_categoryTableAdapter();
            this.taEntry = new FlexAccess.FlexAccessDataSetTableAdapters.entryTableAdapter();
            this.taLink = new FlexAccess.FlexAccessDataSetTableAdapters.nde_ent_smc_linkTableAdapter();
            this.taNode = new FlexAccess.FlexAccessDataSetTableAdapters.nodeTableAdapter();
            this.gbSystemclient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSystemclients)).BeginInit();
            this.gbNode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrys)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Enabled = false;
            this.cmdSubmit.Location = new System.Drawing.Point(16, 543);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(737, 23);
            this.cmdSubmit.TabIndex = 0;
            this.cmdSubmit.Text = "Toevoegen";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Omschrijving";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(97, 18);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(259, 20);
            this.txtname.TabIndex = 4;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(97, 93);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(259, 104);
            this.txtRemark.TabIndex = 5;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(97, 44);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(276, 21);
            this.cmbModel.TabIndex = 6;
            this.cmbModel.SelectionChangeCommitted += new System.EventHandler(this.cmbModel_SelectionChangeCommitted);
            // 
            // gbSystemclient
            // 
            this.gbSystemclient.Controls.Add(this.cmdSearchSystemClient);
            this.gbSystemclient.Controls.Add(this.cmdShowAllSystemClients);
            this.gbSystemclient.Controls.Add(this.lblSystemclientValue);
            this.gbSystemclient.Controls.Add(this.lblSelected);
            this.gbSystemclient.Controls.Add(this.lblSearch);
            this.gbSystemclient.Controls.Add(this.txtSearchSystemClient);
            this.gbSystemclient.Controls.Add(this.dgSystemclients);
            this.gbSystemclient.Location = new System.Drawing.Point(16, 221);
            this.gbSystemclient.Name = "gbSystemclient";
            this.gbSystemclient.Size = new System.Drawing.Size(357, 305);
            this.gbSystemclient.TabIndex = 7;
            this.gbSystemclient.TabStop = false;
            this.gbSystemclient.Text = "Selecteer systemcliënt";
            // 
            // cmdSearchSystemClient
            // 
            this.cmdSearchSystemClient.Location = new System.Drawing.Point(196, 53);
            this.cmdSearchSystemClient.Name = "cmdSearchSystemClient";
            this.cmdSearchSystemClient.Size = new System.Drawing.Size(64, 23);
            this.cmdSearchSystemClient.TabIndex = 6;
            this.cmdSearchSystemClient.Text = "zoek";
            this.cmdSearchSystemClient.UseVisualStyleBackColor = true;
            this.cmdSearchSystemClient.Click += new System.EventHandler(this.cmdSearchSystemClient_Click);
            // 
            // cmdShowAllSystemClients
            // 
            this.cmdShowAllSystemClients.Location = new System.Drawing.Point(266, 53);
            this.cmdShowAllSystemClients.Name = "cmdShowAllSystemClients";
            this.cmdShowAllSystemClients.Size = new System.Drawing.Size(64, 23);
            this.cmdShowAllSystemClients.TabIndex = 5;
            this.cmdShowAllSystemClients.Text = "toon alles";
            this.cmdShowAllSystemClients.UseVisualStyleBackColor = true;
            this.cmdShowAllSystemClients.Click += new System.EventHandler(this.cmdShowAllSystemClients_Click);
            // 
            // lblSystemclientValue
            // 
            this.lblSystemclientValue.AutoSize = true;
            this.lblSystemclientValue.Location = new System.Drawing.Point(127, 281);
            this.lblSystemclientValue.Name = "lblSystemclientValue";
            this.lblSystemclientValue.Size = new System.Drawing.Size(0, 13);
            this.lblSystemclientValue.TabIndex = 4;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(16, 281);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(105, 13);
            this.lblSelected.TabIndex = 3;
            this.lblSelected.Text = "geselecteerde cliënt:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(16, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(91, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Zoeken op naam:";
            // 
            // txtSearchSystemClient
            // 
            this.txtSearchSystemClient.Location = new System.Drawing.Point(113, 27);
            this.txtSearchSystemClient.Name = "txtSearchSystemClient";
            this.txtSearchSystemClient.Size = new System.Drawing.Size(217, 20);
            this.txtSearchSystemClient.TabIndex = 1;
            // 
            // dgSystemclients
            // 
            this.dgSystemclients.AllowUserToAddRows = false;
            this.dgSystemclients.AllowUserToDeleteRows = false;
            this.dgSystemclients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSystemclients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSystemclients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSystemclients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSystemclients.Location = new System.Drawing.Point(19, 80);
            this.dgSystemclients.MultiSelect = false;
            this.dgSystemclients.Name = "dgSystemclients";
            this.dgSystemclients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSystemclients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSystemclients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSystemclients.Size = new System.Drawing.Size(311, 190);
            this.dgSystemclients.TabIndex = 0;
            this.dgSystemclients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSystemclients_CellClick);
            // 
            // gbNode
            // 
            this.gbNode.Controls.Add(this.cmdDeselectEntrys);
            this.gbNode.Controls.Add(this.cmdShowAllEntrys);
            this.gbNode.Controls.Add(this.dgEntrys);
            this.gbNode.Controls.Add(this.lblSelectedEntry);
            this.gbNode.Controls.Add(this.lblSearchEntry);
            this.gbNode.Controls.Add(this.txtSearchEntry);
            this.gbNode.Controls.Add(this.cmdSearchEntry);
            this.gbNode.Controls.Add(this.cmdShowSelectedEntrys);
            this.gbNode.Location = new System.Drawing.Point(396, 18);
            this.gbNode.Name = "gbNode";
            this.gbNode.Size = new System.Drawing.Size(357, 508);
            this.gbNode.TabIndex = 9;
            this.gbNode.TabStop = false;
            this.gbNode.Text = "(Optioneel) selecteer entry(\'s)";
            // 
            // cmdDeselectEntrys
            // 
            this.cmdDeselectEntrys.Location = new System.Drawing.Point(220, 479);
            this.cmdDeselectEntrys.Name = "cmdDeselectEntrys";
            this.cmdDeselectEntrys.Size = new System.Drawing.Size(110, 23);
            this.cmdDeselectEntrys.TabIndex = 8;
            this.cmdDeselectEntrys.Text = "deselecteer entrys";
            this.cmdDeselectEntrys.UseVisualStyleBackColor = true;
            this.cmdDeselectEntrys.Click += new System.EventHandler(this.cmdDeselectEntrys_Click);
            // 
            // cmdShowAllEntrys
            // 
            this.cmdShowAllEntrys.Location = new System.Drawing.Point(255, 48);
            this.cmdShowAllEntrys.Name = "cmdShowAllEntrys";
            this.cmdShowAllEntrys.Size = new System.Drawing.Size(75, 23);
            this.cmdShowAllEntrys.TabIndex = 7;
            this.cmdShowAllEntrys.Text = "toon alles";
            this.cmdShowAllEntrys.UseVisualStyleBackColor = true;
            this.cmdShowAllEntrys.Click += new System.EventHandler(this.cmdShowAllEntrys_Click);
            // 
            // dgEntrys
            // 
            this.dgEntrys.AllowUserToAddRows = false;
            this.dgEntrys.AllowUserToDeleteRows = false;
            this.dgEntrys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntrys.Location = new System.Drawing.Point(20, 75);
            this.dgEntrys.Name = "dgEntrys";
            this.dgEntrys.ReadOnly = true;
            this.dgEntrys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEntrys.Size = new System.Drawing.Size(310, 398);
            this.dgEntrys.TabIndex = 6;
            this.dgEntrys.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntrys_CellClick);
            // 
            // lblSelectedEntry
            // 
            this.lblSelectedEntry.AutoSize = true;
            this.lblSelectedEntry.Location = new System.Drawing.Point(16, 484);
            this.lblSelectedEntry.Name = "lblSelectedEntry";
            this.lblSelectedEntry.Size = new System.Drawing.Size(116, 13);
            this.lblSelectedEntry.TabIndex = 5;
            this.lblSelectedEntry.Text = "geselecteerde entry(\'s):";
            // 
            // lblSearchEntry
            // 
            this.lblSearchEntry.AutoSize = true;
            this.lblSearchEntry.Location = new System.Drawing.Point(17, 24);
            this.lblSearchEntry.Name = "lblSearchEntry";
            this.lblSearchEntry.Size = new System.Drawing.Size(91, 13);
            this.lblSearchEntry.TabIndex = 4;
            this.lblSearchEntry.Text = "Zoeken op naam:";
            // 
            // txtSearchEntry
            // 
            this.txtSearchEntry.Location = new System.Drawing.Point(113, 21);
            this.txtSearchEntry.Name = "txtSearchEntry";
            this.txtSearchEntry.Size = new System.Drawing.Size(217, 20);
            this.txtSearchEntry.TabIndex = 3;
            // 
            // cmdSearchEntry
            // 
            this.cmdSearchEntry.Location = new System.Drawing.Point(174, 48);
            this.cmdSearchEntry.Name = "cmdSearchEntry";
            this.cmdSearchEntry.Size = new System.Drawing.Size(75, 23);
            this.cmdSearchEntry.TabIndex = 2;
            this.cmdSearchEntry.Text = "zoek";
            this.cmdSearchEntry.UseVisualStyleBackColor = true;
            this.cmdSearchEntry.Click += new System.EventHandler(this.cmdSearchEntry_Click);
            // 
            // cmdShowSelectedEntrys
            // 
            this.cmdShowSelectedEntrys.Location = new System.Drawing.Point(139, 479);
            this.cmdShowSelectedEntrys.Name = "cmdShowSelectedEntrys";
            this.cmdShowSelectedEntrys.Size = new System.Drawing.Size(75, 23);
            this.cmdShowSelectedEntrys.TabIndex = 0;
            this.cmdShowSelectedEntrys.Text = "laat zien";
            this.cmdShowSelectedEntrys.UseVisualStyleBackColor = true;
            this.cmdShowSelectedEntrys.Click += new System.EventHandler(this.cmdShowSelectedEntrys_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 71);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Categorie";
            // 
            // lblCategorieValue
            // 
            this.lblCategorieValue.AutoSize = true;
            this.lblCategorieValue.Location = new System.Drawing.Point(94, 71);
            this.lblCategorieValue.Name = "lblCategorieValue";
            this.lblCategorieValue.Size = new System.Drawing.Size(0, 13);
            this.lblCategorieValue.TabIndex = 11;
            // 
            // taSystemclient
            // 
            this.taSystemclient.ClearBeforeFill = true;
            // 
            // taNode_model
            // 
            this.taNode_model.ClearBeforeFill = true;
            // 
            // taNode_category
            // 
            this.taNode_category.ClearBeforeFill = true;
            // 
            // taEntry
            // 
            this.taEntry.ClearBeforeFill = true;
            // 
            // taLink
            // 
            this.taLink.ClearBeforeFill = true;
            // 
            // taNode
            // 
            this.taNode.ClearBeforeFill = true;
            // 
            // frmAddnode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 579);
            this.Controls.Add(this.lblCategorieValue);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.gbNode);
            this.Controls.Add(this.gbSystemclient);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddnode";
            this.ShowIcon = false;
            this.Text = "Toevoegen Node";
            this.Load += new System.EventHandler(this.frmAddnode_Load);
            this.gbSystemclient.ResumeLayout(false);
            this.gbSystemclient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSystemclients)).EndInit();
            this.gbNode.ResumeLayout(false);
            this.gbNode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.GroupBox gbSystemclient;
        private System.Windows.Forms.Button cmdSearchSystemClient;
        private System.Windows.Forms.Button cmdShowAllSystemClients;
        private System.Windows.Forms.Label lblSystemclientValue;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchSystemClient;
        private System.Windows.Forms.DataGridView dgSystemclients;
        private System.Windows.Forms.GroupBox gbNode;
        private System.Windows.Forms.Button cmdDeselectEntrys;
        private System.Windows.Forms.Button cmdShowAllEntrys;
        private System.Windows.Forms.DataGridView dgEntrys;
        private System.Windows.Forms.Label lblSelectedEntry;
        private System.Windows.Forms.Label lblSearchEntry;
        private System.Windows.Forms.TextBox txtSearchEntry;
        private System.Windows.Forms.Button cmdSearchEntry;
        private System.Windows.Forms.Button cmdShowSelectedEntrys;
        private FlexAccess.FlexAccessDataSetTableAdapters.systemclientTableAdapter taSystemclient;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategorieValue;
        private FlexAccess.FlexAccessDataSetTableAdapters.node_modelTableAdapter taNode_model;
        private FlexAccess.FlexAccessDataSetTableAdapters.node_categoryTableAdapter taNode_category;
        private FlexAccess.FlexAccessDataSetTableAdapters.entryTableAdapter taEntry;
        private FlexAccess.FlexAccessDataSetTableAdapters.nde_ent_smc_linkTableAdapter taLink;
        private FlexAccess.FlexAccessDataSetTableAdapters.nodeTableAdapter taNode;
    }
}