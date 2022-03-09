using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Valami szöveg");
                try
                {
                    int a = 10;
                    int b = 5;
                    int c = a/b;
                    List<int> lista = null;
                    Console.WriteLine($"C:{lista.First()}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);                    
                }

                throw new Sajatkivetel("Saját kivétel!");

                Console.WriteLine("Valami másik szöveg");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ez egy Argumentexception!");
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Out of memory!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();
        }
    }
}
