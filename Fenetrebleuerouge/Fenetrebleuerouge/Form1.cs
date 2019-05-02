using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fenetrebleuerouge
{
    public partial class Fenetre : Form
    {
        int compteurCouleur;
        int compteurDepl;
        int X;
        int Y;




        public Fenetre()
        {
            InitializeComponent();
        }

        private void txtBleu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            compteurCouleur += 1;
        }

        private void txtRouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            compteurCouleur += 1;
        }

        private void txtHautGauche_Click(object sender, EventArgs e)
        {
            this.SetBounds(55, 0, 470, 500);
            compteurDepl += 1;
        }

        private void txtBasGauche_Click(object sender, EventArgs e)
        {
            this.SetBounds(55, 600, 470, 500);
            compteurDepl += 1;
        }

        private void txtHautDroit_Click(object sender, EventArgs e)
        {
            this.SetBounds(1455, 0, 470, 500);
            compteurDepl += 1;
        }

        private void txtBasDroit_Click(object sender, EventArgs e)
        {
            this.SetBounds(1455, 600, 470, 500);
            compteurDepl += 1;
        }

        private void txtQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtStats_Click(object sender, EventArgs e)
        {
                MessageBox.Show(compteurDepl + "déplacements et " + compteurCouleur + "changements de couleur");
                return;
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            X = int.Parse(txtX.Text);
            Y = int.Parse(txtY.Text);
            this.SetBounds(X, Y, 470, 500);

        }
    }
}