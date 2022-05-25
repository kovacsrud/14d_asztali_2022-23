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
using System.IO;

namespace WpfKartyak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Card> cards;
        Random rand;
        public MainWindow()
        {
            InitializeComponent();
            cards = new List<Card>();
            rand = new Random();
            var mainDir = Environment.CurrentDirectory;
            var cardDir = "cards";
            var fullPath = System.IO.Path.Combine(mainDir, cardDir);
            DirectoryInfo mainDirInfo = new DirectoryInfo(fullPath);
            var cardFiles = mainDirInfo.GetFiles();
            foreach (var i in cardFiles)
            {
                cards.Add(new Card($"{fullPath}\\{i}"));
            }

            Card randomCard = cards[rand.Next(0, cards.Count)];
            imageCard.Source = randomCard.CardPic;

        }
    }
}
