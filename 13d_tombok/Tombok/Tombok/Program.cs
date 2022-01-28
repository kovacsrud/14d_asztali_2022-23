using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            Random rand = new Random();

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(-100, 101);
            }

            

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i]+",");
            }

            string szoveg = "Valami szöveg megint";
            int darab = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i]=='a')
                {
                    darab++;
                }
            }

            Console.WriteLine($"Darabszám:{darab}");
            Console.ReadKey();
        }
    }
}
