using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeletlenListak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> egeszSzamok = new List<int>();
            Random rand = new Random();

            var hanySzam = rand.Next(40, 81);

            for (int i = 0; i < hanySzam; i++)
            {
                egeszSzamok.Add(rand.Next(-100, 101));
            }

            Lista(egeszSzamok);

            Console.WriteLine($"Összeg:{egeszSzamok.Sum()}");
            Console.WriteLine($"Átlag:{egeszSzamok.Average():0.00}");

            //Gyűjtsük ki egy másik listába a negatív számokat!

            var negativak = egeszSzamok.FindAll(x => x < 0 );
            Lista(negativak);

            
            var minuszOtven = negativak.Find(x=>x==-50);

            if (egeszSzamok.Any(x=>x>=5 && x<=10))
            {
                Console.WriteLine("Tartalmaz!");
            } else
            {
                Console.WriteLine("Nem tartalmaz!");
            }



            Console.ReadKey();
        }

        private static void Lista(List<int> egeszSzamok)
        {
            foreach (var i in egeszSzamok)
            {
                Console.WriteLine(i);
            }
        }
    }
}
