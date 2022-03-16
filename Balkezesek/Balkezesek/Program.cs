using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jatekos> jatekosok = new List<Jatekos>();
            try
            {
                var sorok = File.ReadAllLines("balkezesek.csv", Encoding.UTF8);
                for (int i = 1; i < sorok.Length; i++)
                {
                    jatekosok.Add(new Jatekos(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Adatsorok száma:{jatekosok.Count}");

            var utolsok1999 = jatekosok.FindAll(x=>x.Utolso.Year==1999 && x.Utolso.Month==10);

            foreach (var i in utolsok1999)
            {
                Console.WriteLine($"{i.Nev},{i.Magassag*2.54} cm");
            }

            Console.Write("Adjon meg egy évszámot!");
            var evszam = Convert.ToInt32(Console.ReadLine());
            while (evszam<1990 || evszam>1999)
            {
                Console.WriteLine("Rossz évszám, adja meg újra!");
                evszam = Convert.ToInt32(Console.ReadLine());

            }

            var atlagsuly = jatekosok.FindAll(x => x.Elso.Year <= evszam && x.Utolso.Year >= evszam).Average(x=>x.Suly);
            Console.WriteLine($"{atlagsuly:0.00}");

            var stat = jatekosok.ToLookup(x => x.Elso.Year).OrderByDescending(x=>x.Key);
            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key}-{i.Count()}-fő-{i.Average(x=>x.Magassag*2.54):0.00} ");
            }

            try
            {
                FileStream fajl = new FileStream("stat.csv", FileMode.Create);
                using (StreamWriter writer=new StreamWriter(fajl,Encoding.UTF8))
                {
                    writer.WriteLine("ev;fo;atlagmagassag;atlagsuly");
                    foreach (var i in stat)
                    {
                       writer.WriteLine($"{i.Key};{i.Count()};{i.Average(x => x.Magassag * 2.54):0.00};{i.Average(x=>x.Suly)}");
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
