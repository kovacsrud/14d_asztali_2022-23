using Propertyk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autolista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autok = new List<Auto>();
            Random rand = new Random();
            string[] markak = { "Fiat", "Opel", "Volkswagen", "BMW", "Kia", "Citroen" };
            string[] tipus = { "Fabia", "Corsa", "Passat", "Rio", "Xsara", "C4", "C5", "Octavia" };
            string[] rendszam = { "ABC-123", "ZKM-567", "HZU-111", "PKS-119", "DUH-678", "IES-967" };

            Console.Write("Hány elemből álljon a lista?");
            var elemDb = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < elemDb; i++)
            {
                autok.Add(
                        new Auto
                        {
                            Rendszam = rendszam[rand.Next(0, rendszam.Length - 1)],
                            Marka = markak[rand.Next(0, markak.Length - 1)],
                            Tipus = tipus[rand.Next(0, tipus.Length - 1)],
                            GyartasiEv = rand.Next(1992, DateTime.Now.Year + 1),
                            FutottKm = rand.Next(50000, 400000 + 1)

                        }
                    );
            }

            //Lista(autok);

            var opelek = autok.FindAll(
            x=>x.Marka.ToLower()=="oPeL".ToLower()
            &&
            x.Tipus=="Corsa"
            &&
            x.FutottKm<=200000);

            Lista(opelek);

            var elsoRendszam = autok.Find(x => x.Rendszam.StartsWith("A"));

            if (elsoRendszam==null)
            {
                Console.WriteLine("Nincs ilyen");
            } else
            {
                Console.WriteLine($"{elsoRendszam.Rendszam},{elsoRendszam.Marka}");
            }
            

            Console.ReadKey();
        }

        private static void Lista(List<Auto> autok)
        {
            foreach (var i in autok)
            {
                Console.WriteLine($"{i.Rendszam},{i.Marka},{i.Tipus},{i.GyartasiEv},{i.FutottKm}");
            }
        }
    }
}
