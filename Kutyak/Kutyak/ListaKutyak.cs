using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class ListaKutyak
    {
        public List<Kutyak> Kutyak { get; set; }
        public ListaKutyak(string fajl,char hatarolo,int start=1)
        {
            Kutyak = new List<Kutyak>();
            var sorok = File.ReadAllLines(fajl, Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                Kutyak.Add(new Kutyak(sorok[i], hatarolo));
            }
        }
    }
}
