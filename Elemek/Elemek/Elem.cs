using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemek
{
    public class Elem
    {
        public string Ev { get; set; }
        public string Nev { get; set; }
        public string Vegyjel { get; set; }
        public int Rendszam { get; set; }
        public string Felfedezo { get; set; }

        public Elem(string sor,char hatarolo)
        {
            var e = sor.Split(hatarolo);
            Ev = e[0];
            Nev = e[1];
            Vegyjel = e[2];
            Rendszam = Convert.ToInt32(e[3]);
            Felfedezo = e[4];
        }
    }
}
