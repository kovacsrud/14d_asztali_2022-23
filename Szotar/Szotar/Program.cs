using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szotar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Szótár adatszerkezet
            //Kulcs-érték párokat tárol
            Dictionary<string, int> nevek = new Dictionary<string, int>();

            nevek.Add("Árpád", 7);
            nevek.Add("Ágnes", 3);
            nevek.Add("Ubul", 6);
            nevek.Add("Győző", 7);
            nevek.Add("Miklós", 7);

            var hetesek = nevek.Where(x => x.Value == 7);
            foreach (var i in hetesek)
            {
                Console.WriteLine($"{i.Key},{i.Value}");
            }

            var masikHetesek = nevek.Select(x=>x.Value==7);

            foreach (var i in masikHetesek)
            {
                Console.WriteLine(i);
            }

            string aktKulcs = "Győző";
            if (nevek.ContainsKey(aktKulcs))
            {
                Console.WriteLine($"A {aktKulcs}-hoz tartozó érték:{nevek[aktKulcs]}");
                nevek[aktKulcs]++;
            } else
            {
                Console.WriteLine($"{aktKulcs} nincs a szótárban");
            }

            foreach (KeyValuePair<string, int> i in nevek)
            {
                Console.WriteLine($"Kulcs:{i.Key},Érték:{i.Value}");
            }

            int ertek = 17;
            if (nevek.ContainsValue(ertek))
            {
                Console.WriteLine("Van ilyen érték a szótárban!");
            } else
            {
                Console.WriteLine("Nincs ilyen érték a szótárban!");
            }
         

            Console.WriteLine(nevek.Count);
            Console.WriteLine(nevek.Values.Average());
            Console.WriteLine(nevek.Values.Min());
            
            

            Console.ReadKey();
        }
    }
}
