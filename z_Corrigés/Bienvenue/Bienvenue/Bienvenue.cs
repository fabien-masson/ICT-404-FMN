using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bienvenue
{
    public partial class frmBienvenue : Form
    {
        public frmBienvenue()
        {
            InitializeComponent();
        }

        private void frmBienvenue_Load(object sender, EventArgs e)
        {
            lblBienvenueDate.Text = string.Format ("{0:dd MMM yyyy}",DateTime.Now);
        }

        private void cmFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblBienvenueDate_Click(object sender, EventArgs e)
        {

        }
    }
}
