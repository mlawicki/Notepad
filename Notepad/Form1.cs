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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            liczbaznakow.Text = richTextBox1.Text.Length.ToString();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog otworz = new OpenFileDialog();
            if(otworz.ShowDialog() == DialogResult.OK);
                richTextBox1.LoadFile(otworz.FileName, RichTextBoxStreamType.PlainText);
            this.Text = otworz.FileName;
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog zapisz = new SaveFileDialog();
            zapisz.Filter = "Dokument tekstowy(*.txt)|*.txt|Wszystkie pliki|*.*";
            if (zapisz.ShowDialog() == DialogResult.OK) richTextBox1.SaveFile(zapisz.FileName, RichTextBoxStreamType.PlainText);
            this.Text = zapisz.FileName;
        }

        private void edycjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void kolorCzcionkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialogczcionki = new FontDialog(); dialogczcionki.Font = richTextBox1.SelectionFont;
            if (dialogczcionki.ShowDialog() == DialogResult.OK) { richTextBox1.SelectionFont = dialogczcionki.Font; }
        }

        private void kolorTłaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialogkoloru = new ColorDialog();
            if (dialogkoloru.ShowDialog() == DialogResult.OK) { richTextBox1.BackColor = dialogkoloru.Color; }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("by mlawicki \n github.com/mlawicki");

        }

        private void liczbaZnakówToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* if (liczbaZnakówToolStripMenuItem.Checked = false)
                liczbaznakow.Visible = false;
            else
                liczbaznakow.Visible = true;  */
                // do udoskonalenia
        }
    }
}
