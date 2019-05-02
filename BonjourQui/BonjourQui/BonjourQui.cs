using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BonjourQui
{
    public partial class BonjourQui : Form
    {
        public BonjourQui()
        {
            InitializeComponent();
            cmdBienvenue.Enabled = false;
        }
       

        private void cmdBienvenue_Click(object sender, EventArgs e)
        {
            lblBonjour.Text = "Bienvenue " + txtNom.Text;
            txtNom.Text = null;
            cmdBienvenue.Enabled = false;
        }

        private void txtNom_TextChanged_1(object sender, EventArgs e)
        {
            cmdBienvenue.Enabled = true;
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
