using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAllLines
{
    public class Dolgozo
    {
        

        public string Nev { get; set; }
        public string Neme { get; set; }
        public string Reszleg { get; set; }
        public int Belepes { get; set; }
        public int Ber { get; set; }

        public Dolgozo(string sor)
        {
            var e = sor.Split(';');
            Nev = e[0];
            Neme = e[1];
            Reszleg = e[2];
            Belepes = Convert.ToInt32(e[3]);
            Ber = Convert.ToInt32(e[4]);

        }


    }
}
