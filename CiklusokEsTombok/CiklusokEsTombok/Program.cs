using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklusokEsTombok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = { 122, 13, 678, 45, 98, 3321, 665, 871, 516, 622 };
            
            
            Array.Sort(szamok);
            

            //for növekményes,előírt lépésszámú
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            //elöltesztelő
            int index = 22;
            while (index<szamok.Length)
            {
                Console.WriteLine(szamok[index]);
                index++;
                //index += 1;
                //index = index + 1;
            }

            //hátultesztelő ciklus, a ciklusmag egyszer mindenféleképpen lefut
            index = 0;
            do
            {
                Console.WriteLine(szamok[index]);
                index++;

            } while (index<szamok.Length);

            Console.ReadKey();
        }
    }
}
