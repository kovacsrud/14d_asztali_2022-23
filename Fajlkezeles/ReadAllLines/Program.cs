using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAllLines
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dolgozo> dolgozok = new List<Dolgozo>();
            try
            {
                var sorok = File.ReadAllLines("berek2020.txt",Encoding.UTF8);
                                
                for (int i = 1; i < sorok.Length; i++)
                {
                    dolgozok.Add(new Dolgozo(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);                
            }

            Console.WriteLine($"Elemek száma:{dolgozok.Count}");

            Console.ReadKey();
        }
    }
}
