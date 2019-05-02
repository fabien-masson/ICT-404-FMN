// Titre:                   Exercice C# Déductions 
// Description:             Calcul du revenu net imp osableen fonction du revenu brut
//                          et des déductions (coeff familial, transport,...)
// Auteur:                  A.Mottier
// Date:                    09.05.2018
// Dernière modification:   16.05.2018


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Déductions
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Calcul()
        {
            double Res;     // La valeur résultant du calcul (Revenu net imposable)
            double Brut;    // Revenu brut
            double Coeff;   // Coefficient familial
            int Fidelite;   // Rabais fidélité (%)
            int Jeune;      // Déduction jeune
            int Transport;  // Déduction pour transports

            // Vérification des données introduites
            if (!double.TryParse(txtBrut.Text, out Brut))
            {
                MessageBox.Show("Introduisez un montant correct");
                txtBrut.Focus(); // On place le curseur làoù l'info manque
                return; // On ne peut pas aller plus loin
            }
            if (!double.TryParse(txtCoeff.Text, out Coeff))
            {
                MessageBox.Show("Introduisez un coefficient familial correct");
                txtCoeff.Focus(); // On place le curseur là où l'info manque
                return; // On ne peut pas aller plus loin
            }

            // Calcul de la valeur de base du revenu net imposable
            Res = Brut / Coeff;

            // Application des déductions
            if (chkRabaisFidélité.Checked)
            {
                if (!int.TryParse(txtRabais.Text, out Fidelite))
                {
                    MessageBox.Show("Introduisez un montant entier correct");
                    txtRabais.Focus(); // On place le curseur là où l'info manque
                    return; // On ne peut pas aller plus loin
                }            
                Res = Res - (Fidelite * Res / 100.0);
            }

            if (chkDeducJeune.Checked)
            {
                if (!int.TryParse(txtDeducJeune.Text, out Jeune))
                {
                    MessageBox.Show("Introduisez un montant entier correct");
                    txtDeducJeune.Focus(); // On place le curseur là où l'info manque
                    return; // On ne peut pas aller plus loin
                }
                Res = Res - Jeune;
            }

            if (chkDeducTrans.Checked)
            {
                if (!int.TryParse(txtDeducTrans.Text, out Transport))
                {
                    MessageBox.Show("Introduisez un montant entier correct");
                    txtDeducTrans.Focus(); // On place le curseur là où l'info manque
                    return; // On ne peut pas aller plus loin
                }
                Res = Res - Transport;
            }           

            // Affichage du résultat
            lblRevenuImposable.Text = "Revenu imposable: " + Res.ToString("C2");
        }

        private void txtBrut_TextChanged(object sender, EventArgs e)
        {
            Calcul();
        }

        private void txtCoeff_TextChanged(object sender, EventArgs e)
        {
            Calcul();
        }

        private void txtDeducJeune_TextChanged(object sender, EventArgs e)
        {
            Calcul();
        }

        private void txtDeducTrans_TextChanged(object sender, EventArgs e)
        {
            Calcul();
        }

        private void txtRabais_TextChanged(object sender, EventArgs e)
        {
            Calcul();
        }

        private void cmdCalcul_Click(object sender, EventArgs e)
        {
            Calcul();
        }
    }
}
