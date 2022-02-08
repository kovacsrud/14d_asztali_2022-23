using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[5];

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write($"Add meg a(z){i + 1}.számot:");
                int temp = Int32.Parse(Console.ReadLine());
                //
                while (temp < 10 || temp > 50 || szamok.Contains(temp))
                {
                    Console.Write($"Add meg a(z){i + 1}.számot:");
                    temp = Int32.Parse(Console.ReadLine());
                }
                szamok[i] = temp;
            }

            Tomblista(szamok);
            int[] masiktomb = { 11, 56, 85, 33, 89, 33, 55, 67 };
            Tomblista(masiktomb);

            Console.ReadKey();
        }

        private static void Tomblista(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{szamok[i]}");
            }
        }
    }
}
