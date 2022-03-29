using Elemek;
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

namespace WpfElemek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ElemLista elemek;
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                elemek = new ElemLista("felfedezesek.csv", ';');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            buttonReset.IsEnabled = false;
            datagridElemek.ItemsSource = elemek.Elemek;
            
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            var vegyjel = elemek.Elemek.FindAll(x => x.Vegyjel.ToLower() == textboxVegyjel.Text.ToLower());
            if (vegyjel.Count > 0)
            {
                datagridElemek.ItemsSource = vegyjel;
                buttonReset.IsEnabled = true;
            } else
            {
                MessageBox.Show("Nincs ilyen vegyjel!");
            }
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            datagridElemek.ItemsSource = elemek.Elemek;
            buttonReset.IsEnabled = false;
            textboxVegyjel.Text = "";
        }
    }
}
