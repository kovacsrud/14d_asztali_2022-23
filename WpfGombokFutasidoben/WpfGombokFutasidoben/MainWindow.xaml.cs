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

namespace WpfGombokFutasidoben
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gombok(100);
            Szinez();
        }

        public void Gombok(int darab)
        {
            for (int i = 0; i < darab; i++)
            {
                Button gomb = new Button();
                gomb.FontSize = 20;
                gomb.Content = i + 1;
                gomb.Width = 40;
                gomb.Margin = new Thickness(3);
                gomb.Click += GombClick;
                wrapPanelGombok.Children.Add(gomb);
                

            }
        }

        public void GombClick(object sender,RoutedEventArgs e)
        {
            Button gomb = (Button)sender;
            labelInfo.Content = gomb.Content;
            //wrapPanelGombok.Children.Remove(gomb);
            //gomb.Background = Brushes.Red;
            //gomb.Foreground = Brushes.Green;
        }

        public void Szinez()
        {
            foreach (Button gomb in wrapPanelGombok.Children)
            {
                gomb.Background = Brushes.Blue;
            }
        }

        
    }
}
