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
                datagridRockets.ItemsSource = rocketDataContext.rockets.Rockets;
                //MessageBox.Show(rocketDataContext.rockets.Rockets.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);                 
            }
            
            
        }
    }
}
