using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertyk
{
    public class Ember
    {
       

        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }

        private int szuletesiev;
        public int SzuletesiEv {
            get { return szuletesiev; }
            set {
                if (value > 1900)
                {
                    szuletesiev = value;
                } else
                {
                    throw new ArgumentException("Hibás érték!");
                }
            
            } 
        }
        public string Lakcim { get; set; }

        //public Ember(string vezeteknev, string keresztnev, int szuletesiEv, string lakcim)
        //{
        //    Vezeteknev = vezeteknev;
        //    Keresztnev = keresztnev;
        //    SzuletesiEv = szuletesiEv;
        //    Lakcim = lakcim;
        //}
    }
}
