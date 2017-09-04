namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wstawDatęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znajdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znajdźNastępnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liczbaZnakówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażLzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schowajLzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liczbaLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażLlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.schowajLlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zawijajTekstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorTłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liczbaznakow = new System.Windows.Forms.Label();
            this.liczbalinii = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(292, 249);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.czcionkaToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.wyjścieToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            this.plikToolStripMenuItem.Click += new System.EventHandler(this.plikToolStripMenuItem_Click);
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.kopiujToolStripMenuItem,
            this.wytnijToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.wstawDatęToolStripMenuItem,
            this.zaznaczWszystkoToolStripMenuItem,
            this.znajdźToolStripMenuItem,
            this.znajdźNastępnyToolStripMenuItem,
            this.zamienToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            this.edycjaToolStripMenuItem.Click += new System.EventHandler(this.edycjaToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.undoToolStripMenuItem.Text = "<-Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.redoToolStripMenuItem.Text = "Redo->";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // wstawDatęToolStripMenuItem
            // 
            this.wstawDatęToolStripMenuItem.Name = "wstawDatęToolStripMenuItem";
            this.wstawDatęToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.wstawDatęToolStripMenuItem.Text = "Wstaw datę";
            this.wstawDatęToolStripMenuItem.Click += new System.EventHandler(this.wstawDatęToolStripMenuItem_Click);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // znajdźToolStripMenuItem
            // 
            this.znajdźToolStripMenuItem.Name = "znajdźToolStripMenuItem";
            this.znajdźToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.znajdźToolStripMenuItem.Text = "Znajdź";
            this.znajdźToolStripMenuItem.Click += new System.EventHandler(this.znajdźToolStripMenuItem_Click);
            // 
            // znajdźNastępnyToolStripMenuItem
            // 
            this.znajdźNastępnyToolStripMenuItem.Name = "znajdźNastępnyToolStripMenuItem";
            this.znajdźNastępnyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.znajdźNastępnyToolStripMenuItem.Text = "Znajdź następny";
            this.znajdźNastępnyToolStripMenuItem.Click += new System.EventHandler(this.znajdźNastępnyToolStripMenuItem_Click);
            // 
            // zamienToolStripMenuItem
            // 
            this.zamienToolStripMenuItem.Name = "zamienToolStripMenuItem";
            this.zamienToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.zamienToolStripMenuItem.Text = "Zamien";
            this.zamienToolStripMenuItem.Click += new System.EventHandler(this.zamienToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.Checked = true;
            this.widokToolStripMenuItem.CheckOnClick = true;
            this.widokToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liczbaZnakówToolStripMenuItem,
            this.liczbaLiniiToolStripMenuItem,
            this.zawijajTekstToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // liczbaZnakówToolStripMenuItem
            // 
            this.liczbaZnakówToolStripMenuItem.CheckOnClick = true;
            this.liczbaZnakówToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażLzToolStripMenuItem,
            this.schowajLzToolStripMenuItem});
            this.liczbaZnakówToolStripMenuItem.Name = "liczbaZnakówToolStripMenuItem";
            this.liczbaZnakówToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.liczbaZnakówToolStripMenuItem.Text = "Liczba znaków";
            this.liczbaZnakówToolStripMenuItem.CheckedChanged += new System.EventHandler(this.liczbaZnakówToolStripMenuItem_CheckedChanged);
            this.liczbaZnakówToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.liczbaZnakówToolStripMenuItem_CheckedChanged);
            this.liczbaZnakówToolStripMenuItem.Click += new System.EventHandler(this.liczbaZnakówToolStripMenuItem_Click);
            // 
            // pokażLzToolStripMenuItem
            // 
            this.pokażLzToolStripMenuItem.Name = "pokażLzToolStripMenuItem";
            this.pokażLzToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.pokażLzToolStripMenuItem.Text = "pokaż";
            this.pokażLzToolStripMenuItem.Click += new System.EventHandler(this.pokażToolStripMenuItem_Click);
            // 
            // schowajLzToolStripMenuItem
            // 
            this.schowajLzToolStripMenuItem.Name = "schowajLzToolStripMenuItem";
            this.schowajLzToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.schowajLzToolStripMenuItem.Text = "schowaj";
            this.schowajLzToolStripMenuItem.Click += new System.EventHandler(this.schowajToolStripMenuItem_Click);
            // 
            // liczbaLiniiToolStripMenuItem
            // 
            this.liczbaLiniiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażLlToolStripMenuItem1,
            this.schowajLlToolStripMenuItem1});
            this.liczbaLiniiToolStripMenuItem.Name = "liczbaLiniiToolStripMenuItem";
            this.liczbaLiniiToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.liczbaLiniiToolStripMenuItem.Text = "Liczba linii";
            this.liczbaLiniiToolStripMenuItem.Click += new System.EventHandler(this.liczbaLiniiToolStripMenuItem_Click);
            // 
            // pokażLlToolStripMenuItem1
            // 
            this.pokażLlToolStripMenuItem1.Name = "pokażLlToolStripMenuItem1";
            this.pokażLlToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.pokażLlToolStripMenuItem1.Text = "pokaż";
            this.pokażLlToolStripMenuItem1.Click += new System.EventHandler(this.pokażToolStripMenuItem1_Click);
            // 
            // schowajLlToolStripMenuItem1
            // 
            this.schowajLlToolStripMenuItem1.Name = "schowajLlToolStripMenuItem1";
            this.schowajLlToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.schowajLlToolStripMenuItem1.Text = "schowaj";
            this.schowajLlToolStripMenuItem1.Click += new System.EventHandler(this.schowajToolStripMenuItem1_Click);
            // 
            // zawijajTekstToolStripMenuItem
            // 
            this.zawijajTekstToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem});
            this.zawijajTekstToolStripMenuItem.Name = "zawijajTekstToolStripMenuItem";
            this.zawijajTekstToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.zawijajTekstToolStripMenuItem.Text = "Zawijaj tekst";
            this.zawijajTekstToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.zawijajTekstToolStripMenuItem_CheckStateChanged);
            this.zawijajTekstToolStripMenuItem.Click += new System.EventHandler(this.zawijajTekstToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aToolStripMenuItem.Text = "zawijaj";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.bToolStripMenuItem.Text = "nie zawijaj";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorCzcionkiToolStripMenuItem,
            this.kolorTłaToolStripMenuItem});
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            // 
            // kolorCzcionkiToolStripMenuItem
            // 
            this.kolorCzcionkiToolStripMenuItem.Name = "kolorCzcionkiToolStripMenuItem";
            this.kolorCzcionkiToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.kolorCzcionkiToolStripMenuItem.Text = "Kolor czcionki";
            this.kolorCzcionkiToolStripMenuItem.Click += new System.EventHandler(this.kolorCzcionkiToolStripMenuItem_Click);
            // 
            // kolorTłaToolStripMenuItem
            // 
            this.kolorTłaToolStripMenuItem.Name = "kolorTłaToolStripMenuItem";
            this.kolorTłaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.kolorTłaToolStripMenuItem.Text = "Kolor tła";
            this.kolorTłaToolStripMenuItem.Click += new System.EventHandler(this.kolorTłaToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // liczbaznakow
            // 
            this.liczbaznakow.AutoSize = true;
            this.liczbaznakow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.liczbaznakow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.liczbaznakow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.liczbaznakow.Location = new System.Drawing.Point(0, 258);
            this.liczbaznakow.Name = "liczbaznakow";
            this.liczbaznakow.Size = new System.Drawing.Size(15, 15);
            this.liczbaznakow.TabIndex = 2;
            this.liczbaznakow.Text = "0";
            this.liczbaznakow.Click += new System.EventHandler(this.liczbaznakow_Click);
            // 
            // liczbalinii
            // 
            this.liczbalinii.AutoSize = true;
            this.liczbalinii.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.liczbalinii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.liczbalinii.CausesValidation = false;
            this.liczbalinii.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.liczbalinii.Location = new System.Drawing.Point(0, 243);
            this.liczbalinii.Name = "liczbalinii";
            this.liczbalinii.Size = new System.Drawing.Size(15, 15);
            this.liczbalinii.TabIndex = 3;
            this.liczbalinii.Text = "0";
            this.liczbalinii.Click += new System.EventHandler(this.liczbalinii_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.liczbalinii);
            this.Controls.Add(this.liczbaznakow);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorCzcionkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorTłaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label liczbaznakow;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liczbaZnakówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażLzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schowajLzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zawijajTekstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wstawDatęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.Label liczbalinii;
        private System.Windows.Forms.ToolStripMenuItem liczbaLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażLlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem schowajLlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem znajdźToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem znajdźNastępnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamienToolStripMenuItem;
    }
}

