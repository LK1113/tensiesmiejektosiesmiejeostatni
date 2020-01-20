using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace DVD_Projekt_Blue_dwa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Pracownicy_Click(object sender, RoutedEventArgs e)
        {
            var path = System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\pracownicy.db");

            Window1 objWindow1 = new Window1();

            for (int i = 1; i<6; i++)
            {
                string poszukiwane_id = "@"+i+".";
                if (!File.ReadAllText(path).Contains(poszukiwane_id))
                {
                    objWindow1.id_pracownika.Text = poszukiwane_id;
                    break;
                }
                while (poszukiwane_id == "@6." || File.ReadAllText(path).Contains(poszukiwane_id))
                {
                    MessageBox.Show("Uruchamiam pokazywanie zespołu, jednak nabór zostaje wyłączony, ze względu na limit miejsc");
                    break;
                }
            }
            
            objWindow1.Show();
        }

        private void Zlecenia_Click(object sender, RoutedEventArgs e)
        {
            Okno_Zleceń objokno_Zleceń = new Okno_Zleceń();
            objokno_Zleceń.Show();
        }
    }
}
