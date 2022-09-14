using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rockets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rocket> rockets = new List<Rocket>();
            try
            {
                var sorok = File.ReadAllLines("all-rockets-from-1957_v2.csv",Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {
                    rockets.Add(new Rocket(sorok[i], ';'));
                }
                Console.WriteLine($"Betöltve, sorok száma:{rockets.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);                
            }

            var raketaAr = rockets.FindAll(x=>x.Price!=-1);

            //Árral rendelkező rakéták darabszáma, áruk átlaga
            Console.WriteLine($"Darabszám:{raketaAr.Count},Átlagos ár:{raketaAr.Average(x=>x.Price):0.00}");

            //foreach (var i in raketaAr)
            //{
            //    Console.WriteLine($"{i.Price} million");
            //}

            //A legmagasabb rakéta adatait határozzuk meg
            //1 elem(?)

            var legMagasabb = rockets.Find(x => x.RocketHeight == rockets.Max(y=>y.RocketHeight));

            if (legMagasabb!=null)
            {
                Console.WriteLine($"Magasság:{legMagasabb.RocketHeight},{legMagasabb.Name},{legMagasabb.Status}");
            } else
            {
                Console.WriteLine("Nincs a feltételnek megfelelő elem!");
            }
            //A legkisebb rakéta adatai
            var noNullHeight = rockets.FindAll(x => x.RocketHeight != -1);

            var minRocket = noNullHeight.Find(x => x.RocketHeight == noNullHeight.Min(y => y.RocketHeight));

            Console.WriteLine($@"Név:{minRocket.Name}
            Ár:{minRocket.Price}
            Magasság:{minRocket.RocketHeight}
            Fokozatok száma:{minRocket.Stages}
            Átmérő:{minRocket.FairingDiameter}");

            //Készítsünk összesítést, amely megmutatja, hogy az adott
            //státuszú rakétákból mennyi van!

            var statusStat = rockets.ToLookup(x=>x.Status);

            foreach (var i in statusStat)
            {
                Console.WriteLine($"{i.Key}:{i.Count()} db");
            }
            Console.WriteLine("========================================");
            
            var statusStagesStat = rockets.ToLookup(x =>new {x.Status,x.Stages}).OrderBy(x=>x.Key.Status).ThenBy(x=>x.Key.Stages);

            foreach (var i in statusStagesStat)
            {
                Console.WriteLine($"{i.Key.Status},{i.Key.Stages}:{i.Count()},{i.Max(x => x.RocketHeight)}");
            }

            //Készítsünk keresést a rakéta neve szerint, kis és nagybetűk ne legyenek 
            //megkülönböztetve, tartalmazást vizsgáljon

            var keresettRaketaNev = Console.ReadLine();

            var keresesEredmeny = rockets.FindAll(x => x.Name.ToLower().Contains(keresettRaketaNev.ToLower()));

            if (keresesEredmeny.Count>0)
            {
                foreach (var i in keresesEredmeny)
                {
                    Console.WriteLine(i.Name);
                } 
            } else
            {
                Console.WriteLine("Nincs ilyen nevű rakéta!");
            }

            //A keresés eredményét (ha van) írassuk ki fájlba!
            //A fájlnevet kérjük be, a kiterjesztés .txt legyen!

            Console.ReadKey();
        }
    }
}
