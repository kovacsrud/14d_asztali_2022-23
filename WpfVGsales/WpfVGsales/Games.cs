using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVGsales
{
    public class Games
    {
        public List<Game> GameSales { get; set; }

        public Games(string file,char hatarolo,int start=1)
        {
            GameSales = new List<Game>();
            var sorok = File.ReadAllLines(file, Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                GameSales.Add(new Game(sorok[i], hatarolo));
            }
        }

        public List<string> GetPlatforms()
        {
            List<string> items = new List<string>();

            var stat = GameSales.ToLookup(x => x.Platform).OrderBy(x => x.Key);

            foreach (var i in stat)
            {
                items.Add(i.Key);
            }


            return items;
        }

        public List<string> GetGenres()
        {
            List<string> items = new List<string>();

            var stat = GameSales.ToLookup(x => x.Genre).OrderBy(x => x.Key);

            foreach (var i in stat)
            {
                items.Add(i.Key);
            }


            return items;
        }
    }
}
