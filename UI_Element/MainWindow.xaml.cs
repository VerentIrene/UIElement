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
using System.Text.RegularExpressions;

namespace UIElement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadDataCbAgama();
            if(agama_cbo.SelectedItem == null)
            {
                agama_cbo.SelectedItem = agama_cbo.Items[0]; 
            }

        }

        public void ValidasiAngka(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void ValidasiHuruf(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void LoadDataCbAgama()
        {
            List<string> ItemList = new List<string>();
            String[] agama = { "Islam", "Kristen", "Katolik", "Hindu", "Buddha", "Konghucu" };

            ItemList.AddRange(agama);
            agama_cbo.ItemsSource = ItemList;
        }

        private void OnClickTambah_btn(object sender, RoutedEventArgs e)
        {
            prestasi_lb.Items.Add(prestasi_txt.Text);
            prestasi_txt.Text = "";
        }

        private void OnCheckedPilihSemua_chk(object sender, RoutedEventArgs e)
        {
            if(pilihSemua_chk.IsChecked != false)
            {
                bermainGame_chk.IsChecked = true;
                bermainMusik_chk.IsChecked = true;
                berolahraga_chk.IsChecked = true;
                membaca_chk.IsChecked = true;
                mendengarkanMusik_chk.IsChecked = true;
                menontonFilm_chk.IsChecked = true;
                menulis_chk.IsChecked = true;
            }
            else
            {
                bermainGame_chk.IsChecked = false;
                bermainMusik_chk.IsChecked = false;
                berolahraga_chk.IsChecked = false;
                membaca_chk.IsChecked = false;
                mendengarkanMusik_chk.IsChecked = false;
                menontonFilm_chk.IsChecked = false;
                menulis_chk.IsChecked = false;

            }

        }
        
    }
}
