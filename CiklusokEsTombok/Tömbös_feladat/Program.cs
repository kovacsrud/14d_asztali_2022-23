using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tömbös_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[20];
            int[] negyzetSzamok = new int[20];
            Random rand = new Random();

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(10, 51);
                negyzetSzamok[i] = (int)(Math.Pow(szamok[i], 2));
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write($"{szamok[i]},{negyzetSzamok[i]}");
                Console.WriteLine();
            }

            string szo = "valami";
            string mondat = "Akármi,valami,bármi";

            if (mondat.Contains(szo))
            {
                Console.WriteLine("Tartalmazza");
            } else
            {
                Console.WriteLine("Nem tartalmazza");
            }

            for (int i = 0; i < mondat.Length; i++)
            {
                if (i%2!=0)
                {
                    Console.Write(mondat[i]);
                }
            }


            Console.ReadKey();
        }
    }
}
