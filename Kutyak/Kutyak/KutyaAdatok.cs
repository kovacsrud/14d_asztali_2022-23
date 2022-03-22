using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class KutyaAdatok
    {
        public ListaKutyak Kutyak { get; set; }
        public ListaKutyanev Kutyanevek { get; set; }
        public ListaKutyafajta Kutyafajtak { get; set; }

        public KutyaAdatok()
        {
            Kutyak = new ListaKutyak("kutyak.csv", ';');
            Kutyanevek = new ListaKutyanev("kutyanevek.csv", ';');
            Kutyafajtak = new ListaKutyafajta("kutyafajtak.csv", ';');
        }
    }

    
}
