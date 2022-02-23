using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fajlkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fajl = new FileStream("berek2020.txt", FileMode.Open);
                StreamReader reader = new StreamReader(fajl, Encoding.UTF8);
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();
        }
    }
}
