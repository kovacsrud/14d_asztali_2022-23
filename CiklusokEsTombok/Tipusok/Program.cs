using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipusok
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 10;
            szam = 122;
            int szam2 = szam;
            szam2 += 10;
            szam -= 20;

            Console.WriteLine($"Szam:{szam},Szam2:{szam2}");

            int[] szamok = { 11, 22, 33, 44, 55 };
            int[] szamok2 = szamok;
            szamok2[0] = 222;

            Console.WriteLine($"Szamok tömb:{szamok[0]},Szamok2:{szamok2[0]}");

            Console.ReadKey();
        }
    }
}
