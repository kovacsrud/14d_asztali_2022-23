using System;
using System.Collections.Generic;
using System.Text;

namespace MysqlCars
{
    public class Car
    {
        public int ID { get; set; }
        public string Rendszam { get; set; }
        public int GyartasiEv { get; set; }
        public string Marka { get; set; }
        public string Tipus { get; set; }

        public virtual Owner Owner { get; set; }

    }

    public class Owner
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
