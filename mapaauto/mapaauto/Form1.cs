using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mapaauto
{
    public partial class Osoba : Form
    {
        public Osoba()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clovek jedna = new Clovek(textBox1.Text, maskedTextBox1.Text);
            Clovek dva = new Clovek(textBox4.Text, maskedTextBox2.Text);

            MessageBox.Show(jedna.ToString());
            MessageBox.Show(dva.ToString());

            dva.NastavJmeno("Hynek");

            MessageBox.Show("Změna jména na: " + dva.VypisJmeno());

            MessageBox.Show(jedna.Starsi(dva));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
