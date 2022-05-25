using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMysqlKutyak
{
    public class Kutyanev
    {
        
        public int Id { get; set; }
        public string KutyaNev { get; set; }

        public Kutyanev(int id, string kutyaNev)
        {
            Id = id;
            KutyaNev = kutyaNev;
        }


    }
}
