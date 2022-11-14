using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexAccess.Entry
{
    public partial class frmDetailsEntry_category : Form
    {

        private Entry_Categorie _entryCategorie;

        public frmDetailsEntry_category(Entry_Categorie objEntryCategorie)
        {
            InitializeComponent();
            _entryCategorie = new Entry_Categorie();
            _entryCategorie = objEntryCategorie;
            objEntryCategorie = null;
            txtName.Text = _entryCategorie.entryCategorieName;
            txtDescription.Text = _entryCategorie.entryCategorieRemark;
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            taEntryCategory.Update(txtName.Text, txtDescription.Text, true, _entryCategorie.entryCategorieID);
            CustomMessage childCustomMessage = new CustomMessage("categorie " + _entryCategorie.entryCategorieName + " is gewijzigd");
            childCustomMessage.Show();
            this.Close();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wilt u deze categorie echt verwijderen?", "Bevestig verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taEntryCategory.DeleteEntryCategory(_entryCategorie.entryCategorieID);
                CustomMessage childCustomMessage = new CustomMessage("categorie " + _entryCategorie.entryCategorieName + " is verwijderd");
                childCustomMessage.Show();
                this.Close();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                cmdSubmit.Enabled = false;
            }
            else
            {
                cmdSubmit.Enabled = true;
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            frmSearchEntry_category childfrmSearchEntry_category = new frmSearchEntry_category();

            childfrmSearchEntry_category.Show();
            this.Close();
        }
    }
}