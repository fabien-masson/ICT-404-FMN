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
    public partial class Déductions : Form
    {
        double Res;
        double Brut;
        double Coeff;
        double Jeunes;
        double Transports;
        double Fidelite;


        public Déductions()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCalcul_Click(object sender, EventArgs e)
        {


            if (!double.TryParse(txtBox1.Text, out Brut))
            {
                MessageBox.Show("Introduisez un revenu brut valable");
                txtBox1.Focus();
                return;
            }

            if (!double.TryParse(txtBox2.Text, out Coeff))
            {
                MessageBox.Show("Introduisez un coefficient familial valable");
                txtBox2.Focus();
                return;
            }


            if (chkDéductionJeunes.Checked == true) {
                if (!double.TryParse(txtBox3.Text, out Jeunes))
                {
                    MessageBox.Show("Introduisez une deduction jeune valable");
                    txtBox3.Focus();
                    return;
                }
            }


            if (chkDéductionTransports.Checked == true)
            {
                if (!double.TryParse(txtBox4.Text, out Transports))
                {
                    MessageBox.Show("Introduisez une deduction transports valable");
                    txtBox4.Focus();
                    return;
                }
            }


            if (chkRabaisFidélité.Checked == true)
            {
                if (!double.TryParse(txtBox5.Text, out Fidelite))
                {
                    MessageBox.Show("Introduisez un rabais fidélité valable");
                    txtBox5.Focus();
                    return;
                }
            }




            Brut = double.Parse(txtBox1.Text);
            Coeff = double.Parse(txtBox2.Text);
           // Jeunes = double.Parse(txtBox3.Text);
           // Transports = double.Parse(txtBox4.Text);
           // Fidelite = double.Parse(txtBox5.Text);
            if (chkDéductionJeunes.Checked == true) { Jeunes = double.Parse(txtBox3.Text); }
            if (chkDéductionTransports.Checked == true) { Transports = double.Parse(txtBox4.Text); }
            if (chkRabaisFidélité.Checked == true) { Fidelite = double.Parse(txtBox5.Text); }






            Res = Brut / Coeff;

            if (chkDéductionJeunes.Checked == true) { Res = Res - Jeunes; }
            if (chkDéductionTransports.Checked == true) { Res = Res - Transports; }
            if (chkRabaisFidélité.Checked == true) { Res = Res-Res/100 * Fidelite; }

            lblRevenu.Text = "Revenu imposable: fr. " + Res.ToString("c2");
            

        }


    }
}
