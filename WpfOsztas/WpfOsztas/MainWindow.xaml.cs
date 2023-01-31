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

namespace WpfOsztas
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

        private void buttonOsztas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(ertek_a.Text);
                var b = Convert.ToDouble(ertek_b.Text);
                eredmeny.Text = (a / b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            
        }
    }
}
