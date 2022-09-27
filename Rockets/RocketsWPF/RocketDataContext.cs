using Rockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketsWPF
{

    public class RocketDataContext
    {
        RocketList rockets;
        public List<Rocket> Rockets {get;set;}
        public RocketDataContext()
        {
            rockets = new RocketList("all-rockets-from-1957_v2.csv", ';');
            Rockets = rockets.Rockets;
        }

    }
}
