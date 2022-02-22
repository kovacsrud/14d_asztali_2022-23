using Propertyk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autolista
{
    public class Autok
    {
        private string[] markak = { "Fiat", "Opel", "Volkswagen", "BMW", "Kia", "Citroen" };
        private string[] tipus = { "Fabia", "Corsa", "Passat", "Rio", "Xsara", "C4", "C5", "Octavia" };
        private string[] rendszam = { "ABC-123", "ZKM-567", "HZU-111", "PKS-119", "DUH-678", "IES-967" };
        Random rand;
        public List<Auto> autok { get; set; }

        public Autok(int darab)
        {
            rand = new Random();
            autok = new List<Auto>();
            for (int i = 0; i < darab; i++)
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

        }


    }
}
