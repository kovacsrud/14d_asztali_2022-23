using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIdojaras
{
    public class IdojarasAdatok
    {
        public List<Idojaras> IdojarasLista { get; set; }

        public IdojarasAdatok(string fajl,char hatarolo,int start=1)
        {
            IdojarasLista = new List<Idojaras>();
            var sorok = File.ReadAllLines(fajl, Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                IdojarasLista.Add(new Idojaras(sorok[i], hatarolo));
            }
        }

        public List<int> GetEvek()
        {
            List<int> evek = new List<int>();
            var evStat = IdojarasLista.ToLookup(x=>x.Ev).OrderBy(x=>x.Key);

            foreach (var i in evStat)
            {
                evek.Add(i.Key);
            }

            return evek;
        }

        public List<int> GetHonapok(int ev)
        {
            List<int> honapok = new List<int>();
            var evLista = IdojarasLista.FindAll(x => x.Ev == ev);
            var evStat = evLista.ToLookup(x => x.Honap).OrderBy(x => x.Key);

            foreach (var i in evStat)
            {
                honapok.Add(i.Key);
            }

            return honapok;
        }

        public List<int> GetNapok(int ev,int honap)
        {
            List<int> napok = new List<int>();
            var evLista = IdojarasLista.FindAll(x => x.Ev == ev && x.Honap==honap);
            var evStat = evLista.ToLookup(x => x.Nap).OrderBy(x => x.Key);

            foreach (var i in evStat)
            {
                napok.Add(i.Key);
            }

            return napok;
        }

        public List<Idojaras> GetAdatok(int ev)
        {
            var evLista = IdojarasLista.FindAll(x => x.Ev==ev);

            return evLista;
        }

        public List<Idojaras> GetAdatok(int ev,int honap)
        {
            var evLista = IdojarasLista.FindAll(x => x.Ev == ev && x.Honap==honap);

            return evLista;
        }


    }
}
