using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelek
{
    public class Sajatkivetel:Exception
    {
        public Sajatkivetel(string uzenet):base(uzenet)
        {

        }
    }
}
