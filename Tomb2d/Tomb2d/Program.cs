using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb2d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tomb2d = new int[20, 15];
            Random rand = new Random();

           
            for (int i = 0; i < tomb2d.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2d.GetLength(1); j++)
                {
                    tomb2d[i, j] = rand.Next(10, 100);
                }

            }

            for (int i = 0; i < tomb2d.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2d.GetLength(1); j++)
                {
                    Console.Write(tomb2d[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
