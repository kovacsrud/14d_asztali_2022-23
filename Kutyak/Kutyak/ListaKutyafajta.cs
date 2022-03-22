using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class ListaKutyafajta
    {
        public List<Kutyafajta> Kutyafajtak { get; set; }

        public ListaKutyafajta(string fajl,char hatarolo,int start=1)
        {
            Kutyafajtak = new List<Kutyafajta>();
            var sorok = File.ReadAllLines(fajl, Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                Kutyafajtak.Add(new Kutyafajta(sorok[i], hatarolo));
            }

        }
    }
}
