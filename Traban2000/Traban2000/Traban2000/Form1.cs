using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Traban2000
{
    public partial class Form1 : Form
    {

        double PrixBase;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdTotal_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(txtPrixBase.Text, out PrixBase))
            {
                MessageBox.Show("NON");
                return;
            }



            txtTotal.Text = PrixBase.ToString() + ;
        }
    }
}
