using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arche_de_noe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmdMove2.Enabled = false;
        }

        private void cmdMove_Click(object sender, EventArgs e)
        {
            

            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("bra");
            else
            {
                listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
                listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
            }

            if (listBox2.Items.Count > 0)
                cmdMove2.Enabled = true;

            if (listBox1.Items.Count == 0)
                cmdMove.Enabled = false;
        }

        private void cmdMove2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
                MessageBox.Show("bra");
            else
            {
                listBox1.Items.Add(listBox2.Items[listBox2.SelectedIndex]);
                listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndex]);
            }

            if (listBox2.Items.Count == 0)
                cmdMove2.Enabled = false;

            if (listBox1.Items.Count > 0)
                cmdMove.Enabled = true;


        }
    }
}
