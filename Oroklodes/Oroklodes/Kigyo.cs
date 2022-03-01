using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    public class Kigyo:Allat
    {
        public string Fajta { get; set; }
        public int Hossz { get; set; }

        public Kigyo(string fajta,int hossz,int suly,bool isemlos):base(suly,isemlos)
        {
            Fajta = fajta;
            Hossz = hossz;
        }

        public void Szorit()
        {
            Console.WriteLine("A kígyó szorít");
        }

        public override void Eszik()
        {
            Console.WriteLine("A kígyó egyben eszi meg az ennivalóját");
        }

        public override void Mozog()
        {
            Console.WriteLine("A kígyó csúszik");
        }
    }
}
