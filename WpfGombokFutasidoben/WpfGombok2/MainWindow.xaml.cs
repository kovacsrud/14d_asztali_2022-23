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

namespace WpfGombok2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, Button> gombok;
        public MainWindow()
        {
            InitializeComponent();
            gombok = new Dictionary<int, Button>();
            Gombok(100);
            Elhelyez(gombok, wrapPanelGombok);
            gombok[10].Background = Brushes.Bisque;
        }

        private void Gombok(int db)
        {
            for (int i = 0; i < db; i++)
            {
                Button gomb = new Button();
                gomb.Content = i + 1;
                gomb.FontSize = 22;
                gomb.Click += GombClick;
                gombok[i] = gomb;

            }
            
        }
        private void Elhelyez(Dictionary<int,Button> dict,WrapPanel panel)
        {
            for (int i = 0; i < dict.Count; i++)
            {
                panel.Children.Add(dict[i]);
            }
        }

        private void GombClick(object sender,RoutedEventArgs e)
        {
            Button gomb = (Button)sender;
            labelInfo.Content = gomb.Content;
        }
    }
}
