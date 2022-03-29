using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemek
{
    class Program
    {
        static void Main(string[] args)
        {
            ElemLista elemek = null;
            try
            {
                elemek = new ElemLista("felfedezesek.csv", ';');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Elemek száma:{elemek.Elemek.Count}");
            var okoriElemek = elemek.Elemek.FindAll(x => x.Ev == "Ókor").Count;
            Console.WriteLine($"Ókorban felfedezett elemek:{okoriElemek}");

            Console.Write("Adjon meg egy vegyjelet!");
            var vegyjel = Console.ReadLine();

            var mindbetu = vegyjel.All(Char.IsLetter);

            //while (vegyjel.Length < 1 || vegyjel.Length > 2 || !Mindbetu(vegyjel))
            while (vegyjel.Length < 1 || vegyjel.Length > 2 || !vegyjel.All(Char.IsLetter))
            {
                Console.Write("Rossz, újra!");
                vegyjel = Console.ReadLine();
            }

            var keresettElem = elemek.Elemek.Find(x => x.Vegyjel.ToLower() == vegyjel.ToLower());

            if(keresettElem!=null)
            {
                Console.WriteLine($"{keresettElem.Nev}");
            } else
            {
                Console.WriteLine("Nincs ilyen elem!");
            }

            var nemOkor = elemek.Elemek.FindAll(x=>x.Ev!="Ókor");

            var maxKulonbseg = 0;

            for (int i = 0; i < nemOkor.Count-1; i++)
            {
                var kulonbseg = Math.Abs(Convert.ToInt32(nemOkor[i].Ev) - Convert.ToInt32(nemOkor[i+1].Ev));
                if (kulonbseg > maxKulonbseg)
                {
                    maxKulonbseg = kulonbseg;
                }
            }

            Console.WriteLine($"A legtöbb eltelt idő:{maxKulonbseg} év.");


            var stat = nemOkor.ToLookup(x => x.Ev).Where(x=>x.Count()>3);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key}:{i.Count()} db");  
            }

            Console.ReadKey();
        }

        private static bool Mindbetu(string vegyjel)
        {
            bool mindbetu = true;

            for (int i = 0; i < vegyjel.Length; i++)
            {
                if (!Char.IsLetter(vegyjel[i]))
                {
                    mindbetu = false;
                    break;
                }
            }

            return mindbetu;
        }
    }
}
