using AlapMuveletek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlapmuveletKonzol
{
    class Program
    {
        static void Main(string[] args)
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();

            Console.WriteLine(alapmuvelet.Osszead(10,20));

            Console.ReadKey();
        }
    }
}
