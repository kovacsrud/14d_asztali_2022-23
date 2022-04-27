using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIdojaras
{
    public class AdatAdapter
    {
        public IdojarasAdatok idojarasAdatok;

        public AdatAdapter()
        {
            idojarasAdatok = new IdojarasAdatok("idojaras.csv", ';');
            //Debug.WriteLine(idojarasAdatok.IdojarasLista.Count);
        }
    }
}
