using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoSecProject
{
    public partial class VigenereEncryption : Form
    {
        public VigenereEncryption()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = VigenereCipher.Encryption(textBox1.Text, textBox2.Text);
        }

        private void VigenereEncryption_Load(object sender, EventArgs e)
        {

        }
    }
}
