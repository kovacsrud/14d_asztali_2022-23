using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutya kutya = new Kutya("komondor",7800,true);
            Kigyo kigyo = new Kigyo("kobra", 4, 5600, false);

            kigyo.Szorit();
            kutya.Ugat();
            kigyo.Eszik();
            kigyo.Mozog();
            kutya.Eszik();
            kutya.Mozog();
            kutya.Iszik();
            kutya.setIsEmlos(true);
            Console.WriteLine(kutya.getIsEmlos());

            Console.ReadKey();
        }
    }
}
