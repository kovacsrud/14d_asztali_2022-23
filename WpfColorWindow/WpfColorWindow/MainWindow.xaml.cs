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

namespace WpfColorWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listboxPlay.Items.Add("media1.mp3");
            listboxPlay.Items.Add("media2.mp3");
            listboxPlay.Items.Add("media3.mp3");
            listboxPlay.Items.Add("media4.mp3");
            listboxPlay.Items.Add("media5.mp3");
            listboxPlay.Items.Add("media6.mp3");
        }

        private void rectHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void GombClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void maxGomb_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void minGomb_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
