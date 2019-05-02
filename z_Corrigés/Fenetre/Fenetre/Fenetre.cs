using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fenetre
{
    public partial class Fenetre : Form
    {
        int NbMvt = 0;  // Nombre de mouvements effectués
        int NbChgt = 0; // Nombre de changements de couleur

        public Fenetre()
        {
            InitializeComponent();
        }

        private void cmdBleu_Click(object sender, EventArgs e) // Bouton "bleu" cliqué
        {
            BackColor = Color.Blue;
            NbChgt += 1;
        }

        private void cmdRouge_Click(object sender, EventArgs e) // Bouton "rouge" cliqué
        {
            BackColor = Color.Red;
            NbChgt += 1;
        }

        private void cmdHG_Click(object sender, EventArgs e) // Bouton "haut/gauche" cliqué
        {
            SetBounds(0, 0, 0, 0, BoundsSpecified.Location);
            NbMvt += 1;
        }

        private void cmdHD_Click(object sender, EventArgs e) // Bouton "haut/droite" cliqué
        {
            SetBounds(Screen.PrimaryScreen.Bounds.Width - Bounds.Width, 0, 0, 0, BoundsSpecified.Location);
            NbMvt += 1;
           
        }

        private void cmdBD_Click(object sender, EventArgs e) // Bouton "bas/droite" cliqué
        {
            SetBounds(Screen.PrimaryScreen.Bounds.Width - Bounds.Width, Screen.PrimaryScreen.Bounds.Height - Bounds.Height, 0, 0, BoundsSpecified.Location);
            NbMvt += 1;
        }

        private void cmdBG_Click(object sender, EventArgs e) // Bouton "bas/gauche" cliqué
        {
            SetBounds(0, Screen.PrimaryScreen.Bounds.Height - Bounds.Height, 0, 0, BoundsSpecified.Location);
            NbMvt += 1;
        }

        private void cmdStats_Click(object sender, EventArgs e) // Bouton "Stats" cliqué
        {
            MessageBox.Show(NbMvt + " déplacement(s), " + NbChgt + " changement(s) de couleur.");
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdGoXY_Click(object sender, EventArgs e)
        {
            SetBounds(int.Parse(txtGoX.Text), int.Parse(txtGoY.Text), 0, 0, BoundsSpecified.Location);
            NbMvt += 1;
        }

        private void cmdHaut_MouseHover(object sender, EventArgs e) // La souris passe sur le bouton
        {
            // on ne modifie que la position verticale
            SetBounds(0, Bounds.Location.Y - Screen.PrimaryScreen.Bounds.Height/50, 0, 0, BoundsSpecified.Y);
            NbMvt += 1;
        }

        private void cmdDroite_MouseHover(object sender, EventArgs e)
        {
            // on ne modifie que la position horizontale
            SetBounds(Bounds.Location.X + Screen.PrimaryScreen.Bounds.Width / 50, 0, 0, 0, BoundsSpecified.X);
            NbMvt += 1;
        }

        private void cmdBas_MouseHover(object sender, EventArgs e)
        {
            SetBounds(0, Bounds.Location.Y + Screen.PrimaryScreen.Bounds.Height / 50, 0, 0, BoundsSpecified.Y);
            NbMvt += 1;
        }

        private void cmdGauche_MouseHover(object sender, EventArgs e)
        {
            SetBounds(Bounds.Location.X - Screen.PrimaryScreen.Bounds.Width / 50, 0, 0, 0, BoundsSpecified.X);
            NbMvt += 1;
        }

        private void Fenetre_Load(object sender, EventArgs e)
        {
            this.SetBounds((Screen.GetBounds(this).Width / 2) - (this.Width / 2),
      (Screen.GetBounds(this).Height / 2) - (this.Height / 2),
this.Width, this.Height, BoundsSpecified.Location);
        }
    }
}
