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

namespace DVD_Projekt_Blue_dwa
{
    /// <summary>
    /// Logika interakcji dla klasy Okno_Zleceń.xaml
    /// </summary>
    public partial class Okno_Zleceń : Window
    {
        double dywizja_żelazo = 1.5;
        double dywizja_brąz = 2;
        double dywizja_srebro = 2.5;
        double dywizja_złoto = 3;
        double dywizja_platyna = 4;
        double dywizja_diament = 5;
        double dywizja_mistrz = 10;
        double dywizja_arcymistrz = 15;
        double kwota_końcowa;
        double kwota_początkowa;
        double kwota_od_zera;
        double przelicznik;

        public Okno_Zleceń()
        {
            InitializeComponent();
        }

        private void lp00_Checked(object sender, RoutedEventArgs e)
        {
            if (lp00.IsChecked == true)
            {
                lp21.IsChecked = false;
                lp41.IsChecked = false;
                lp61.IsChecked = false;
                lp81.IsChecked = false;
            }
        }

        private void lp21_Checked(object sender, RoutedEventArgs e)
        {
            if (lp21.IsChecked == true)
            {
                lp00.IsChecked = false;
                lp41.IsChecked = false;
                lp61.IsChecked = false;
                lp81.IsChecked = false;
            }
        }

        private void lp41_Checked(object sender, RoutedEventArgs e)
        {
            if (lp41.IsChecked == true)
            {
                lp00.IsChecked = false;
                lp21.IsChecked = false;
                lp61.IsChecked = false;
                lp81.IsChecked = false;
            }
        }

        private void lp61_Checked(object sender, RoutedEventArgs e)
        {
            if (lp61.IsChecked == true)
            {
                lp00.IsChecked = false;
                lp21.IsChecked = false;
                lp41.IsChecked = false;
                lp81.IsChecked = false;
            }
        }

        private void lp81_Checked(object sender, RoutedEventArgs e)
        {
            if (lp81.IsChecked == true)
            {
                lp00.IsChecked = false;
                lp21.IsChecked = false;
                lp41.IsChecked = false;
                lp61.IsChecked = false;
            }
        }
        private void dywizja_aktualna_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lp_za_grę.Text == "minimalnie 16")
            {
                przelicznik = 1.5;
                if (dywizja_aktualna.Text == "Złoto")
                {
                    kwota_początkowa = (7 * dywizja_srebro + 7 * dywizja_brąz + 7 * dywizja_żelazo) * przelicznik;
                }
            }
        }
        private void dywizja_oczekiwana_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lp_za_grę.Text == "minimalnie 16")
            {
                przelicznik = 1.5;
                if (dywizja_oczekiwana.Text == "Pretendent")
                {
                    kwota_od_zera = (12 * dywizja_arcymistrz + 10 * dywizja_mistrz + 7 * dywizja_diament + 7 * dywizja_platyna + 7 * dywizja_złoto + 7 * dywizja_srebro + 7 * dywizja_brąz + 7 * dywizja_żelazo) * przelicznik;
                    kwota_końcowa = kwota_od_zera - kwota_początkowa;
                    przewidywana_cena.Text = Convert.ToString(kwota_końcowa);
                }
            }

        }

    }
}

