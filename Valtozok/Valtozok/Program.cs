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

            Console.ReadKey();
        }
    }
}
