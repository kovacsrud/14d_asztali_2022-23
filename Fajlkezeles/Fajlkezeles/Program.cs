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
            FileStream fajl = null;
            StreamReader reader = null;
            try
            {
                fajl = new FileStream("berek2020.txt", FileMode.Open);
                reader = new StreamReader(fajl, Encoding.UTF8);

                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }

               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            finally
            {
                if(reader!=null)
                {
                    reader.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
