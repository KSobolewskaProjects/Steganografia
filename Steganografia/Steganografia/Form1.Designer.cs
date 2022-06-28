
namespace Steganografia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdOknoDialogowe = new System.Windows.Forms.OpenFileDialog();
            this.btnZaladujPlik = new System.Windows.Forms.Button();
            this.lblZaladowaneZdjecie = new System.Windows.Forms.Label();
            this.lblWprowadzTekst = new System.Windows.Forms.Label();
            this.tbWprowadzanyTekst = new System.Windows.Forms.RichTextBox();
            this.btnUkryjTekst = new System.Windows.Forms.Button();
            this.tabUkryj = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblGdzieZapisanoZmieniony = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOdczytajWiadomosc = new System.Windows.Forms.Button();
            this.tbDaneWyjsciowe = new System.Windows.Forms.RichTextBox();
            this.lblSciezkaZmienione = new System.Windows.Forms.Label();
            this.btnWybierzZmienione = new System.Windows.Forms.Button();
            this.lblSciezkaOrginal = new System.Windows.Forms.Label();
            this.btnWybierzOrginal = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabUkryj.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdOknoDialogowe
            // 
            this.ofdOknoDialogowe.FileName = "doukrycia";
            this.ofdOknoDialogowe.Title = "Wybierz zdjęcie";
            // 
            // btnZaladujPlik
            // 
            this.btnZaladujPlik.Location = new System.Drawing.Point(20, 17);
            this.btnZaladujPlik.Name = "btnZaladujPlik";
            this.btnZaladujPlik.Size = new System.Drawing.Size(200, 30);
            this.btnZaladujPlik.TabIndex = 0;
            this.btnZaladujPlik.Text = "Załaduj zdjęcie";
            this.btnZaladujPlik.UseVisualStyleBackColor = true;
            this.btnZaladujPlik.Click += new System.EventHandler(this.przyciskZaladujPlik_Click);
            // 
            // lblZaladowaneZdjecie
            // 
            this.lblZaladowaneZdjecie.AutoSize = true;
            this.lblZaladowaneZdjecie.Location = new System.Drawing.Point(274, 25);
            this.lblZaladowaneZdjecie.Name = "lblZaladowaneZdjecie";
            this.lblZaladowaneZdjecie.Size = new System.Drawing.Size(93, 15);
            this.lblZaladowaneZdjecie.TabIndex = 2;
            this.lblZaladowaneZdjecie.Text = "Wybrane zdjęcie";
            this.lblZaladowaneZdjecie.Visible = false;
            // 
            // lblWprowadzTekst
            // 
            this.lblWprowadzTekst.AutoSize = true;
            this.lblWprowadzTekst.Location = new System.Drawing.Point(41, 85);
            this.lblWprowadzTekst.Name = "lblWprowadzTekst";
            this.lblWprowadzTekst.Size = new System.Drawing.Size(149, 15);
            this.lblWprowadzTekst.TabIndex = 3;
            this.lblWprowadzTekst.Text = "Wprowadz tekst do ukrycia";
            this.lblWprowadzTekst.Visible = false;
            // 
            // tbWprowadzanyTekst
            // 
            this.tbWprowadzanyTekst.Location = new System.Drawing.Point(274, 85);
            this.tbWprowadzanyTekst.Name = "tbWprowadzanyTekst";
            this.tbWprowadzanyTekst.Size = new System.Drawing.Size(236, 200);
            this.tbWprowadzanyTekst.TabIndex = 4;
            this.tbWprowadzanyTekst.Text = "";
            this.tbWprowadzanyTekst.Visible = false;
            // 
            // btnUkryjTekst
            // 
            this.btnUkryjTekst.Location = new System.Drawing.Point(79, 306);
            this.btnUkryjTekst.Name = "btnUkryjTekst";
            this.btnUkryjTekst.Size = new System.Drawing.Size(75, 23);
            this.btnUkryjTekst.TabIndex = 5;
            this.btnUkryjTekst.Text = "Ukryj tekst";
            this.btnUkryjTekst.UseVisualStyleBackColor = true;
            this.btnUkryjTekst.Visible = false;
            this.btnUkryjTekst.Click += new System.EventHandler(this.btnUkryjTekst_Click);
            // 
            // tabUkryj
            // 
            this.tabUkryj.Controls.Add(this.tabPage1);
            this.tabUkryj.Controls.Add(this.tabPage2);
            this.tabUkryj.Location = new System.Drawing.Point(2, 3);
            this.tabUkryj.Name = "tabUkryj";
            this.tabUkryj.SelectedIndex = 0;
            this.tabUkryj.Size = new System.Drawing.Size(624, 559);
            this.tabUkryj.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblGdzieZapisanoZmieniony);
            this.tabPage1.Controls.Add(this.btnZaladujPlik);
            this.tabPage1.Controls.Add(this.lblWprowadzTekst);
            this.tabPage1.Controls.Add(this.btnUkryjTekst);
            this.tabPage1.Controls.Add(this.tbWprowadzanyTekst);
            this.tabPage1.Controls.Add(this.lblZaladowaneZdjecie);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ukryj";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblGdzieZapisanoZmieniony
            // 
            this.lblGdzieZapisanoZmieniony.AutoSize = true;
            this.lblGdzieZapisanoZmieniony.Location = new System.Drawing.Point(20, 360);
            this.lblGdzieZapisanoZmieniony.Name = "lblGdzieZapisanoZmieniony";
            this.lblGdzieZapisanoZmieniony.Size = new System.Drawing.Size(179, 15);
            this.lblGdzieZapisanoZmieniony.TabIndex = 6;
            this.lblGdzieZapisanoZmieniony.Text = "Ścieżka zapisanego zmienionego";
            this.lblGdzieZapisanoZmieniony.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnOdczytajWiadomosc);
            this.tabPage2.Controls.Add(this.tbDaneWyjsciowe);
            this.tabPage2.Controls.Add(this.lblSciezkaZmienione);
            this.tabPage2.Controls.Add(this.btnWybierzZmienione);
            this.tabPage2.Controls.Add(this.lblSciezkaOrginal);
            this.tabPage2.Controls.Add(this.btnWybierzOrginal);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Odczytaj";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOdczytajWiadomosc
            // 
            this.btnOdczytajWiadomosc.Location = new System.Drawing.Point(30, 140);
            this.btnOdczytajWiadomosc.Name = "btnOdczytajWiadomosc";
            this.btnOdczytajWiadomosc.Size = new System.Drawing.Size(173, 23);
            this.btnOdczytajWiadomosc.TabIndex = 5;
            this.btnOdczytajWiadomosc.Text = "Odczytaj ukrytą wiadomość";
            this.btnOdczytajWiadomosc.UseVisualStyleBackColor = true;
            this.btnOdczytajWiadomosc.Click += new System.EventHandler(this.btnOdczytajWiadomosc_Click);
            // 
            // tbDaneWyjsciowe
            // 
            this.tbDaneWyjsciowe.Enabled = false;
            this.tbDaneWyjsciowe.Location = new System.Drawing.Point(27, 168);
            this.tbDaneWyjsciowe.Name = "tbDaneWyjsciowe";
            this.tbDaneWyjsciowe.Size = new System.Drawing.Size(553, 350);
            this.tbDaneWyjsciowe.TabIndex = 4;
            this.tbDaneWyjsciowe.Text = "";
            // 
            // lblSciezkaZmienione
            // 
            this.lblSciezkaZmienione.AutoSize = true;
            this.lblSciezkaZmienione.Location = new System.Drawing.Point(250, 85);
            this.lblSciezkaZmienione.Name = "lblSciezkaZmienione";
            this.lblSciezkaZmienione.Size = new System.Drawing.Size(0, 15);
            this.lblSciezkaZmienione.TabIndex = 3;
            // 
            // btnWybierzZmienione
            // 
            this.btnWybierzZmienione.Location = new System.Drawing.Point(30, 80);
            this.btnWybierzZmienione.Name = "btnWybierzZmienione";
            this.btnWybierzZmienione.Size = new System.Drawing.Size(173, 23);
            this.btnWybierzZmienione.TabIndex = 1;
            this.btnWybierzZmienione.Text = "Wybierz zmienione zdjęcie";
            this.btnWybierzZmienione.UseVisualStyleBackColor = true;
            this.btnWybierzZmienione.Click += new System.EventHandler(this.btnWybierzZmienione_Click);
            // 
            // lblSciezkaOrginal
            // 
            this.lblSciezkaOrginal.AutoSize = true;
            this.lblSciezkaOrginal.Location = new System.Drawing.Point(250, 25);
            this.lblSciezkaOrginal.Name = "lblSciezkaOrginal";
            this.lblSciezkaOrginal.Size = new System.Drawing.Size(0, 15);
            this.lblSciezkaOrginal.TabIndex = 2;
            // 
            // btnWybierzOrginal
            // 
            this.btnWybierzOrginal.Location = new System.Drawing.Point(30, 20);
            this.btnWybierzOrginal.Name = "btnWybierzOrginal";
            this.btnWybierzOrginal.Size = new System.Drawing.Size(173, 23);
            this.btnWybierzOrginal.TabIndex = 0;
            this.btnWybierzOrginal.Text = "Wybierz orginalne zdjecie ";
            this.btnWybierzOrginal.UseVisualStyleBackColor = true;
            this.btnWybierzOrginal.Click += new System.EventHandler(this.btnWybierzOrginal_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "doukrycia";
            this.openFileDialog1.Title = "Wybierz zdjęcie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 574);
            this.Controls.Add(this.tabUkryj);
            this.Name = "Form1";
            this.Text = "Steganografia by Karolina Sobolewska";
            this.tabUkryj.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOknoDialogowe;
        private System.Windows.Forms.Button btnZaladujPlik;
        private System.Windows.Forms.Label lblZaladowaneZdjecie;
        private System.Windows.Forms.Label lblWprowadzTekst;
        private System.Windows.Forms.RichTextBox tbWprowadzanyTekst;
        private System.Windows.Forms.Button btnUkryjTekst;
        private System.Windows.Forms.TabControl tabUkryj;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSciezkaZmienione;
        private System.Windows.Forms.Button btnWybierzZmienione;
        private System.Windows.Forms.Label lblSciezkaOrginal;
        private System.Windows.Forms.Button btnWybierzOrginal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox tbDaneWyjsciowe;
        private System.Windows.Forms.Label lblGdzieZapisanoZmieniony;
        private System.Windows.Forms.Button btnOdczytajWiadomosc;
    }
}

