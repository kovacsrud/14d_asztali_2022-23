using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertyk
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
               // Ember geza = new Ember("Nagy", "Géza", 1987, "Bélmegyer");
               // Ember ubul = new Ember("Horváth", "Ubul", 1990, "Gyula");

                Ember zeno = new Ember {
                    Vezeteknev="Kósa",
                    Keresztnev="Zénó",
                    SzuletesiEv=1992,
                    Lakcim="Elek"
                };

                Auto auto = new Auto {
                    Rendszam="AGF-123",
                    Marka="Fiat",
                    Tipus="Linea",
                    GyartasiEv=2008,
                    FutottKm=210000
                };

                Console.WriteLine(auto.AutoKor());
                

              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

           





            Console.ReadKey();
        }
    }
}
