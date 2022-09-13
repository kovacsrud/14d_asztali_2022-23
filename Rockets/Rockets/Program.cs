using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rockets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rocket> rockets = new List<Rocket>();
            try
            {
                var sorok = File.ReadAllLines("all-rockets-from-1957_v2.csv",Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {
                    rockets.Add(new Rocket(sorok[i], ';'));
                }
                Console.WriteLine($"Betöltve, sorok száma:{rockets.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);                
            }

            var raketaAr = rockets.FindAll(x=>x.Price!=-1);

            //Árral rendelkező rakéták darabszáma, áruk átlaga
            Console.WriteLine();

            //foreach (var i in raketaAr)
            //{
            //    Console.WriteLine($"{i.Price} million");
            //}

            Console.ReadKey();
        }
    }
}
