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
            //A tömb azonos típusú adatok tárolására szolgál
            //Az elemeinek a számát meg kell adni
            int[] szamok = new int[5];
            Console.WriteLine(szamok[0]);
            Console.WriteLine(szamok[1]);
            szamok[0] = 111;
            Console.WriteLine(szamok[0]);

            int[] szamok2 = { 11, 23, 67, 89, 117, 56, 789,1122,3195 };

            Console.WriteLine(szamok2[1]);
            Console.WriteLine(szamok2[3]);

            //Utolsó elemre való hivatkozás?
            Console.WriteLine(szamok2[szamok2.Length-1]);
            Console.WriteLine(szamok2.Last());

            for (int i = 0; i < szamok2.Length; i++)
            {
                Console.WriteLine($"{i},{szamok2[i]}");
            }

            foreach (var item in szamok2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
