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
    }
}
