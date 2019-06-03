using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculette
{
    public partial class frmCalculate : Form
    {
        float resultat;
        float num1;
        float num2;
        public frmCalculate()
        {
            InitializeComponent();
        }

        private void CmdCalcul_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Introduisez un numéro");
                txtNum1.Focus();
                return;
            }

            if (!float.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Introduisez un numéro");
                txtNum2.Focus();
                return;
            }


            if (optPlus.Checked == true)
            {
                resultat = num1 + num2;
            }
             
            if (optMoin.Checked == true)
            {
                resultat = num1 - num2;
            }

            if (optMult.Checked == true)
            {
                resultat = num1 * num2;
            }

            if (optDiv.Checked == true)
            {
                resultat = num1 / num2;
            }

            lblResultat2.Text = resultat.ToString("c2");

        }
    }
}
