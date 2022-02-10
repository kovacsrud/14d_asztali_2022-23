using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElemiAlgoritmusok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = { 2, 67, 988, 345, 299, 416, 629 };

            //összegzés, átlag,megszámlálás
            int osszeg;
            osszeg=Osszeg(szamok);
            Console.WriteLine($"Összeg:{osszeg}");


            //Min,max meghatározása
            int min = szamok[0];
            int max = szamok[0];
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }

            }



            Console.WriteLine($"Min:{min},Max:{max}");

            Console.ReadKey();
        }

        private static int Osszeg(int[] szamok)
        {
            int osszeg = 0;
            int darab = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];

                if (szamok[i] % 2 == 0)
                {
                    darab++;
                }

            }
            return osszeg;
        }
    }
}
