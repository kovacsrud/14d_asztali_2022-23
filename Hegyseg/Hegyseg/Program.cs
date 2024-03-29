﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegyseg
{
    class Program
    {
        static void Main(string[] args)
        {
            var hegycsucsok = new Hegycsucsok("hegyek.txt",';').HegycsucsLista;
            //var hegycsucsok = hegycsucsAdat.HegycsucsLista;

            Console.WriteLine($"Sorok:{hegycsucsok.Count}");

            var atlagMagassag = hegycsucsok.Average(x=>x.Magassag);
            Console.WriteLine($"Átlagos magasság:{atlagMagassag:0.00}");

            var legMagasabb = hegycsucsok.Find(x=>x.Magassag==hegycsucsok.Max(y=>y.Magassag));

            Console.WriteLine($@"Legmagasabb hegycsúcs:
            Név:{legMagasabb.HegycsucsNeve}
            Hegység:{legMagasabb.Hegyseg}
            Magasság:{legMagasabb.Magassag}");

            Console.Write("Adjon meg egy magasságot");
            var beMagassag = Convert.ToInt32(Console.ReadLine());

            var borzsony = hegycsucsok.FindAll(x=>x.Hegyseg.ToLower()=="börzsöny".ToLower());


            var vanemagasabb = borzsony.Find(x=>x.Magassag>beMagassag);

            if (vanemagasabb!=null)
            {
                Console.WriteLine($"A {beMagassag}-nál van magasabb csúcs!");
            } else
            {
                Console.WriteLine($"A {beMagassag}-nál nincs magasabb csúcs!");
            }

            var vaneMagasabbFindall = hegycsucsok.FindAll(x=>x.Hegyseg=="Börzsöny" && x.Magassag>beMagassag);

            if (vaneMagasabbFindall.Count>0)
            {
                Console.WriteLine($"A {beMagassag}-nál van magasabb csúcs!");
            } else
            {
                Console.WriteLine($"A {beMagassag}-nál nincs magasabb csúcs!");
            }

            if (hegycsucsok.Any(x=>x.Hegyseg=="Börzsöny" && x.Magassag>beMagassag))
            {
                Console.WriteLine($"A {beMagassag}-nál van magasabb csúcs!");
            } else
            {
                Console.WriteLine($"A {beMagassag}-nál nincs magasabb csúcs!");
            }

            var stat = hegycsucsok.ToLookup(x=>x.Hegyseg);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key},{i.Count()},{i.Average(x=>x.Magassag)}");
            }

            var bukkVidek = hegycsucsok.FindAll(x => x.Hegyseg == "Bükk-vidék");

            try
            {
                FileStream file = new FileStream("bukk-videk.txt", FileMode.Create);

                using (StreamWriter writer = new StreamWriter(file, Encoding.Default))
                {
                    writer.WriteLine("Hegycsúcs neve;Magasság láb");
                    foreach (var i in bukkVidek)
                    {
                        writer.WriteLine($"{i.HegycsucsNeve};{i.Magassag*3.28:0.#}");
                    }
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();
        }
    }
}
