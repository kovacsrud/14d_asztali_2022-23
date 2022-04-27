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
    }
}
