using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfCards
{
    public class Card
    {
        public BitmapImage CardPic { get; set; }
        public string CardColor { get; set; }

        public Card(string picture)
        {
            var fileName = picture.Split('\\').Last();

            if (fileName.Contains("clubs") || fileName.Contains("spades"))
            {
                CardColor = "black";
            } else
            {
                CardColor = "red";
            }

            CardPic = new BitmapImage(new Uri(picture));
        }

    }
}
