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
    public partial class FrmBonjourQui : Form
    {
        public FrmBonjourQui()
        {
            InitializeComponent();
            cmdBienvenue.Enabled = false;
        }

        private void cmdBienvenue_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Bonjour " + txtNom.Text;
            cmdBienvenue.Enabled = false;
            txtNom.Text = null;
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmdBienvenue.Enabled = true;
            Console.Write(e.KeyChar+"\n");
        
        }
                
        private void cmdBienvenue_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Que des clics!");
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void k(object sender, EventArgs e)
        {

        }
    }
}
