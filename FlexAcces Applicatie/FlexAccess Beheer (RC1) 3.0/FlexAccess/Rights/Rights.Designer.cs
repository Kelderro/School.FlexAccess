namespace FlexAccess.Rights
{
    partial class Rights
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.trvPersons = new System.Windows.Forms.TreeView();
            this.dgZones = new System.Windows.Forms.DataGridView();
            this.cmdGroup = new System.Windows.Forms.Button();
            this.taPerson = new FlexAccess.FlexAccessDataSetTableAdapters.personTableAdapter();
            this.taPerson_group = new FlexAccess.FlexAccessDataSetTableAdapters.person_groupTableAdapter();
            this.taZone = new FlexAccess.FlexAccessDataSetTableAdapters.zoneTableAdapter();
            this.taEntry = new FlexAccess.FlexAccessDataSetTableAdapters.entryTableAdapter();
            this.taperson_has_zone = new FlexAccess.FlexAccessDataSetTableAdapters.person_has_zoneTableAdapter();
            this.taperson_has_entry = new FlexAccess.FlexAccessDataSetTableAdapters.person_has_entryTableAdapter();
            this.tapersongroup_has_entry = new FlexAccess.FlexAccessDataSetTableAdapters.persongroup_has_entryTableAdapter();
            this.tapersongroup_has_zone = new FlexAccess.FlexAccessDataSetTableAdapters.persongroup_has_zoneTableAdapter();
            this.lblzones = new System.Windows.Forms.Label();
            this.dgEntrys = new System.Windows.Forms.DataGridView();
            this.lblEntrys = new System.Windows.Forms.Label();
            this.lblSelectedValue = new System.Windows.Forms.Label();
            this.dgcZoneItem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcZoneAccess = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcZoneAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcEntryItem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcEntryAccess = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcEntryAction = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgZones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrys)).BeginInit();
            this.SuspendLayout();
            // 
            // trvPersons
            // 
            this.trvPersons.BackColor = System.Drawing.Color.LightBlue;
            this.trvPersons.Location = new System.Drawing.Point(0, 46);
            this.trvPersons.Name = "trvPersons";
            this.trvPersons.Size = new System.Drawing.Size(200, 509);
            this.trvPersons.TabIndex = 0;
            this.trvPersons.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvPersons_AfterSelect);
            // 
            // dgZones
            // 
            this.dgZones.AllowUserToDeleteRows = false;
            this.dgZones.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgZones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgZones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcZoneItem,
            this.dgcZoneAccess,
            this.dgcZoneAction});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgZones.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgZones.Location = new System.Drawing.Point(206, 25);
            this.dgZones.MultiSelect = false;
            this.dgZones.Name = "dgZones";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgZones.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgZones.Size = new System.Drawing.Size(545, 247);
            this.dgZones.TabIndex = 1;
            this.dgZones.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgZones_RowsAdded);
            this.dgZones.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgZones_CellValueChanged);
            this.dgZones.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgZones_CellEnter);
            this.dgZones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgZones_CellContentClick);
            // 
            // cmdGroup
            // 
            this.cmdGroup.Location = new System.Drawing.Point(0, 25);
            this.cmdGroup.Name = "cmdGroup";
            this.cmdGroup.Size = new System.Drawing.Size(200, 23);
            this.cmdGroup.TabIndex = 2;
            this.cmdGroup.Text = "Niet groeperen";
            this.cmdGroup.UseVisualStyleBackColor = true;
            this.cmdGroup.Click += new System.EventHandler(this.cmdGroup_Click);
            // 
            // taPerson
            // 
            this.taPerson.ClearBeforeFill = true;
            // 
            // taPerson_group
            // 
            this.taPerson_group.ClearBeforeFill = true;
            // 
            // taZone
            // 
            this.taZone.ClearBeforeFill = true;
            // 
            // taEntry
            // 
            this.taEntry.ClearBeforeFill = true;
            // 
            // taperson_has_zone
            // 
            this.taperson_has_zone.ClearBeforeFill = true;
            // 
            // taperson_has_entry
            // 
            this.taperson_has_entry.ClearBeforeFill = true;
            // 
            // tapersongroup_has_entry
            // 
            this.tapersongroup_has_entry.ClearBeforeFill = true;
            // 
            // tapersongroup_has_zone
            // 
            this.tapersongroup_has_zone.ClearBeforeFill = true;
            // 
            // lblzones
            // 
            this.lblzones.AutoSize = true;
            this.lblzones.Location = new System.Drawing.Point(206, 8);
            this.lblzones.Name = "lblzones";
            this.lblzones.Size = new System.Drawing.Size(39, 13);
            this.lblzones.TabIndex = 3;
            this.lblzones.Text = "Zone\'s";
            // 
            // dgEntrys
            // 
            this.dgEntrys.AllowUserToDeleteRows = false;
            this.dgEntrys.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEntrys.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgEntrys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntrys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcEntryItem,
            this.dgcEntryAccess,
            this.dgcEntryAction});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEntrys.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgEntrys.Location = new System.Drawing.Point(206, 308);
            this.dgEntrys.MultiSelect = false;
            this.dgEntrys.Name = "dgEntrys";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEntrys.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgEntrys.Size = new System.Drawing.Size(545, 247);
            this.dgEntrys.TabIndex = 4;
            this.dgEntrys.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgEntrys_RowsAdded);
            this.dgEntrys.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntrys_CellValueChanged);
            this.dgEntrys.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntrys_CellEnter);
            this.dgEntrys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntrys_CellContentClick);
            // 
            // lblEntrys
            // 
            this.lblEntrys.AutoSize = true;
            this.lblEntrys.Location = new System.Drawing.Point(209, 289);
            this.lblEntrys.Name = "lblEntrys";
            this.lblEntrys.Size = new System.Drawing.Size(59, 13);
            this.lblEntrys.TabIndex = 5;
            this.lblEntrys.Text = "Openingen";
            // 
            // lblSelectedValue
            // 
            this.lblSelectedValue.AutoSize = true;
            this.lblSelectedValue.Location = new System.Drawing.Point(12, 8);
            this.lblSelectedValue.Name = "lblSelectedValue";
            this.lblSelectedValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSelectedValue.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedValue.TabIndex = 6;
            this.lblSelectedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgcZoneItem
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            this.dgcZoneItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcZoneItem.HeaderText = "Zone:";
            this.dgcZoneItem.Name = "dgcZoneItem";
            this.dgcZoneItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcZoneItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcZoneItem.Width = 250;
            // 
            // dgcZoneAccess
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            this.dgcZoneAccess.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgcZoneAccess.HeaderText = "toegang";
            this.dgcZoneAccess.Items.AddRange(new object[] {
            "verlenen",
            "weigeren"});
            this.dgcZoneAccess.Name = "dgcZoneAccess";
            this.dgcZoneAccess.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcZoneAccess.Width = 150;
            // 
            // dgcZoneAction
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgcZoneAction.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgcZoneAction.HeaderText = "Actie";
            this.dgcZoneAction.Name = "dgcZoneAction";
            this.dgcZoneAction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcZoneAction.Text = "";
            // 
            // dgcEntryItem
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightBlue;
            this.dgcEntryItem.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgcEntryItem.HeaderText = "Opening:";
            this.dgcEntryItem.Name = "dgcEntryItem";
            this.dgcEntryItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcEntryItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcEntryItem.Width = 250;
            // 
            // dgcEntryAccess
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightBlue;
            this.dgcEntryAccess.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgcEntryAccess.HeaderText = "toegang";
            this.dgcEntryAccess.Items.AddRange(new object[] {
            "verlenen",
            "weigeren"});
            this.dgcEntryAccess.Name = "dgcEntryAccess";
            this.dgcEntryAccess.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcEntryAccess.Width = 150;
            // 
            // dgcEntryAction
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgcEntryAction.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgcEntryAction.HeaderText = "Actie";
            this.dgcEntryAction.Name = "dgcEntryAction";
            this.dgcEntryAction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcEntryAction.Text = "Hoiiiii";
            // 
            // Rights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 557);
            this.Controls.Add(this.lblSelectedValue);
            this.Controls.Add(this.lblEntrys);
            this.Controls.Add(this.dgEntrys);
            this.Controls.Add(this.lblzones);
            this.Controls.Add(this.cmdGroup);
            this.Controls.Add(this.dgZones);
            this.Controls.Add(this.trvPersons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rights";
            this.ShowIcon = false;
            this.Text = "Rechten toekennen";
            ((System.ComponentModel.ISupportInitialize)(this.dgZones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvPersons;
        private System.Windows.Forms.DataGridView dgZones;
        private FlexAccess.FlexAccessDataSetTableAdapters.personTableAdapter taPerson;
        private FlexAccess.FlexAccessDataSetTableAdapters.person_groupTableAdapter taPerson_group;
        private System.Windows.Forms.Button cmdGroup;
        private FlexAccess.FlexAccessDataSetTableAdapters.zoneTableAdapter taZone;
        private FlexAccess.FlexAccessDataSetTableAdapters.entryTableAdapter taEntry;
        private FlexAccess.FlexAccessDataSetTableAdapters.person_has_zoneTableAdapter taperson_has_zone;
        private FlexAccess.FlexAccessDataSetTableAdapters.person_has_entryTableAdapter taperson_has_entry;
        private FlexAccess.FlexAccessDataSetTableAdapters.persongroup_has_entryTableAdapter tapersongroup_has_entry;
        private FlexAccess.FlexAccessDataSetTableAdapters.persongroup_has_zoneTableAdapter tapersongroup_has_zone;
        private System.Windows.Forms.Label lblzones;
        private System.Windows.Forms.DataGridView dgEntrys;
        private System.Windows.Forms.Label lblEntrys;
        private System.Windows.Forms.Label lblSelectedValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcZoneItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcZoneAccess;
        private System.Windows.Forms.DataGridViewButtonColumn dgcZoneAction;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcEntryItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcEntryAccess;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEntryAction;
    }
}