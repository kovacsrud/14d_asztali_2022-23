using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorsolas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nyeroSzamok = new List<int>();
            List<int> sorsoloGomb = new List<int>();
            Random rand = new Random();

            //Töltse fel a sorsoloGomb-öt 1-90 értékekkel!
            //válasszon ki belőlük random 5-öt
            //A kiválasztott szám az a sorsoloGomb-ből
            //kerüljön át a nyeroSzamok listába
            //Feltöltés
            for (int i = 1; i < 91; i++)
            {
                sorsoloGomb.Add(i);
            }

            //Lista(sorsoloGomb);

            for (int i = 0; i < 5; i++)
            {
                //Ki kell választani egyet véletlenszerűen a
                //gömbből
                var kivalasztott = sorsoloGomb[rand.Next(0,sorsoloGomb.Count-1)];
                nyeroSzamok.Add(kivalasztott);
                sorsoloGomb.Remove(kivalasztott);
            }

            Lista(sorsoloGomb);
            Lista(nyeroSzamok);

            sorsoloGomb.AddRange(nyeroSzamok);
            nyeroSzamok.Clear();

            Lista(sorsoloGomb);
            Lista(nyeroSzamok);


            Console.ReadKey();
        }

        private static void Lista(List<int> sorsoloGomb)
        {
            foreach (var i in sorsoloGomb)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
