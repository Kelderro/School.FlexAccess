namespace FlexAccess.Help
{
    partial class frmHelp
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Gebruiker Toevoegen");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Gebruiker Zoeken");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Gebruiker Wijzigen");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Gebruiker verwijderen");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Rechten toekennen");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Rechten wijzigen");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Rechten", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Gebruiker", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Zone toevoegen");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Zone", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Beheer", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Systemclient");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Beheerder toevoegen");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Systeembeheer", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Onderwerpen", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode15});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(2, 90);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node7";
            treeNode1.Text = "Gebruiker Toevoegen";
            treeNode2.Name = "Node8";
            treeNode2.Text = "Gebruiker Zoeken";
            treeNode3.Name = "Node9";
            treeNode3.Text = "Gebruiker Wijzigen";
            treeNode4.Name = "Node10";
            treeNode4.Text = "Gebruiker verwijderen";
            treeNode5.Name = "Node12";
            treeNode5.Text = "Rechten toekennen";
            treeNode6.Name = "Node13";
            treeNode6.Text = "Rechten wijzigen";
            treeNode7.Name = "Node11";
            treeNode7.Text = "Rechten";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Gebruiker";
            treeNode9.Name = "Node15";
            treeNode9.Text = "Zone toevoegen";
            treeNode10.Name = "Node14";
            treeNode10.Text = "Zone";
            treeNode11.Name = "Node1";
            treeNode11.Text = "Beheer";
            treeNode12.Name = "Node3";
            treeNode12.Text = "Node";
            treeNode13.Name = "Node4";
            treeNode13.Text = "Systemclient";
            treeNode14.Name = "Node5";
            treeNode14.Text = "Beheerder toevoegen";
            treeNode15.Name = "Node2";
            treeNode15.Text = "Systeembeheer";
            treeNode16.Name = "Node0";
            treeNode16.Text = "Onderwerpen";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(187, 352);
            this.treeView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoeken";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 90);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 352);
            this.textBox2.TabIndex = 3;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 441);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHelp";
            this.Text = "frmHelp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}