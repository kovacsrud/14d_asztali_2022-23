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

namespace WpfIdojaras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AdatAdapter adapter;
        public MainWindow()
        {
            InitializeComponent();
            adapter = new AdatAdapter();
            datagridIdojarasAdatok.ItemsSource = adapter.idojarasAdatok.IdojarasLista;
            listboxEvek.ItemsSource = adapter.idojarasAdatok.GetEvek();
        }

        private void listboxEvek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listboxHonapok.ItemsSource = adapter.idojarasAdatok.GetHonapok((int)listboxEvek.SelectedItem);
            datagridIdojarasAdatok.ItemsSource = adapter.idojarasAdatok.GetAdatok((int)listboxEvek.SelectedItem);
        }

        private void listboxHonapok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listboxNapok.ItemsSource = adapter.idojarasAdatok.GetNapok((int)listboxEvek.SelectedItem,(int)listboxHonapok.SelectedItem);
            datagridIdojarasAdatok.ItemsSource = adapter.idojarasAdatok.GetAdatok((int)listboxEvek.SelectedItem,(int)listboxHonapok.SelectedItem);
        }
    }
}
