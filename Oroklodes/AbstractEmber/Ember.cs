using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmber
{
    public abstract class Ember
    {
        public string VezetekNev { get; set; }
        public string KeresztNev { get; set; }
        public int Suly { get; set; }
        public int SzuletesiEv { get; set; }

        public int Eletkor()
        {
            return DateTime.Now.Year - SzuletesiEv;
        }

        public abstract void Eszik();
        public abstract void Mozog();
        public abstract void Iszik();



    }
}
