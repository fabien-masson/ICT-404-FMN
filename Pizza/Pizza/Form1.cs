using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Pizza : Form
    {

        int Table;
        string Pate;
        string Mozzarella;
        string Anchois;
        string Capres;
        string Jambon;
        string Crevettes;

        public Pizza()
        {
            InitializeComponent();
        }




        private void cmdCommander_Click(object sender, EventArgs e)
        {
            //Table = int.Parse(cmdBox.Text);

            if (!int.TryParse(cmdBox.Text, out Table))
            {
                MessageBox.Show("NON");
                txtBox.Text = "";
                return;
            }


            if (rdoExtraFine.Checked == true) { Pate = "Extra Fine"; }
            if (rdoFine.Checked == true) { Pate = "Fine"; }
            if (rdoNormale.Checked == true) { Pate = "Normale"; }
            if (rdoEpaisse.Checked == true) { Pate = "Epaisse"; }

            if (rdoMaigre.Checked == true) { Mozzarella = "Maigre"; }
            if (rdoNormale2.Checked == true) { Mozzarella = ""; }
            if (rdoBufflone.Checked == true) { Mozzarella = "Bufflone"; }

            if (chkAnchois.Checked == true) { Anchois = "Anchois, "; }
            if (chkCâpres.Checked == true) { Capres = "Câpres, "; }
            if (chkJambon.Checked == true) { Jambon = "Jambon, "; }
            if (chkCrevettes.Checked == true) { Crevettes = "Crevettes  "; }

            if (chkAnchois.Checked == false) { Anchois = ""; }
            if (chkCâpres.Checked == false) { Capres = ""; }
            if (chkJambon.Checked == false) { Jambon = ""; }
            if (chkCrevettes.Checked == false) { Crevettes = ""; }



            txtBox.Text = "pour la " + Table + " : pâte "+ Pate +", " + Mozzarella + " avec " + Anchois + Capres + Jambon + Crevettes;

            txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 2);
            //txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 2, 2);
        }

        private void chkJambon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJambon.Checked == true) { chkCrevettes.Checked = false; }

        }

        private void chkCrevettes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCrevettes.Checked == true) { chkJambon.Checked = false; }
        }
    }
}
