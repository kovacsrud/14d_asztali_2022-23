using Rockets;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace RocketsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RocketDataContext rocketDataContext;
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                
                rocketDataContext = new RocketDataContext();
                DataContext = rocketDataContext;
                datagridRockets.ItemsSource = rocketDataContext.Rockets;
                //MessageBox.Show(rocketDataContext.rockets.Rockets.Count.ToString());
                //https://en.wikipedia.org/wiki/Tsyklon-3
                //webBrowserWiki = new WebBrowser();
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);                 
            }
            
            
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            //Megegyezés vizsgálata
            //var result = rocketDataContext.Rockets.FindAll(x=>x.Name.ToLower()==textboxKeresettAdat.Text.ToLower());
            //Tartalmazás vizsgálata
            datagridSearch.ItemsSource = null;

            var result = rocketDataContext.Rockets.FindAll(x => x.Name.ToLower().Contains(textboxKeresettAdat.Text.ToLower()));

            if (result.Count>0)
            {
                datagridSearch.ItemsSource = result;

            } else
            {
                MessageBox.Show("Nincs a feltételnek megfelelő adat!");
            }
        }

        private void datagridSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine(datagridSearch.SelectedItem);
            Rocket rocket = (Rocket)datagridSearch.SelectedItem;
            Debug.WriteLine(rocket.Wiki);
            try
            {
                webBrowserWiki.Navigate(new Uri(rocket.Wiki));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datagridSearch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGrid grid = (DataGrid)sender;
            
            Debug.WriteLine(grid.SelectedItem);
            Rocket rocket = (Rocket)grid.SelectedItem;
            Debug.WriteLine(rocket.Wiki);
            try
            {
                
                    webBrowserWiki.Navigate(new Uri(rocket.Wiki));
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
