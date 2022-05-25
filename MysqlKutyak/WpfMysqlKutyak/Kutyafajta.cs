using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMysqlKutyak
{
    public class Kutyafajta
    {

        public int Id { get; set; }
        public string Nev { get; set; }
        public string Eredetinev { get; set; }

        public Kutyafajta(int id, string nev, string eredetinev)
        {
            Id = id;
            Nev = nev;
            Eredetinev = eredetinev;
        }


    }
}
