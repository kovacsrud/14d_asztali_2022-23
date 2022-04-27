using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIdojaras
{
    public class AdatAdapter
    {
        IdojarasAdatok idojarasAdatok;

        public AdatAdapter()
        {
            IdojarasAdatok idojarasAdatok = new IdojarasAdatok("idojaras.csv", ';');
        }
    }
}
