using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        //függvény túlterhelés, overloading
        public static void Kiir()
        {
            Console.WriteLine("Alprogram,function");
        }
        /// <summary>
        /// A függvény az átadott változót kiírja
        /// </summary>
        /// <param name="szoveg"></param>
        public static void Kiir(string szoveg)
        {
            Console.WriteLine(szoveg);
        }
        /// <summary>
        /// A függvény az nev1 és a nev2 értékeket egymás után kiírja
        /// </summary>
        /// <param name="nev1"></param>
        /// <param name="nev2"></param>

        public static void Kiir(string nev1,string nev2)
        {
            Console.WriteLine($"{nev1} {nev2}");
        }

        public static int Osszead(int szam1,int szam2)
        {
            return szam1 + szam2;
        }
        public static double Osszead(double szam1,double szam2)
        {
            return szam1 + szam2;
        }
        
        //Cím szerinti paraméterátadás
        public static void Negyzet(ref int a)
        {
            a = a * a;
        }

        static void Main(string[] args)
        {
            Kiir();
            Kiir("Paraméter");
            Kiir("Kiss", "Elek");
            var ertek = Osszead(12, 68);
            Console.WriteLine($"Érték:{ertek}");
            var valamiSzam = 210;

            Console.WriteLine(Osszead(valamiSzam,336));
            Console.WriteLine(Osszead(12.48,76.881));
            var a = 3;
            //az a változó referenciáját adjuk át a
            //Negyzet függvénynek
            Negyzet(ref a);
            Console.WriteLine($"A:{a}");
            
            Console.ReadKey();
        }
    }
}
