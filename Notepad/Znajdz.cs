using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Znajdz : Form
    {
        public Znajdz()
        {
            InitializeComponent();
        }

        private void Znajdz_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                Form1.rozrozniajwielkoscliter = true;
            }
            else
            {
                Form1.rozrozniajwielkoscliter = false;
            }

            Form1.SzukanyTekst = textBox1.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.SzukanyTekst = "";
            this.Close();
        }
    }
}
