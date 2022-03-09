using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorOOP
{
    public class Szekreny:Butor
    {
        public bool Uveges { get; set; }
        public bool KulccsalZarhato { get; set; }


        public override string ToString()
        {
            return base.ToString()+$",{Uveges},{KulccsalZarhato}";
        }
    }
}
