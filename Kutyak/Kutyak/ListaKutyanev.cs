using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class ListaKutyanev
    {
        public List<Kutyanev> Kutyanevek { get; set; }

        public ListaKutyanev(string fajl,char hatarolo,int start=1)
        {
            Kutyanevek = new List<Kutyanev>();
            var sorok = File.ReadAllLines(fajl, Encoding.Default);
            for (int i = start; i <sorok.Length ; i++)
            {
                Kutyanevek.Add(new Kutyanev(sorok[i], hatarolo));
            }
        }
    }
}
