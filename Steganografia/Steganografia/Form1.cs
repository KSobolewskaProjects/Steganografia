using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Steganografia
{
    public partial class Form1 : Form
    {
        OpenFileDialog oknoDialogowe = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void przyciskZaladujPlik_Click(object sender, EventArgs e)
        {
            //ustawienia okna dialogowego
            oknoDialogowe.InitialDirectory = @"C:\Users\user\Desktop";
            oknoDialogowe.Filter = "All files (*.*)|*.*";
            oknoDialogowe.ShowDialog();
            //instrukcje do wykonania po załadowaniu tekstu
            if (oknoDialogowe.FileName != "")
            {
                //zmiana ustawień przycisków
                lblZaladowaneZdjecie.Visible = true;
                lblZaladowaneZdjecie.Text = oknoDialogowe.FileName;
                lblWprowadzTekst.Visible = true;
                tbWprowadzanyTekst.Visible = true;
                btnUkryjTekst.Visible = true;

            }
            else
            {
                //informacje o braku wyboru obrazka
                lblZaladowaneZdjecie.Text = "Nie masz wybranego zdjęcia";
            }
        }

        private void btnUkryjTekst_Click(object sender, EventArgs e)
        {

            //bitmapa z wybranego obrazka
            Bitmap obrazek = new Bitmap(oknoDialogowe.FileName);
            //sprawdzenie czy wprowadzony tekst nie jest za długi
            if (tbWprowadzanyTekst.Text.Length < (obrazek.Width * obrazek.Height / 2))
            {
                //zmiana widoczności przycisków
                btnZaladujPlik.Enabled = false;
                tbWprowadzanyTekst.Enabled = false;
                btnUkryjTekst.Enabled = false;
                //zmiana tekstu na bin
                StringBuilder sb = new StringBuilder();
                foreach (char litera in tbWprowadzanyTekst.Text.ToCharArray())
                {
                    sb.Append(Convert.ToString(litera, 2).PadLeft(8, '0'));
                }
                String tekstWZeroJedynkach = Convert.ToString(sb);

                //licznik znaków potrzebny do przejścia stringa
                int licznik = 0;
                byte odejmijOdA = 0;
                byte odejmijOdR = 0;
                byte odejmijOdG = 0;
                byte odejmijOdB = 0;

                //for do przechodzenia po każdym pikselu
                for (int i = 0; i < obrazek.Width - 1; i++)
                {
                    for (int j = 0; j < obrazek.Height - 1; j++)
                    {
                        //pobierz kolor pixela z obrazka
                        Color pixel = obrazek.GetPixel(j, i);
                        switch (tekstWZeroJedynkach.Length)
                        {

                            case 0:
                                break;

                            case 1:
                                if (tekstWZeroJedynkach[licznik].Equals('1')) { odejmijOdA++; }
                                tekstWZeroJedynkach = tekstWZeroJedynkach.Substring(1);
                                break;

                            case 2:
                                if (tekstWZeroJedynkach[licznik].Equals('1')) { odejmijOdA++; }
                                if (tekstWZeroJedynkach[licznik + 1].Equals('1')) { odejmijOdR++; }
                                tekstWZeroJedynkach = tekstWZeroJedynkach.Substring(2);
                                break;

                            case 3:
                                if (tekstWZeroJedynkach[licznik].Equals('1')) { odejmijOdA++; }
                                if (tekstWZeroJedynkach[licznik + 1].Equals('1')) { odejmijOdR++; }
                                if (tekstWZeroJedynkach[licznik + 2].Equals('1')) { odejmijOdG++; }
                                tekstWZeroJedynkach = tekstWZeroJedynkach.Substring(3);
                                break;

                            default:
                                if (tekstWZeroJedynkach[licznik].Equals('1')) { odejmijOdA++; }
                                if (tekstWZeroJedynkach[licznik + 1].Equals('1')) { odejmijOdR++; }
                                if (tekstWZeroJedynkach[licznik + 2].Equals('1')) { odejmijOdG++; }
                                if (tekstWZeroJedynkach[licznik + 3].Equals('1')) { odejmijOdB++; }
                                tekstWZeroJedynkach = tekstWZeroJedynkach.Substring(4);
                                break;
                        }

                        //ustaw kolor zgodnie z przesunięciem z prowadzanego tekstu
                        Color pixelNowy = Color.FromArgb(pixel.A - odejmijOdA, pixel.R - odejmijOdR, pixel.G - odejmijOdG, pixel.B - odejmijOdB);
                        //zmień kolor piksela na wybranym obrazku
                        obrazek.SetPixel(j, i, pixelNowy);
                        //zerowanie zmiennych
                        odejmijOdA = odejmijOdB = odejmijOdG = odejmijOdR = 0;
                    }
                }
                //zapisywanie obrazka 
                obrazek.Save(@"C:\Users\user\Desktop\ukryte.jpg");
                //informacja gdzie znajdziemy zmieniony plik
                lblGdzieZapisanoZmieniony.Visible = true;
                //informacja gdzie znajdziemy zmieniony obrazek
                lblGdzieZapisanoZmieniony.Text = "Obrazek, z ukrytym w nim tekstem, znajdziesz " + @"C:\Users\user\Desktop\ukryte.jpg";
            }
            else { MessageBox.Show("Wprowadzony tekst jest za długi"); tbWprowadzanyTekst.Text = ""; }
        }

        private void btnWybierzOrginal_Click(object sender, EventArgs e)
        {
            //ustawienia okna dialogowego
            oknoDialogowe.InitialDirectory = @"C:\Users\user\Desktop";
            oknoDialogowe.Filter = "All files (*.*)|*.*";
            oknoDialogowe.ShowDialog();
            //sprawdzanie czy wybrano jakieś zdjęcie
            if (oknoDialogowe.FileName != "")
            {
                //wyświetlenie ścieżki wybranego zdjęcia
                lblSciezkaOrginal.Text = oknoDialogowe.FileName;                
            }
            else
            {
                //informacje o braku wyboru obrazka
                lblSciezkaOrginal.Text = "Nie masz wybranego zdjęcia";
            }            
        }
        

        private void btnWybierzZmienione_Click(object sender, EventArgs e)
        {
            //ustawienia okna dialogowego
            oknoDialogowe.InitialDirectory = @"C:\Users\user\Desktop";
            oknoDialogowe.Filter = "All files (*.*)|*.*";
            oknoDialogowe.ShowDialog();
            //sprawdzanie czy wybrano jakieś zdjęcie
            if (oknoDialogowe.FileName != "")
            {
                //wyświetlenie ścieżki wybranego zdjęcia
                lblSciezkaZmienione.Text = oknoDialogowe.FileName;
            }
            else
            {
                //informacje o braku wyboru obrazka
                lblSciezkaZmienione.Text = "Nie masz wybranego zdjęcia";
            }
        }
        //funkcja do zmiany z zapisu bin na tekst
        public Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                if (i + 8 < binary.Length)
                {
                    String t = binary.Substring(i, 8);
                    list.Add(Convert.ToByte(t, 2));
                }
            }

            return list.ToArray();
        }
        private void btnOdczytajWiadomosc_Click(object sender, EventArgs e)
        {
            //zmieniam przyciski na niedostępne
            btnWybierzOrginal.Enabled = false;
            btnWybierzZmienione.Enabled = false;
            //Tworze dwie bitmapy każdego z obrazków
            Bitmap orginal = new Bitmap(lblSciezkaOrginal.Text);
            Bitmap zmieniony = new Bitmap(lblSciezkaZmienione.Text);

            //zmienna przechowująca różnicę w wartości bitów
            int roznica = 0;
            int licznik = 0;
            //zmienna do danych wyjściowych
            string daneWyjsciowe = "";
            do
            {
                for (int i = 0; i < orginal.Height - 1; i++)
                {
                    for (int j = 0; j < orginal.Width - 1; j++)
                    {
                        //pobierz kolor pixela z obrazka Orginalnego i Zmienionego
                        Color pixelOrginal = orginal.GetPixel(j, i);
                        Color pixelZmieniony = zmieniony.GetPixel(j, i);
                        //zapisywanie rożnicy ARGB do danych wyjściowych
                        roznica = pixelOrginal.A - pixelZmieniony.A;
                        if (roznica == 0) { licznik++; } else { licznik = 0; }
                        daneWyjsciowe = daneWyjsciowe + Convert.ToString(roznica);
                        roznica = pixelOrginal.R - pixelZmieniony.R;
                        if (roznica == 0) { licznik++; } else { licznik = 0; }
                        daneWyjsciowe = daneWyjsciowe + Convert.ToString(roznica);
                        roznica = pixelOrginal.G - pixelZmieniony.G;
                        if (roznica == 0) { licznik++; } else { licznik = 0; }
                        daneWyjsciowe = daneWyjsciowe + Convert.ToString(roznica);
                        roznica = pixelOrginal.B - pixelZmieniony.B;
                        if (roznica == 0) { licznik++; } else { licznik = 0; }
                        daneWyjsciowe = daneWyjsciowe + Convert.ToString(roznica);
                    }
                }
            } while (licznik < 128);
            tbDaneWyjsciowe.Text = Encoding.ASCII.GetString(GetBytesFromBinaryString(daneWyjsciowe));


        }
    }
    
}
