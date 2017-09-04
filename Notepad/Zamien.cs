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
    public partial class Zamien : Form
    {
        public Zamien()
        {
            InitializeComponent();

            /*if (Form1.SzukanyTekst != "")
            { textBox1.Text = Form1.SzukanyTekst; } */ // -do dopracowania
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.SzukanyTekst = textBox1.Text;
            Form1.ZmienionyTekst = textBox2.Text;
            this.Close();

        }

        private void Zamien_Load(object sender, EventArgs e)
        {

        }
    }
}
