using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPalapok
{
    public class Ember
    {
        private string vezeteknev;
        private string keresztnev;
        private int szuletesiEv;
        private string lakhely;

        public int GetEletkor()
        {
            return 2022 - szuletesiEv;
        }

        public void SetVezetekNev(string vezeteknev)
        {
            this.vezeteknev = vezeteknev;
        }

        public void SetKeresztnev(string keresztnev)
        {
            this.keresztnev = keresztnev;
        }
    }
}
