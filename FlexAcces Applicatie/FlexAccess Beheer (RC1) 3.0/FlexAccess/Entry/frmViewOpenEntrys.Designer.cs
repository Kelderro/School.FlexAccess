namespace FlexAccess.Entry
{
    partial class frmViewOpenEntrys
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
            this.dgOpenEntrys = new System.Windows.Forms.DataGridView();
            this.tmrCheckEntrys = new System.Windows.Forms.Timer(this.components);
            this.taEntry = new FlexAccess.FlexAccessDataSetTableAdapters.entryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgOpenEntrys)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOpenEntrys
            // 
            this.dgOpenEntrys.AllowUserToAddRows = false;
            this.dgOpenEntrys.AllowUserToDeleteRows = false;
            this.dgOpenEntrys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOpenEntrys.Location = new System.Drawing.Point(12, 12);
            this.dgOpenEntrys.Name = "dgOpenEntrys";
            this.dgOpenEntrys.ReadOnly = true;
            this.dgOpenEntrys.Size = new System.Drawing.Size(444, 501);
            this.dgOpenEntrys.TabIndex = 0;
            // 
            // tmrCheckEntrys
            // 
            this.tmrCheckEntrys.Interval = 1000;
            this.tmrCheckEntrys.Tick += new System.EventHandler(this.tmrCheckEntrys_Tick);
            // 
            // taEntry
            // 
            this.taEntry.ClearBeforeFill = true;
            // 
            // frmViewOpenEntrys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 525);
            this.Controls.Add(this.dgOpenEntrys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewOpenEntrys";
            this.ShowIcon = false;
            this.Text = "Open openingen";
            ((System.ComponentModel.ISupportInitialize)(this.dgOpenEntrys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOpenEntrys;
        private System.Windows.Forms.Timer tmrCheckEntrys;
        private FlexAccess.FlexAccessDataSetTableAdapters.entryTableAdapter taEntry;
    }
}