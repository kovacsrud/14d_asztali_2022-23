using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtozok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Szám típusok
            int szam1;
            int szam2 = 12;
            Int64 szam3 = 22343455;
            short szam4 = 3434;
            long szam5 = 12112414;
            ulong szam6 = 123;
            byte szam7 = 45;

            

            szam2 = 219;
            szam1 = 188;

            Console.WriteLine("Hello World");
            Console.WriteLine($"Szám1:{szam1},szám2:{szam2}");
            Console.WriteLine(Int16.MaxValue);
            Console.WriteLine(Int16.MinValue);
            Console.WriteLine(UInt16.MaxValue);
            Console.WriteLine(UInt16.MinValue);
            Console.WriteLine(Int64.MaxValue);
            Console.WriteLine(Int64.MinValue);
            Console.WriteLine(UInt64.MaxValue);
            Console.WriteLine(UInt64.MinValue);

            //Lebegőpontos számok
            float l1 = 122.12345678901234567890f;
            double l2 = 122.12345678901234567890;
            decimal l3 = 122.1234567890123456789012345678901234567890m;

            //Karakter - egyetlen betű,szám,írásjel, vezérlő karakter
            char betu = 'h';

            //Logikai típus igaz/hamis
            bool logikai = true;
            logikai = false;

            //szöveg -karakterlánc
            string szoveg = "Szöveges típus";
            //a string típus ún. immutable azaz nem változtatható típus
            szoveg = "Másik szöveg";

            

            Console.WriteLine($"Float:{l1}");
            Console.WriteLine($"Double:{l2}");
            Console.WriteLine($"Decimal:{l3}");

            //Aritmetikai műveletek

            //+,-,*,/,%

            //Logikai műveletek 
            // and,or,not -> &&,||,!

            //relációs műveletek >,<,>=,<=,!=

            //Konvertálás típusok között
            Console.Write("Adjon meg egy szöveget:");
            string beolvas = Console.ReadLine();
            Console.WriteLine(beolvas);

            Console.WriteLine("Adjon meg egy számot:");
            double szambeolvas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(szambeolvas);




            Console.ReadKey();
        }
    }
}
