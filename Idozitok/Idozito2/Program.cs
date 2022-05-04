using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Idozito2
{
    class Program
    {
        static int szamlalo = 0;
        static void Main(string[] args)
        {
            
            Timer timer = new Timer(2000);
            timer.Elapsed += callback;
            timer.Start();
            Console.ReadKey();
        }

        private static void callback(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(szamlalo);
            szamlalo++;
            
        }
    }
}
