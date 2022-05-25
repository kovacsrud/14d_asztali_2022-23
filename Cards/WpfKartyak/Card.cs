using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfKartyak
{
    public class Card
    {
        public BitmapImage CardPic { get; set; }
        public string CardColor { get; set; }
        public string Suit { get; set; }

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

            if (fileName.Contains("clubs")){
                Suit = "club";
            } else if(fileName.Contains("diamonds"))
            {
                Suit = "diamond";
            } else if (fileName.Contains("hearts"))
            {
                Suit = "heart";
            } else
            {
                Suit = "spades";
            }

            CardPic = new BitmapImage(new Uri(picture));
        }

    }
}
