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
            Ember laszlo = new Ember();
            Ember eva = new Ember();

            
            laszlo.keresztnev = "László";
            laszlo.vezeteknev = "Horváth";
            laszlo.szuletesiEv = 1992;
            laszlo.lakhely = "Orosháza";

            eva.keresztnev = "Éva";
            eva.vezeteknev = "Kiss";
            eva.szuletesiEv = 1986;

            Console.WriteLine(laszlo.vezeteknev+" "+laszlo.keresztnev);
            Console.WriteLine(laszlo.GetEletkor());

            Console.WriteLine(eva.vezeteknev + " " + eva.keresztnev);
            Console.WriteLine(eva.GetEletkor());

            Console.ReadKey();
        }
    }
}
