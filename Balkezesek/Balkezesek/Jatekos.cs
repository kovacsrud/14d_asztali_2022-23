using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    public class Jatekos
    {
        public string Nev { get; set; }
        public DateTime Elso { get; set; }
        public DateTime Utolso { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }

        public Jatekos(string sor)
        {
            var adatok = sor.Split(';');
            Nev = adatok[0];
            Elso = Convert.ToDateTime(adatok[1]);
            Utolso = Convert.ToDateTime(adatok[2]);
            Suly = Convert.ToInt32(adatok[3]);
            Magassag = Convert.ToInt32(adatok[4]);
        }
    }
}
