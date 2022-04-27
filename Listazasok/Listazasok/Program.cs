using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listazasok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[,] szamok2d = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            //Feladat: Listázza ki a tömb elemeit CIKLUS NÉLKÜL
            Tomblista(szamok);

            //Counter(150);

            Tomb2dlist(szamok2d);
            


            Console.ReadKey();
        }

        //Rekurzív függvény
        static void Tomblista(int[] tomb,int index = 0)
        {
            if (index<tomb.Length)
            {
                Console.WriteLine(tomb[index]);
                index++;
                Tomblista(tomb, index);
            }
            
        }

       static void Counter(int vege,int ertek=0)
       {
            if (ertek<vege)
            {
                Console.Write(ertek+" ");
                ertek++;
                Counter(vege, ertek);
            }
       }
        static void Tomb2dlist(int[,] tomb,int sor=0,int oszlop = 0)
        {
            if (oszlop<tomb.GetLength(1) && sor<tomb.GetLength(0))
            {
                Console.Write(tomb[sor,oszlop]+" ");
                oszlop++;
                if (oszlop==tomb.GetLength(1))
                {
                    sor++;
                    oszlop = 0;
                    Console.WriteLine();
                }
                Tomb2dlist(tomb, sor, oszlop);
            }
        }

       
    }
}
