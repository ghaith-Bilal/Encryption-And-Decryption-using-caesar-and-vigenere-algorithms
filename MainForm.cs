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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CaesarEncryption newform = new CaesarEncryption();
            newform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VigenereEncryption newform = new VigenereEncryption();
            newform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VigenereDecryption newform = new VigenereDecryption();
            newform.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CaesarDecryption newform = new CaesarDecryption();
            newform.Show();
        }
    }
}
