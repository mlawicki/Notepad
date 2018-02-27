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
        public static string SzukanyTekst;
        public static string ZmienionyTekst;
        public static Boolean rozrozniajwielkoscliter;
        int d;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            liczbaZnakowLabel1.Text = richTextBox1.Text.Length.ToString();
           var lineCount = richTextBox1.Lines.Count();
            liczbaLiniiLabel1.Text = lineCount.ToString();      

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
            System.Windows.Forms.MessageBox.Show("Notepad v.0.5. \n by mlawicki \n github.com/mlawicki");

        }

        private void liczbaZnakówToolStripMenuItem_Click(object sender, EventArgs e)
        {




         
        }

        private void liczbaznakow_Click(object sender, EventArgs e)
        {
            liczbaZnakowLabel1.Visible = false;
        }

        private void liczbaZnakówToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (liczbaZnakówToolStripMenuItem.Checked = false)
                liczbaZnakowLabel1.Visible = false;
        }

        private void pokażToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liczbaZnakowLabel1.Visible = true;
        }

        private void schowajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liczbaZnakowLabel1.Visible = false;
        }

        private void zawijajTekstToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {


        }

        private void zawijajTekstToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = true;
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
        }

        private void wstawDatęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now.ToString();
            richTextBox1.Select(richTextBox1.Text.Length + 1, 0);
            richTextBox1.ScrollToCaret();
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void liczbalinii_Click(object sender, EventArgs e)
        {
            liczbaLiniiLabel1.Visible = false;
        }

        private void pokażToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            liczbaLiniiLabel1.Visible = true;

        }

        private void schowajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            liczbaLiniiLabel1.Visible = false;
        }

        private void znajdźToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Znajdz r = new Znajdz();
            r.ShowDialog();

            if (SzukanyTekst != "")
            {

                    d = richTextBox1.Find(SzukanyTekst);

            }



        }

        private void znajdźNastępnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SzukanyTekst != "")
            {
                if (rozrozniajwielkoscliter == true)
                {
                    d = richTextBox1.Find(SzukanyTekst, d + 1, RichTextBoxFinds.MatchCase);
                }
                else
                {
                    d = richTextBox1.Find(SzukanyTekst, d + 1, RichTextBoxFinds.None);
                }
            }
        }
        private void liczbaLiniiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz wyjść?", "Wyjście", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void zamienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zamien r = new Zamien();
            r.ShowDialog();
            richTextBox1.Find(SzukanyTekst);
            richTextBox1.SelectedText = ZmienionyTekst;
        }

        private void liczbaZnakowLabel1_Click(object sender, EventArgs e)
        {
            liczbaZnakowLabel1.Visible = false;
        }

        private void liczbaLiniiLabel1_Click(object sender, EventArgs e)
        {
            liczbaLiniiLabel1.Visible = false;
        }
    }
}
