using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FlexAccess
{
    public partial class frmFlexAccess : Form
    {
        private int childFormNumber = 0;
        private Boolean fade = false;
        public static Person.Person _ingelogdeGebruiker;
        private static FlexClient connectie = new FlexClient();
        //private static Thread ConnectThread = new Thread(new ThreadStart(ConnectToServer));
        private static String connectTo = "145.24.159.48";

        public frmFlexAccess(int loggedinPerson)
        {
            InitializeComponent();
            FlexAccessDataSet.personDataTable personDataTable = taPerson.GetPersonDetails(loggedinPerson);
            _ingelogdeGebruiker = new FlexAccess.Person.Person();
            foreach (FlexAccessDataSet.personRow personRow in personDataTable)
            {
                _ingelogdeGebruiker.PersonID = personRow.prs_id;
                _ingelogdeGebruiker.Firstname = personRow.prs_firstname;
                _ingelogdeGebruiker.Middlename = personRow.prs_middlename;
                _ingelogdeGebruiker.Lastname = personRow.prs_lastname;
            }
        }

        private void frmFlexAccess_Load(object sender, EventArgs e)
        {
            opacityTimer.Start();
            //ConnectToServer();
            verbrekenToolStripMenuItem.Enabled = false;
        }

        private static void ConnectToServer()
        {
            Boolean connected = false;
            while (connected == false)
            {
                connected = connectie.Connect(connectTo);
                if (connected)
                {
                    FlexAccess.Connection.Send.ClientRegistation(connectie.getClient());
                }
            }
        }

        private static void DisconnectFromServer()
        {
            connectie.disconnect();
        }

        private void frmFlexAccess_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fade == false)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = FlexAccess.Properties.Resources.Logoff;
                player.Play();
                e.Cancel = true;
                fade = true;
                opacityTimer.Start();
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new Form();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                // TODO: Add code here to open the file.
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO: Add code here to save the current contents of the form to a file.
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
          // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          // TODO: Use System.Windows.Forms.Clipboard.GetText() or System.Windows.Forms.GetData to retrieve information from the clipboard.
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
          LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
          LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
              childForm.Close();
            }
        }


        private void searchPersonMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchPerson childSearchPerson = new frmSearchPerson();
            childSearchPerson.MdiParent = this;
            childSearchPerson.Show();
        }

        private void addPersonMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPerson childAddPerson = new frmAddPerson();
            childAddPerson.MdiParent = this;
            childAddPerson.Show();
        }

        private void toevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddZone childAddZone = new frmAddZone();
            childAddZone.MdiParent = this;
            childAddZone.Show();
        }

        private void searchZoneMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchZone childSearchZone = new frmSearchZone();
            childSearchZone.MdiParent = this;
            childSearchZone.Show();
        }

        private void toevoegenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddManager childAddSystemUser = new frmAddManager();
            childAddSystemUser.MdiParent = this;
            childAddSystemUser.Show();
        }

        private void wachtwoordWijzigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.frmChangePassword childfrmChangePassword = new Admin.frmChangePassword(_ingelogdeGebruiker);
            childfrmChangePassword.MdiParent = this;
            childfrmChangePassword.Show();
        }

        private void toevoegenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Entry.frmAddEntry childfrmAddEntry = new Entry.frmAddEntry();
            childfrmAddEntry.MdiParent = this;
            childfrmAddEntry.Show();
        }

        private void toevoegenToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Node.frmAddnode_category childfrmAddnode_category = new Node.frmAddnode_category();
            childfrmAddnode_category.MdiParent = this;
            childfrmAddnode_category.Show();
        }

        private void wijzigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Node.frmSearchnode_category childfrmSearchnode_category = new Node.frmSearchnode_category();
            childfrmSearchnode_category.MdiParent = this;
            childfrmSearchnode_category.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout childAbout = new frmAbout();
            childAbout.MdiParent = this;
            childAbout.Show();
        }

        private void helpOnderwerpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.frmHelp childHelp = new Help.frmHelp();
            childHelp.MdiParent = this;
            childHelp.Show();
        }

        private void toevoegenToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Entry.frmAddEntry_category childAddentry_category = new Entry.frmAddEntry_category();
            childAddentry_category.MdiParent = this;
            childAddentry_category.Show();
        }

        private void wijzigenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Entry.frmSearchEntry_category childSearchEntry_category = new Entry.frmSearchEntry_category();
            childSearchEntry_category.MdiParent = this;
            childSearchEntry_category.Show();
        }

        private void groepenBeherenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person.frmGroupPersons childGroupPersons = new Person.frmGroupPersons();
            childGroupPersons.MdiParent = this;
            childGroupPersons.Show();
        }

        private void opacityTimer_Tick(object sender, EventArgs e)
        {
            if (fade)
            {
                //if (ConnectThread != null)
                //{
                    //ConnectThread.Abort();
                    //ConnectThread = null;
                //}

                this.Opacity -= 0.05;
                if (this.Opacity == 0)
                {
                    Application.Exit();
                    this.Close();
                    opacityTimer.Stop();
                }
            }
            else
            {
                this.Opacity += 0.05;
                if (this.Opacity == 1)
                {
                    opacityTimer.Stop();
                }
            }
        }

        private void toeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Node.frmAddnode_model childAddnode_model = new Node.frmAddnode_model();
            childAddnode_model.MdiParent = this;
            childAddnode_model.Show();
        }

        private void wijzigenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Node.frmSearchnode_model childSearchnode_model = new Node.frmSearchnode_model();
            childSearchnode_model.MdiParent = this;
            childSearchnode_model.Show();
        }

        private void toevoegenToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Systemclient.frmAddsystemclient childAddsystemclient = new Systemclient.frmAddsystemclient();
            childAddsystemclient.MdiParent = this;
            childAddsystemclient.Show();
        }

        private void wijzigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Systemclient.frmSearchsystemclient childSearchsystemclient = new Systemclient.frmSearchsystemclient();
            childSearchsystemclient.MdiParent = this;
            childSearchsystemclient.Show();
        }

        private void toevoegenToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Node.frmAddnode childAddnode = new Node.frmAddnode();
            childAddnode.MdiParent = this;
            childAddnode.Show();
        }

        private void wijzigenToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Node.frmSearchNode childSearchNode = new Node.frmSearchNode();
            childSearchNode.MdiParent = this;
            childSearchNode.Show();
        }

        private void wijzigenToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Entry.frmSearchEntry childSearchEntry = new Entry.frmSearchEntry();
            childSearchEntry.MdiParent = this;
            childSearchEntry.Show();
        }

        private void verbindenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (ConnectThread == null)
            //{
                //ConnectThread = new Thread(new ThreadStart(ConnectToServer));
                //ConnectThread.Priority = ThreadPriority.Lowest;
                //ConnectThread.Name = "ConnectThread";
                //ConnectThread.Start();
                ConnectToServer();
                verbindenToolStripMenuItem.Enabled = false;
                verbrekenToolStripMenuItem.Enabled = true;
            //}
        }

        private void verbrekenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (ConnectThread.ThreadState == ThreadState.Running)
            //{
                //ConnectThread.Abort();
                //ConnectThread = null;
            DisconnectFromServer();
            verbindenToolStripMenuItem.Enabled = true;
            verbrekenToolStripMenuItem.Enabled = false;
            //}
        }

        private void rechtenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rights.Rights childRights = new Rights.Rights();
            childRights.MdiParent = this;
            childRights.Show();
        }

        private void actueelGeopendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entry.frmViewOpenEntrys childViewOpenEntrys = new Entry.frmViewOpenEntrys();
            childViewOpenEntrys.MdiParent = this;
            childViewOpenEntrys.Show();
        }

        private void toevoegenToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Entry.frmAddEntry_controller childAddEntry_controller = new Entry.frmAddEntry_controller();
            childAddEntry_controller.MdiParent = this;
            childAddEntry_controller.Show();
        }

        private void wijzigenToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Entry.frmSearchEntry_controller childSearchEntry_controller = new Entry.frmSearchEntry_controller();
            childSearchEntry_controller.MdiParent = this;
            childSearchEntry_controller.Show();
        }

        private void openAlleDeurenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lockdownToolStripMenuItem.Enabled = false;
            openAlleDeurenToolStripMenuItem.Enabled = false;
            if (verbindenToolStripMenuItem.Enabled)
            {
                ConnectToServer();
                verbindenToolStripMenuItem.Enabled = false;
                verbrekenToolStripMenuItem.Enabled = true;
            }
            Emergency.EmergencyOpen childEmergencyOpen = new Emergency.EmergencyOpen(connectie);
            childEmergencyOpen.MdiParent = this;
            childEmergencyOpen.Show();
        }

        private void lockdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lockdownToolStripMenuItem.Enabled = false;
            openAlleDeurenToolStripMenuItem.Enabled = false;
            if (verbindenToolStripMenuItem.Enabled)
            {
                ConnectToServer();
                verbindenToolStripMenuItem.Enabled = false;
                verbrekenToolStripMenuItem.Enabled = true;
            }
            Emergency.EmergencyClose cildEmergencyClose = new Emergency.EmergencyClose(connectie);
            cildEmergencyClose.MdiParent = this;
            cildEmergencyClose.Show();
        }

        public void enableEmergencyButtons()
        {
            lockdownToolStripMenuItem.Enabled = true;
            openAlleDeurenToolStripMenuItem.Enabled = true;
        }

        private void voorheenGeopendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Loggin childLog = new Log.Loggin();
            childLog.MdiParent = this;
            childLog.Show();
        }
    }
}
