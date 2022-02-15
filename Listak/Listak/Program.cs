using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista deklarálása
            List<int> szamok = new List<int>();
            //Az elemek számának meghatározása
            Console.WriteLine($"Az elemek száma:{szamok.Count}");

            //Elemek hozzáadása
            szamok.Add(123);
            szamok.Add(55);
            szamok.Add(2199);

            Console.WriteLine($"Az elemek száma:{szamok.Count}");

            //Hivatkozás egy elemre

            Console.WriteLine(szamok.First());
            Console.WriteLine(szamok.Last());

            Console.WriteLine(szamok[1]);

            //Elem törlése
            szamok.Remove(55);
            Console.WriteLine($"Az elemek száma:{szamok.Count}");

            szamok.RemoveAt(1);
            Console.WriteLine($"Az elemek száma:{szamok.Count}");

            szamok.Add(119);
            szamok.Add(3187);

            //Bejárás for ciklussal
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.WriteLine(szamok[i]);
            }
           
            //Bejárás foreach ciklussal
            Listazas(szamok);

            List<int> masikSzamok = new List<int>();
            masikSzamok.Add(123);
            masikSzamok.Add(557);
            masikSzamok.Add(239);
            Console.WriteLine("--------------------------");
            szamok.AddRange(masikSzamok);
            Listazas(szamok);
            szamok.RemoveAll(x => x > 1000);
            Console.WriteLine("--------------------------");
            Listazas(szamok);



            Console.ReadKey();
        }

        private static void Listazas(List<int> szamok)
        {
            foreach (var i in szamok)
            {
                Console.WriteLine(i);
            }
        }
    }
}
