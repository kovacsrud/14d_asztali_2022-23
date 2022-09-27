using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketsWPF
{
    
    public class RocketDataContext
    {
        public RocketList rockets;
        public RocketDataContext()
        {
            rockets = new RocketList("all-rockets-from-1957_v2.csv", ';');
        }

    }
}
