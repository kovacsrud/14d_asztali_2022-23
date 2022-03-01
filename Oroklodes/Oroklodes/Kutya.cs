using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    public class Kutya:Allat
    {
        public String Fajta { get; set; }
        public Kutya(string fajta,int suly,bool isemlos):base(suly,isemlos)
        {
            Fajta = fajta;
            Console.WriteLine("A kutya osztály konstruktora");
        }

        public void Ugat()
        {
            Console.WriteLine("A kutya ugat");
        }

        public override void Eszik()
        {
            Console.WriteLine("A kutya habzsolva eszik");
        }

        public override void Mozog()
        {
            Console.WriteLine("A kutya gyorsan mozog");
        }
    }
}
