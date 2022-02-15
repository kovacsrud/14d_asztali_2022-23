using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPalapok
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 különböző ember adatait kell tárolni
            //Vezetéknév,keresztnév,születési év,lakcim
            //Kérésre az adott ember "árulja el" hogy hány éves
            //objektum: adatok és metódusok egysége
            //osztály: az objektum a "tervrajza"
            //példány: az osztály alapján létrehozott objektum

            //Példányosítás
            Ember laszlo = new Ember("Horváth","László",1991,"Orosháza");
            Ember eva = new Ember("Nagy","Éva",1996,"Gyula");
            Ember ember = new Ember();

            Console.WriteLine(laszlo.GetNev());
            Console.WriteLine(eva.GetNev());
            Console.WriteLine(ember.GetNev());
            //laszlo.SetVezetekNev("Horváth");
            //laszlo.SetKeresztnev("László");
            //Console.WriteLine(laszlo.GetNev());
            
            Console.WriteLine(laszlo.GetEletkor());

            Console.WriteLine(eva.GetEletkor());

            Console.ReadKey();
        }
    }
}
