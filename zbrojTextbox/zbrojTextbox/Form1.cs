using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zbrojTextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int prvi = 0;
            int drugi = 0;

            if (int.TryParse(textBox1.Text, out prvi))
            {

                if (int.TryParse(textBox2.Text, out drugi))
                {
                    MessageBox.Show("Rezultat je  " + (prvi + drugi));
                }
                else
                {
                    MessageBox.Show("Morate upisati broj");
                }
            }
            else
            {
                MessageBox.Show("Morate upisati broj");
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
