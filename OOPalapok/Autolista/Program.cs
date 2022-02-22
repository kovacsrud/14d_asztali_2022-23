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
          

            Console.Write("Hány elemből álljon a lista?");
            var elemDb = Convert.ToInt32(Console.ReadLine());

            Autok autolista = new Autok(elemDb);
            Autok masikautok = new Autok(elemDb);

            

            
            Lista(autolista.autok);
            Console.WriteLine("---------------------------------");
            Lista(masikautok.autok);

            var opelek = masikautok.autok.FindAll(
            x=>x.Marka.ToLower()=="oPeL".ToLower()
            &&
            x.Tipus=="Corsa"
            &&
            x.FutottKm<=200000);

            Lista(opelek);

            var elsoRendszam = autolista.autok.Find(x => x.Rendszam.StartsWith("A"));

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
