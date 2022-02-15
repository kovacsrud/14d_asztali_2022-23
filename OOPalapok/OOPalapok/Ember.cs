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

        //A konstruktor automatikusan lefut példányosításkor
        //nem lehet visszatérési értéke, és void sem lehet
        public Ember(string vezeteknev,string keresztnev,int szuletesiev,string lakhely)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            szuletesiEv = szuletesiev;
            this.lakhely = lakhely;
        }

        public Ember()
        {
            vezeteknev = "Alap";
            keresztnev = "Gyula";
            szuletesiEv = 2000;
            lakhely = "Elek";
        }

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

        public string GetNev()
        {
            return vezeteknev + " " + keresztnev;
        }
    }
}
