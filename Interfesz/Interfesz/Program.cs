using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISikidom> sikidomok = new List<ISikidom>();

            Kor k1 = new Kor(12.45);
            Kor k2 = new Kor(33.67);
            Kor k3 = new Kor(21.48);

            Teglalap t1 = new Teglalap(11.56, 31.21);
            Teglalap t2 = new Teglalap(18.26, 21.91);
            Teglalap t3 = new Teglalap(41.63, 20.21);

            sikidomok.Add(k1);
            sikidomok.Add(k2);
            sikidomok.Add(k3);
            sikidomok.Add(t1);
            sikidomok.Add(t2);
            sikidomok.Add(t3);

            //Mennyi a síkidomok összes kerülete/területe

            var osszKerulet = sikidomok.Sum(x => x.Kerulet());
            var osszTerulet = sikidomok.Sum(x => x.Terulet());
            Console.WriteLine($"Kerületek összege:{osszKerulet}");
            Console.WriteLine($"Területek összege:{osszTerulet}");

            //Körök kerülete,területe?

            var korOsszKerulet = sikidomok.FindAll(x=>x.GetType()==typeof(Kor)).Sum(x=>x.Kerulet());
            Console.WriteLine($"Körök kerülete:{korOsszKerulet}");

            foreach (var i in sikidomok)
            {
                if (i.GetType()==typeof(Teglalap))
                {
                    Teglalap t = (Teglalap)i;
                    Teglalap tt = i as Teglalap;

                    Console.WriteLine($"{t.Aoldal},{t.Boldal}");
                    Console.WriteLine($"{tt.Aoldal},{tt.Boldal}");
                    
                }
            }


            Console.ReadKey();
        }
    }
}
