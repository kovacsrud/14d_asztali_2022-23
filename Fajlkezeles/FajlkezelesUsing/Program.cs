using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FajlkezelesUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopper = new Stopwatch();
            stopper.Start();
       
            try
            {
                FileStream fajl = new FileStream("berek2020.txt", FileMode.Open);

                using (StreamReader reader = new StreamReader(fajl, Encoding.UTF8))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        //Console.WriteLine(reader.ReadLine());
                        reader.ReadLine();
                    }
                }
                                            

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            stopper.Stop();

            Console.WriteLine(stopper.ElapsedTicks);

            Console.ReadKey();
            
        }
    }
}
