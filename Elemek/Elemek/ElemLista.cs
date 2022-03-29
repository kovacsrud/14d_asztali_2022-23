using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemek
{
    public class ElemLista
    {
        public List<Elem> Elemek { get; set; }

        public ElemLista(string fajl,char hatarolo,int start=1)
        {
            Elemek = new List<Elem>();
            var sorok = File.ReadAllLines(fajl, Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                Elemek.Add(new Elem(sorok[i], hatarolo));
            }
        }
    }
}
