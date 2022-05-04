using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Idozitok
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(callback, null, 0, 2000);


            Console.ReadKey();
        }

        private static void callback(object state)
        {
            Console.WriteLine("Callback függvény"+DateTime.Now.Second);
        }
    }
}
