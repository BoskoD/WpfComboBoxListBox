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
using System.Windows.Shapes;

namespace WpfComboBoxListBox_WPF1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Dictionary<string, int> recnik = new Dictionary<string, int>();

        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // povezivanje int
            //for (int i = 0; i < 10; i++)
            //{
            //    ComboBox1.Items.Add(i);
            //} 

            /////////////////////////////////////////////////////////////////

            // povezivanje array
            //string[] stavke = {"stavka1", "stavka2", "stavka3", "stavka4" };
            //ComboBox1.ItemsSource = stavke;


            /////////////////////////////////////////////////////////////////

            recnik.Add("Domaca kafa", 10);
            recnik.Add("Rakija", 20);
            recnik.Add("Vino", 40);
            recnik.Add("Limunada", 120);
            ComboBox1.ItemsSource = recnik;
            ComboBox1.DisplayMemberPath = "Key";





        }


        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // povezivanje int
            //int a = (int)ComboBox1.SelectedItem;
            //TextBlock1.Text = a.ToString();

            /////////////////////////////////////////////////////////////////

            // povezivanje array
            //string selektovano = ComboBox1.SelectedItem.ToString();
            //TextBlock1.Text = $"{selektovano}";

            /////////////////////////////////////////////////////////////////

            KeyValuePair<string, int> selektovano = (KeyValuePair<string, int>)ComboBox1.SelectedItem;
            TextBlock1.Text = $"Cena je: {selektovano.Value}";




        }
    }
}
