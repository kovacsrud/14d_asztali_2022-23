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

namespace WpfKetiranyuAdatkotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindClass bindclass;
        int min, max;
        public MainWindow()
        {
            InitializeComponent();
            min = 0;
            max = 1200;
            slider.Minimum = min;
            slider.Maximum = max;
            progressbar.Minimum = min;
            progressbar.Maximum = max;
            bindclass = new BindClass(50,min,max);
            DataContext = bindclass;
            

        }
    }
}
