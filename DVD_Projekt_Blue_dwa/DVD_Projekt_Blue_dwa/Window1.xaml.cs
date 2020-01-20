using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Linq;

namespace DVD_Projekt_Blue_dwa
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            var path = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\pracownicy.db");

            if ( Imię.Text == "" || Nazwisko.Text == "" || Nickname.Text == "" || Mail.Text == "" || Telefon.Text == "" || Dywizja.Text == "")
            {
                MessageBox.Show("To Porządna firma, a nie jakieś Hocki=Klocki, dawaj wszystkie dane jak pytają");
            }
            else
            {
                if (File.ReadAllLines(path).Length >= 6)
                {
                    MessageBox.Show("Po analizie rynku przeprowadzonej przez spółkę, oszacowaliśmy, że zwiększenie liczby pracowników powyżej 6 wprowadzi negatywną atmosferę wśród załogi");
                }
                else
                {
                    string newLine = Environment.NewLine;
                    File.AppendAllText(path, id_pracownika +"; " + Imię.Text + "; " + Nazwisko.Text + "; " + Nickname.Text + "; " + Dywizja.Text + "; " + Mail.Text + "; " + Telefon.Text + newLine);
                    MessageBox.Show("Dodano nowego pracownika.");
                    Imię.Text = null;
                    Nazwisko.Text = null;
                    Nickname.Text = null;
                    Mail.Text = null;
                    Telefon.Text = null;
                    Dywizja.Text = null;
                }

            }
        }

        private void Odśwież_Click(object sender, RoutedEventArgs e)
        {
            var path = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\pracownicy.db");
            Wyświetlenie_pracowników.Text = null;
            Wyświetlenie_pracowników.Text = File.ReadAllText(path);
        }

    }
}
