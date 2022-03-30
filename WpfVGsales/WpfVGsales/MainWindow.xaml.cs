using Microsoft.Win32;
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

namespace WpfVGsales
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Games games;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            try
            {
                if (dialog.ShowDialog()==true)
                {
                    games = new Games(dialog.FileName, ';');
                    datagridGames.ItemsSource = games.GameSales;
                    tabitemKereses.IsEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);                
            }
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            if (textboxKeres.Text.Length>0)
            {
                var eredmeny = games.GameSales.FindAll(x=>x.Name.ToLower().Contains(textboxKeres.Text.ToLower()));
                if (eredmeny.Count==0)
                {
                    MessageBox.Show("Nincs ilyen játék!");
                }
                else
                {
                    datagridGames.ItemsSource = eredmeny;
                }
                
                
            } else
            {
                MessageBox.Show("Legalább egy karaktert adjon meg kereséskor!");
            }
        }
    }
}
