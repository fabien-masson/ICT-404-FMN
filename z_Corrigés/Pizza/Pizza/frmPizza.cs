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
    public partial class frmPizza : Form
    {
        public frmPizza()
        {
            InitializeComponent();
        }

        private void cmdCommander_Click(object sender, EventArgs e)
        {
            bool AvecUneGarniture = false; // Sera mis à Vrai si des garnitures sont choisies

            // Test du numéro de table
            if (txtTable.Text == "")
            {
                MessageBox.Show("Introduisez un numéro de table");
                return; // sortie du gestionnaire d'événement
            }

            // Texte de base
            txtCommandeCuisine.Text = "Pour la " + txtTable.Text + ": pâte ";
            // Pâte
            foreach (var control in grpPate.Controls)
            {
                RadioButton radio = control as RadioButton;
                if (radio != null && radio.Checked)
                {
                    txtCommandeCuisine.Text += radio.Text;
                }
            }

            // Test s'il y a au moins une garniture choisie
            if (chkJambon.Checked || chkCapres.Checked || chkAnchois.Checked || chkCrevettes.Checked)
            {
                txtCommandeCuisine.Text = txtCommandeCuisine.Text + " avec ";
                AvecUneGarniture = true; // se rappeler qu'une garniture au moins a été choisie
                if (chkAnchois.Checked) txtCommandeCuisine.Text = txtCommandeCuisine.Text + "anchois, ";
                if (chkCapres.Checked) txtCommandeCuisine.Text = txtCommandeCuisine.Text + "capres, ";
                if (chkJambon.Checked) txtCommandeCuisine.Text = txtCommandeCuisine.Text + "jambon, ";
                if (chkCrevettes.Checked) txtCommandeCuisine.Text = txtCommandeCuisine.Text + "crevettes, ";
                // Supprimer les deux derniers caratères car on a forcément ", " en trop à la fin
                txtCommandeCuisine.Text = txtCommandeCuisine.Text.Substring(0, txtCommandeCuisine.Text.Length - 2);
            }
            // Est-ce qu'une mozzarella spéciale a été sélectionnée
            if (optMozzBuff.Checked || optMozzMaigre.Checked)
            {
                // Choix du texte selon qu'il y avait une garniture ou pas
                if (AvecUneGarniture) txtCommandeCuisine.Text = txtCommandeCuisine.Text + " et mozzarella";
                else txtCommandeCuisine.Text = txtCommandeCuisine.Text + " avec mozzarella";
                if (optMozzBuff.Checked) txtCommandeCuisine.Text = txtCommandeCuisine.Text + " de bufflonne";
                if (optMozzMaigre.Checked) txtCommandeCuisine.Text = txtCommandeCuisine.Text + " maigre";
            }
        }
    }
}
