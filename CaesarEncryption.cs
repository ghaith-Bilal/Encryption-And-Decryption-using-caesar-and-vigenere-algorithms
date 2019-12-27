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
    public partial class CaesarEncryption : Form
    {
        public CaesarEncryption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = CaesarCipher.Encryption(textBox1.Text, int.Parse(textBox2.Text));
        }
    }
}
