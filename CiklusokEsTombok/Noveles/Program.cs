using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noveles
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 10;

            //11
            int c = a + b++;
            //11
            int d = a+ ++b;

            Console.WriteLine($"C:{c},d:{d}");



            Console.ReadKey();

        }
    }
}
