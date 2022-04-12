using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAtletika
{
    public class AtletikaVb
    {
        public List<Versenyzo> Versenyzok { get; set; }

        public AtletikaVb(string fajl,char hatarolo,int start=0)
        {
            Versenyzok = new List<Versenyzo>();
            var sorok = File.ReadAllLines(fajl, Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                Versenyzok.Add(new Versenyzo(sorok[i], hatarolo));
            }

        }
    }
}
