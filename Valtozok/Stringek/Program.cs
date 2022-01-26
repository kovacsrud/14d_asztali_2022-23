using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "Valami szöveg";
            Console.WriteLine($"A szöveg hossza:{szoveg.Length}");
            
            //Nagybetűsre alakítás
            Console.WriteLine(szoveg.ToUpper());
            //Kisbetűsre alakítás
            Console.WriteLine(szoveg.ToLower());

            //Kezdődik-e valamilyen karakterrel, vagy stringgel
            Console.WriteLine(szoveg.StartsWith("Valaki"));
            //Valamilyen karakterre/stringre végződik-e?
            Console.WriteLine(szoveg.EndsWith("x"));
            //Tartalmaz-e egy stringet a változó?
            Console.WriteLine(szoveg.Contains("ami"));
                         // 0123456789    
            string datum = "2022.01.26";
            string ev = datum.Substring(0, 4);
            string honap = datum.Substring(5, 2);
            string nap = datum.Substring(8,2);

            Console.WriteLine($"Ev:{ev}");
            Console.WriteLine($"Honap:{honap}");
            Console.WriteLine($"Nap:{nap}");

            string[] elemek=datum.Split('.');
            Console.WriteLine(elemek[0]);
            Console.WriteLine(elemek[1]);
            Console.WriteLine(elemek[2]);

            Console.WriteLine(datum.Replace('.', '-'));
            Console.WriteLine(datum.Replace("01","21"));

            Console.WriteLine(szoveg.Replace(" ",""));

            string szokozok = "-- -@@@  -- szöveg     @--    @--";
            char[] nemkivanatos = { '-', ' ', '@' };
            Console.WriteLine(szokozok.Trim(nemkivanatos));

            //Műveletek karakterekkel
            char c1 = '8';
            char c2 = '9';
            char c3 = 'h';
            
            Console.WriteLine(Char.IsDigit(c1));
            Console.WriteLine(Char.IsDigit(c3));
            Console.WriteLine(Char.IsWhiteSpace(c1));

            //Típus kényszerítése, kasztolás
            //int osszeg = (int)(Char.GetNumericValue(c1) + Char.GetNumericValue(c2));

            //A fordító rendeli a var esetén a változóhoz a megfelelő típust
            var osszeg = (Char.GetNumericValue(c1) + Char.GetNumericValue(c2));

            Console.WriteLine($"Összeg:{osszeg}");

            //stringek összehasonlítása
            string h1 = "ValAmi";
            string h2 = "vaLaMi";

            if (h1.ToLower()==h2.ToLower())
            {
                Console.WriteLine("Megegyeznek");
            } else
            {
                Console.WriteLine("Nem egyeznek meg");
            }

            string nev1 = "Nagy  eLek";
            string nev2 = "Nagy Elek";

            if (nev1.Replace(" ","").ToLower()==nev2.Replace(" ","").ToLower())
            {
                Console.WriteLine("A nevek megegyeznek!");
            } else
            {
                Console.WriteLine("A nevek nem egyeznek meg");
            }


            Console.ReadKey();
        }
    }
}
