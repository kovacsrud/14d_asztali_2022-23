using Rockets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketsWPF
{
    public class RocketList
    {
        private List<Rocket> _rockets;
        public List<Rocket> Rockets { get { return _rockets; }  }

        public RocketList(string fajl,char hatarolo,int start=1)
        {
            _rockets = new List<Rocket>();
            var sorok = File.ReadAllLines(fajl, Encoding.Default);
            for (int i = start; i < sorok.Length ; i++)
            {
                _rockets.Add(new Rocket(sorok[i], hatarolo));
            }

        }

    }
}
