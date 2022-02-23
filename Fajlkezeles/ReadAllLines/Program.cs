using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAllLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopper = new Stopwatch();
            stopper.Start();
            
            List<Dolgozo> dolgozok = new List<Dolgozo>();
            try
            {
                var sorok = File.ReadAllLines("berek2020.txt", Encoding.UTF8);

                for (int i = 1; i < sorok.Length; i++)
                {
                    dolgozok.Add(new Dolgozo(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            stopper.Stop();
            Console.WriteLine($"Végrehajtás ideje:{stopper.ElapsedTicks}");
            Console.WriteLine($"Elemek száma:{dolgozok.Count}");

            var nok = dolgozok.FindAll(x => x.Neme == "nő");

            var nokAvgBer = nok.Average(x=>x.Ber);

            Console.WriteLine($"A nők átlagfizetése:{nokAvgBer:#0,0.00} Ft");

            var ferfiak2000 = dolgozok.FindAll(x => x.Neme == "férfi" && x.Belepes >= 2000 && x.Belepes <= 2003);
            
            Lista(ferfiak2000);

            //A legjobban kereső nő adatai?
            var legjobbanKeresoNo = nok.Find(x=>x.Ber==nok.Max(y=>y.Ber));
            Console.WriteLine($@"A legjobban kereső nő:
              Név:{legjobbanKeresoNo.Nev}
              Részleg:{legjobbanKeresoNo.Reszleg}
              Bér:{legjobbanKeresoNo.Ber}");

            //Hány ember dolgozik az egyes részlegeken? (összesítés feladat)
            var stat = dolgozok.ToLookup(x=>x.Reszleg).OrderByDescending(x=>x.Key);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key},{i.Count()} fő, átlagbér:{i.Average(x=>x.Ber):0.0} Ft");
            }

            var stat2 = dolgozok.ToLookup(x=>new {x.Reszleg,x.Belepes}).OrderBy(x=>x.Key.Reszleg).ThenBy(x=>x.Key.Belepes);

            foreach (var i in stat2)
            {
                Console.WriteLine($"{i.Key.Reszleg},{i.Key.Belepes},{i.Count()}");
            }

            var belepes2000Utan = dolgozok.FindAll(x => x.Belepes >= 2000);

            try
            {
                FileStream fajl = new FileStream("belepok2000rossz.txt", FileMode.Create);

                using (StreamWriter writer = new StreamWriter(fajl, Encoding.UTF8))
                {
                    writer.WriteLine("Név;Neme;Részleg;Belépés;Bér");

                    foreach (var i in belepes2000Utan)
                    {
                        writer.WriteLine($"{i.Nev};{i.Neme};{i.Reszleg};{i.Belepes};{i.Ber}");
                    }
                }
                               

                Console.WriteLine("Írás kész");
               

            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static void Lista(List<Dolgozo> adatok)
        {
            foreach (var i in adatok)
            {
                Console.WriteLine($"{i.Nev},{i.Neme},{i.Reszleg},{i.Belepes},{i.Ber}");
            }
        }
    }
}
