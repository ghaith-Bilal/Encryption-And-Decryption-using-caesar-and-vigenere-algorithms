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
    public partial class VigenereDecryption : Form
    {
        public VigenereDecryption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = VigenereCipher.Decryption(textBox1.Text, textBox2.Text);
        }
    }
}
