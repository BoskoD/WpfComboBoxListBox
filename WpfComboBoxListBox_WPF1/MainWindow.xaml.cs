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

namespace WpfComboBoxListBox_WPF1
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

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox1.SelectedIndex > -1)
            {
                ComboBoxItem selektovano = ComboBox1.SelectedItem as ComboBoxItem;
                TextBlock1.Text = selektovano.Content.ToString();
            }
            else
            {
                ComboBox1.Text = "";
                TextBlock1.Text = "";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBox1.SelectedIndex = -1;
          
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (!string.IsNullOrEmpty(TextBox1.Text))
                {
                    ComboBoxItem cbi = new ComboBoxItem();
                    cbi.Content = TextBox1.Text;
                    ComboBox1.Items.Add(cbi);
                    TextBox1.Clear();
                    ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1;
                }
            }
        }
    }
}
