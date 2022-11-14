using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Rights
{
    public partial class Rights : Form
    {
        private Boolean groupOrPerson;
        private int selectedID;
        private Object[] cellPropertyZone;
        private Object[] cellPropertyEntry;

        public Rights()
        {
            InitializeComponent();
            renewGroupedPersonList();
            updateDatagridvalues();
        }

        /*
        public Rights(Person.Person Person)
        {
            InitializeComponent();
            renewGroupedPersonList();
            updateDatagridvalues();
            this.dgEntrys.Rows.Clear();
            this.dgZones.Rows.Clear();
            selectedID = Person.PersonID;
            groupOrPerson = false;
            generateActualRights();
            lblSelectedValue.Text = "(" + Person.getFullName().ToString() + ")";
        }

        public Rights(Person.Person_group Person_group)
        {
            InitializeComponent();
            renewGroupedPersonList();
            updateDatagridvalues();
            this.dgEntrys.Rows.Clear();
            this.dgZones.Rows.Clear();
            selectedID = Person_group.personGroupID;
            groupOrPerson = true;
            generateActualRights();
            lblSelectedValue.Text = "[" + Person_group.personGroupName + "]";
        }
        */

        private void renewGroupedPersonList()
        {
            trvPersons.Nodes.Clear();
            FlexAccessDataSet.person_groupDataTable person_groupDataTable = taPerson_group.GetData();
            FlexAccessDataSet.personDataTable personNotGroupedDataTable = taPerson.getAllNonGroupedPersons();
            foreach (FlexAccessDataSet.person_groupRow person_groupRow in person_groupDataTable)
            {
                int i = 0;
                FlexAccessDataSet.personDataTable personDataTable = taPerson.GetPersonsByPersonGroupID(person_groupRow.psg_id);
                System.Windows.Forms.TreeNode[] treeNode = new System.Windows.Forms.TreeNode[personDataTable.Count];
                foreach (FlexAccessDataSet.personRow personRow in personDataTable)
                {
                    treeNode[i] = new System.Windows.Forms.TreeNode("prs-" + personRow.prs_id.ToString());
                    if (personRow.prs_middlename == "")
                    {
                        treeNode[i].Name = "person-" + personRow.prs_lastname + "," + personRow.prs_firstname;
                    }
                    else
                    {
                        treeNode[i].Name = "person-" + personRow.prs_lastname + "," + personRow.prs_firstname + "(" + personRow.prs_middlename + ")";
                    }
                    treeNode[i].Tag = personRow.prs_id;
                    if (personRow.prs_middlename == "")
                    {
                        treeNode[i].Text = personRow.prs_lastname + "," + personRow.prs_firstname;
                    }
                    else
                    {
                        treeNode[i].Text = personRow.prs_lastname + "," + personRow.prs_firstname + "(" + personRow.prs_middlename + ")";
                    }
                    i = i + 1;
                }
                System.Windows.Forms.TreeNode treeParentNode = new System.Windows.Forms.TreeNode("prg-" + person_groupRow.psg_id.ToString(), treeNode);
                treeParentNode.Name = "group-" + person_groupRow.psg_name;
                treeParentNode.Tag = person_groupRow.psg_id;
                treeParentNode.Text = person_groupRow.psg_name;
                trvPersons.Nodes.Add(treeParentNode);
            }

            //Alle niet gegroepeerde mensen
            int j = 0;
            System.Windows.Forms.TreeNode[] treeNode2 = new System.Windows.Forms.TreeNode[personNotGroupedDataTable.Count];
            foreach (FlexAccessDataSet.personRow personRow in personNotGroupedDataTable)
            {
                treeNode2[j] = new System.Windows.Forms.TreeNode("prs" + personRow.prs_id.ToString());
                if (personRow.prs_middlename == "")
                {
                    treeNode2[j].Name = "person-" + personRow.prs_lastname + "," + personRow.prs_firstname;
                }
                else
                {
                    treeNode2[j].Name = "person-" + personRow.prs_lastname + "," + personRow.prs_firstname + "(" + personRow.prs_middlename + ")";
                }
                treeNode2[j].Tag = personRow.prs_id;
                if (personRow.prs_middlename == "")
                {
                    treeNode2[j].Text = personRow.prs_lastname + "," + personRow.prs_firstname;
                }
                else
                {
                    treeNode2[j].Text = personRow.prs_lastname + "," + personRow.prs_firstname + "(" + personRow.prs_middlename + ")";
                }
                j = j + 1;
            }
            System.Windows.Forms.TreeNode treeParentNode2 = new System.Windows.Forms.TreeNode("Niet gegroepeerde personen", treeNode2);
            treeParentNode2.Name = "group-" + "Niet gegroepeerde personen";
            treeParentNode2.Tag = -1;
            treeParentNode2.Text = "Niet gegroepeerde personen";
            trvPersons.Nodes.Add(treeParentNode2);
        }

        private void renewPersonList()
        {
            trvPersons.Nodes.Clear();
            System.Windows.Forms.TreeNode treeNode = new System.Windows.Forms.TreeNode();
            FlexAccessDataSet.personDataTable personDataTable = taPerson.GetActivePerons();
            foreach (FlexAccessDataSet.personRow personRow in personDataTable)
            {
                treeNode = new System.Windows.Forms.TreeNode("prs" + personRow.prs_id.ToString());
                if (personRow.prs_middlename == "")
                {
                    treeNode.Name = "person-" + personRow.prs_lastname + "," + personRow.prs_firstname;
                }
                else
                {
                    treeNode.Name = "person-" + personRow.prs_lastname + "," + personRow.prs_firstname + "(" + personRow.prs_middlename + ")";
                }
                treeNode.Tag = personRow.prs_id;
                if (personRow.prs_middlename == "")
                {
                    treeNode.Text = personRow.prs_lastname + "," + personRow.prs_firstname;
                }
                else
                {
                    treeNode.Text = personRow.prs_lastname + "," + personRow.prs_firstname + "(" + personRow.prs_middlename + ")";
                }
                trvPersons.Nodes.Add(treeNode);
            }
        }

        private void updateDatagridvalues()
        {
            if (groupOrPerson)
            {
                dgcEntryItem.Items.Clear();
                FlexAccessDataSet.entryDataTable entryDataTable = taEntry.GetAllActiveEntrys();
                dgcEntryItem.DataSource = entryDataTable;
                dgcEntryItem.DisplayMember = "ent_name";
                dgcEntryItem.ValueMember = "ent_id";

                dgcZoneItem.Items.Clear();
                FlexAccessDataSet.zoneDataTable zoneDataTable = taZone.GetActiveZones();
                dgcZoneItem.DataSource = zoneDataTable;
                dgcZoneItem.DisplayMember = "zne_name";
                dgcZoneItem.ValueMember = "zne_id";
            }
            else
            {
                dgcEntryItem.Items.Clear();
                FlexAccessDataSet.entryDataTable entryDataTable = taEntry.GetAllActiveEntrys();
                dgcEntryItem.DataSource = entryDataTable;
                dgcEntryItem.DisplayMember = "ent_name";
                dgcEntryItem.ValueMember = "ent_id";

                dgcZoneItem.Items.Clear();
                FlexAccessDataSet.zoneDataTable zoneDataTable = taZone.GetActiveZones();
                dgcZoneItem.DataSource = zoneDataTable;
                dgcZoneItem.DisplayMember = "zne_name";
                dgcZoneItem.ValueMember = "zne_id";
            }
        }

        private void generateActualRights()
        {
            dgZones.Rows.Clear();
            dgEntrys.Rows.Clear();
            if (groupOrPerson)
            {
                int i = 0;
                //ZONE'S
                FlexAccessDataSet.persongroup_has_zoneDataTable persongroup_has_zoneDataTable = tapersongroup_has_zone.GetDataByPersongroupID(selectedID);
                foreach (FlexAccessDataSet.persongroup_has_zoneRow persongroup_has_zoneRow in persongroup_has_zoneDataTable)
                {
                    if (persongroup_has_zoneRow.pgz_access)
                    {
                        Object[] obj = { persongroup_has_zoneRow.zne_id, "verlenen" };
                        dgZones.Rows.Add(obj);
                        i++;
                    }
                    else
                    {
                        Object[] obj = { persongroup_has_zoneRow.zne_id, "weigeren" };
                        dgZones.Rows.Add(obj);
                        i++;
                    }
                    dgZones.Rows[i-1].Cells[2].Value = "verwijderen";
                }
                i = 0;
                //ENTRY'S
                
                FlexAccessDataSet.persongroup_has_entryDataTable persongroup_has_entryDataTable = tapersongroup_has_entry.GetDataByPersongroupID(selectedID);
                foreach (FlexAccessDataSet.persongroup_has_entryRow persongroup_has_entryRow in persongroup_has_entryDataTable)
                {
                    if (persongroup_has_entryRow.pge_access)
                    {
                        Object[] obj = { persongroup_has_entryRow.ent_id, "verlenen" };
                        dgEntrys.Rows.Add(obj);
                        i++;
                    }
                    else
                    {
                        Object[] obj = { persongroup_has_entryRow.ent_id, "weigeren" };
                        dgEntrys.Rows.Add(obj);
                        i++;
                    }
                    dgEntrys.Rows[i-1].Cells[2].Value = "verwijderen";
                }
            }
            else
            {
                int i = 0;
                //ZONE'S
                FlexAccessDataSet.person_has_zoneDataTable person_has_zoneDataTable = taperson_has_zone.GetDataByPersonID(selectedID);
                foreach (FlexAccessDataSet.person_has_zoneRow person_has_zoneRow in person_has_zoneDataTable)
                {
                    if (person_has_zoneRow.psz_access)
                    {
                        Object[] obj = { person_has_zoneRow.zne_id, "verlenen" };
                        dgZones.Rows.Add(obj);
                        i++;
                    }
                    else
                    {
                        Object[] obj = { person_has_zoneRow.zne_id, "weigeren" };
                        dgZones.Rows.Add(obj);
                        i++;
                    }
                    dgZones.Rows[i - 1].Cells[2].Value = "verwijderen";
                }
                i = 0;
                //ENTRY'S

                FlexAccessDataSet.person_has_entryDataTable person_has_entryDataTable = taperson_has_entry.GetDataByPersonID(selectedID);
                foreach (FlexAccessDataSet.person_has_entryRow person_has_entryRow in person_has_entryDataTable)
                {
                    if (person_has_entryRow.pse_access)
                    {
                        Object[] obj = { person_has_entryRow.ent_id, "verlenen" };
                        dgEntrys.Rows.Add(obj);
                        i++;
                    }
                    else
                    {
                        Object[] obj = { person_has_entryRow.ent_id, "weigeren" };
                        dgEntrys.Rows.Add(obj);
                        i++;
                    }
                    dgEntrys.Rows[i - 1].Cells[2].Value = "verwijderen";
                }
            }
        }

        private void cmdGroup_Click(object sender, EventArgs e)
        {
            if (cmdGroup.Text == "Niet groeperen")
            {
                cmdGroup.Text = "Gegroepeerd";
                renewPersonList();
            }
            else
            {
                if (cmdGroup.Text == "Gegroepeerd")
                {
                    cmdGroup.Text = "Niet groeperen";
                    renewGroupedPersonList();
                }
            }
        }

        private void trvPersons_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.dgEntrys.Rows.Clear();
            this.dgZones.Rows.Clear();
            selectedID = Convert.ToInt32(e.Node.Tag);
            if (e.Node.Name.Split('-')[0].ToString() == "group")
            {
                lblSelectedValue.Text = "[" + e.Node.Text.ToString() +"]";
                groupOrPerson = true;
            }
            else
            {
                lblSelectedValue.Text = "(" + e.Node.Text.ToString() + ")";
                groupOrPerson = false;
            }
            generateActualRights();
        }

        private void dgZones_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgZones.Rows[e.RowIndex].Cells[2].Value = "toevoegen";
        }

        private void dgEntrys_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgEntrys.Rows[e.RowIndex].Cells[2].Value = "toevoegen";
        }

        private void dgEntrys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                switch (dgEntrys.Rows[e.RowIndex].Cells[2].Value.ToString())
                {
                    case "toevoegen":
                        if (groupOrPerson)
                        {
                            // groep recht toevoegen
                            try
                            {
                                tapersongroup_has_entry.Insert(selectedID, Convert.ToInt32(dgEntrys.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgEntrys.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"));
                                dgEntrys.Rows[e.RowIndex].Cells[2].Value = "verwijderen";
                            }
                            catch
                            {
                                dgEntrys.Rows[e.RowIndex].Visible = false;
                                MessageBox.Show("Er is al een regel die deze gegevens bevat");
                            }
                        }
                        else
                        {
                            try
                            {
                                taperson_has_entry.Insert(selectedID, Convert.ToInt32(dgEntrys.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgEntrys.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"));
                                dgEntrys.Rows[e.RowIndex].Cells[2].Value = "verwijderen";
                            }
                            catch
                            {
                                dgEntrys.Rows[e.RowIndex].Visible = false;
                                MessageBox.Show("Er is al een regel die deze gegevens bevat");
                            }
                        }
                        break;
                    case "verwijderen":
                        if (groupOrPerson)
                        {
                            // groep recht verwijderen
                            tapersongroup_has_entry.Delete(selectedID, Convert.ToInt32(dgEntrys.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgEntrys.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"));
                            dgEntrys.Rows[e.RowIndex].Visible = false;
                               
                        }
                        else
                        {
                            // persoon recht verwijderen
                            taperson_has_entry.Delete(selectedID, Convert.ToInt32(dgEntrys.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgEntrys.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"));
                            dgEntrys.Rows[e.RowIndex].Visible = false;
                        }
                        break;
                    default:
                        Console.WriteLine("@@@@@@@@@@@@@Error@@@@@@@@@@@@@");
                        Console.WriteLine("Selected item no registed button value");
                        break;
                }
            }
        }

        private void dgZones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                switch (dgZones.Rows[e.RowIndex].Cells[2].Value.ToString())
                {
                    case "toevoegen":
                        if (groupOrPerson)
                        {
                            // groep recht toevoegen
                            try
                            {
                                tapersongroup_has_zone.Insert(selectedID, Convert.ToInt32(dgZones.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgZones.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"));
                                dgZones.Rows[e.RowIndex].Cells[2].Value = "verwijderen";
                            }
                            catch
                            {
                                dgZones.Rows[e.RowIndex].Visible = false;
                                MessageBox.Show("Er is al een regel die deze gegevens bevat");
                            }
                        }
                        else
                        {
                            // persoon recht toevoegen
                            try
                            {
                                taperson_has_zone.Insert(selectedID, Convert.ToInt32(dgZones.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgZones.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"));
                                dgZones.Rows[e.RowIndex].Cells[2].Value = "verwijderen";
                            }
                            catch
                            {
                                dgZones.Rows[e.RowIndex].Visible = false;
                                MessageBox.Show("Er is al een regel die deze gegevens bevat");
                            }
                        }
                        break;
                    case "verwijderen":
                        if (groupOrPerson)
                        {
                            tapersongroup_has_zone.Delete(selectedID, Convert.ToInt32(dgZones.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgZones.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"));
                            dgZones.Rows[e.RowIndex].Visible = false;
                        }
                        else
                        {
                            taperson_has_zone.Delete(selectedID, Convert.ToInt32(dgZones.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgZones.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"));
                            dgZones.Rows[e.RowIndex].Visible = false;
                        }
                        break;
                    default:
                        Console.WriteLine("@@@@@@@@@@@@@Error@@@@@@@@@@@@@");
                        Console.WriteLine("Selected item no registed button value");
                        break;
                }
            }
        }

        private void dgZones_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgZones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "toevoegen")
                {
                    if (dgZones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "verwijderen")
                    {
                        if (groupOrPerson)
                        {
                            //Wijzigen van een groepcell
                            switch (Convert.ToInt32(cellPropertyZone[1]))
                            {
                                case 0:
                                    try
                                    {
                                        tapersongroup_has_zone.Update(selectedID, Convert.ToInt32(dgZones.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgZones.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"), selectedID, Convert.ToInt32(cellPropertyZone[0]), (dgZones.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"));
                                    }
                                    catch
                                    {
                                        dgZones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToInt32(cellPropertyZone[0]);
                                        MessageBox.Show("Er is al een regel die deze gegevens bevat");
                                    }
                                    break;
                                case 1:
                                    try
                                    {
                                        tapersongroup_has_zone.Update(selectedID, Convert.ToInt32(dgZones.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgZones.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"), selectedID, Convert.ToInt32(dgZones.Rows[e.RowIndex].Cells[0].Value.ToString()), (cellPropertyZone[0].ToString() == "verlenen"));
                                    }
                                    catch
                                    {
                                        dgZones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToInt32(cellPropertyZone[0]);
                                        MessageBox.Show("Er is al een regel die deze gegevens bevat");
                                    } 
                                    break;
                            }
                        }
                        else
                        {
                            //Wijzigen van een persooncell
                            switch (Convert.ToInt32(cellPropertyZone[1]))
                            {
                                case 0:
                                    try
                                    {
                                        taperson_has_zone.Update(selectedID, Convert.ToInt32(dgZones.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgZones.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"), selectedID, Convert.ToInt32(cellPropertyZone[0]), (dgZones.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"));
                                    }
                                    catch
                                    {
                                        dgZones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToInt32(cellPropertyZone[0]);
                                        MessageBox.Show("Er is al een regel die deze gegevens bevat");
                                    }
                                    break;
                                case 1:
                                    try
                                    {
                                        taperson_has_zone.Update(selectedID, Convert.ToInt32(dgZones.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgZones.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"), selectedID, Convert.ToInt32(dgZones.Rows[e.RowIndex].Cells[0].Value.ToString()), (cellPropertyZone[0].ToString() == "verlenen"));
                                    }
                                    catch
                                    {
                                        dgZones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToInt32(cellPropertyZone[0]);
                                        MessageBox.Show("Er is al een regel die deze gegevens bevat");
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void dgZones_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cellPropertyZone = new Object[2];
            try
            {
                cellPropertyZone[0] = dgZones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                cellPropertyZone[1] = e.ColumnIndex.ToString();
            }
            catch
            {
                cellPropertyZone = null;
            }
        }

        private void dgEntrys_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgEntrys.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "toevoegen")
                {
                    if (dgEntrys.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "verwijderen")
                    {
                        if (groupOrPerson)
                        {
                            //Wijzigen van een groepcell
                            switch (Convert.ToInt32(cellPropertyEntry[1]))
                            {
                                case 0:
                                    try
                                    {
                                        tapersongroup_has_entry.Update(selectedID, Convert.ToInt32(dgEntrys.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgEntrys.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"), selectedID, Convert.ToInt32(cellPropertyEntry[0]), (dgEntrys.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"));
                                    }
                                    catch
                                    {
                                        dgEntrys.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToInt32(cellPropertyEntry[0]);
                                        MessageBox.Show("Er is al een regel die deze gegevens bevat");
                                    }
                                    break;
                                case 1:
                                    try
                                    {
                                        tapersongroup_has_entry.Update(selectedID, Convert.ToInt32(dgEntrys.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgEntrys.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"), selectedID, Convert.ToInt32(dgEntrys.Rows[e.RowIndex].Cells[0].Value.ToString()), (cellPropertyEntry[0].ToString() == "verlenen"));
                                    }
                                    catch
                                    {
                                        dgEntrys.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToInt32(cellPropertyEntry[0]);
                                        MessageBox.Show("Er is al een regel die deze gegevens bevat");
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            //Wijzigen van een persooncell
                            switch (Convert.ToInt32(cellPropertyEntry[1]))
                            {
                                case 0:
                                    try
                                    {
                                        taperson_has_entry.Update(selectedID, Convert.ToInt32(dgEntrys.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgEntrys.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"), selectedID, Convert.ToInt32(cellPropertyEntry[0]), (dgEntrys.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"));
                                    }
                                    catch
                                    {
                                        dgEntrys.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToInt32(cellPropertyEntry[0]);
                                        MessageBox.Show("Er is al een regel die deze gegevens bevat");
                                    }
                                    break;
                                case 1:
                                    try
                                    {
                                        taperson_has_entry.Update(selectedID, Convert.ToInt32(dgEntrys.Rows[e.RowIndex].Cells[0].Value.ToString()), (dgEntrys.Rows[e.RowIndex].Cells[1].Value.ToString() == "verlenen"), selectedID, Convert.ToInt32(dgEntrys.Rows[e.RowIndex].Cells[0].Value.ToString()), (cellPropertyEntry[0].ToString() == "verlenen"));
                                    }
                                    catch
                                    {
                                        dgEntrys.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToInt32(cellPropertyEntry[0]);
                                        MessageBox.Show("Er is al een regel die deze gegevens bevat");
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void dgEntrys_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cellPropertyEntry = new Object[2];
            try
            {
                cellPropertyEntry[0] = dgEntrys.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                cellPropertyEntry[1] = e.ColumnIndex.ToString();
            }
            catch
            {
                cellPropertyEntry = null;
            }
        }

    }
}