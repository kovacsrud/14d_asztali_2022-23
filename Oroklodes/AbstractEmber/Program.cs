using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmber
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportolo sportolo1 = new Sportolo
            {
                VezetekNev = "Kiss",
                KeresztNev = "Elek",
                Suly = 78,
                SzuletesiEv = 2001,
                Sportag="tenisz"
            };

            Sportolo sportolo2 = new Sportolo
            {
                VezetekNev = "Nagy",
                KeresztNev = "Ernő",
                Suly = 89,
                SzuletesiEv = 1999,
                Sportag="futás;"

            };

            Nyugdijas nyugdijas1 = new Nyugdijas
            {
                VezetekNev = "Kósa",
                KeresztNev = "Ubul",
                Suly = 96,
                SzuletesiEv = 1945,
                HanyEvetDolgozott=45
            };

            Nyugdijas nyugdijas2 = new Nyugdijas
            {
                VezetekNev = "Imre",
                KeresztNev = "Gerzson",
                Suly = 88,
                SzuletesiEv = 1949,
                HanyEvetDolgozott=41
            };

            List<Ember> emberek = new List<Ember>();
            emberek.Add(sportolo1);
            emberek.Add(sportolo2);
            emberek.Add(nyugdijas1);
            emberek.Add(nyugdijas2);

            foreach (var i in emberek)
            {
                //Console.WriteLine($"{i.VezetekNev},{i.KeresztNev},{i.Eletkor()}");
                if (i.GetType()==typeof(Sportolo))
                {
                    Sportolo sportolo = (Sportolo)i;
                    Console.WriteLine($"Ez egy sportoló! Sportága:{sportolo.Sportag}");
                }
                if (i.GetType()==typeof(Nyugdijas))
                {
                    Nyugdijas ny = (Nyugdijas)i;
                    Console.WriteLine($"Ez egy nyugdíjas! Ennyit dolgozott:{ny.HanyEvetDolgozott}");
                }
            }

            Console.ReadKey();
        }
    }
}
