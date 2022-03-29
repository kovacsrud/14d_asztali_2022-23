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

            

            while (vegyjel.Length < 1 || vegyjel.Length > 2 || !Mindbetu(vegyjel))
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
