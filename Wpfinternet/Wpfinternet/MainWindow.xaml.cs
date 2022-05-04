using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace Wpfinternet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            //https://taszi.hu/kepek/kepkezelo/large/5995.jpg
            new WebClient().DownloadFile("https://taszi.hu/kepek/kepkezelo/large/5995.jpg", "erettsegi.jpg");
            byte[] kepAdat=new WebClient().DownloadData("https://taszi.hu/kepek/kepkezelo/large/5995.jpg");
            //BitmapImage bitmap = new BitmapImage(new Uri("https://taszi.hu/kepek/kepkezelo/large/5995.jpg"));
            BitmapImage bitmap = new BitmapImage();
            MemoryStream ms = new MemoryStream(kepAdat);
            ms.Position = 0;
            bitmap.BeginInit();
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.StreamSource = ms;
            bitmap.EndInit();

            imageKep.Source = bitmap;



        }
    }
}
