using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rockets
{
    public class Rocket
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Wiki { get; set; }
        public string Status { get; set; }
        //Hiányos
        public double LiftoffThrust { get; set; }
        public double PayloadLEO { get; set; }
        public int Stages { get; set; }
        //Hiányos
        public int StrapOns { get; set; }
        //Hiányos, m
        public double RocketHeight { get; set; }
        //Hiányos $ million
        public double Price { get; set; }
        public double PayloadGTO { get; set; }
        //Hiányos m
        public double FairingDiameter { get; set; }
        //Hiányos m
        public double FairingHeight { get; set; }

        public Rocket(string sor,char hatarolo)
        {
            var adat = sor.Split(hatarolo);
            Name = adat[1];
            Company = adat[2];
            Wiki = adat[3];
            Status = adat[4];
            if (adat[5].Length == 0)
            {
                LiftoffThrust = -1;
            }
            else
            {
                //LiftoffThrust = Convert.ToDouble(adat[5].Replace(',', '.'));
                LiftoffThrust = Convert.ToDouble(adat[5]);
            }
            PayloadLEO = Convert.ToDouble(adat[6].Replace('.',','));

            if (adat[7].Length==0)
            {
                Stages = -1;
            } else
            {
                Stages = Convert.ToInt32(adat[7]);
            }

            

            if (adat[8].Length==0)
            {
                StrapOns = -1;
            } else
            {
                StrapOns = Convert.ToInt32(adat[8]);
            }

            if (adat[9].Length==0)
            {
                RocketHeight = -1;

            } else
            {
                char[] off = { ' ', 'm' };
                RocketHeight = Convert.ToDouble(adat[9].Trim(off).Replace('.', ','));
            }

            if (adat[10].Length == 0)
            {
                Price = -1;

            }
            else
            {
                char[] off = { ' ', 'm','$','i','l','o','n' };
                Price = Convert.ToDouble(adat[10].Trim(off).Replace(",","").Replace('.', ','));
            }

            PayloadGTO = Convert.ToDouble(adat[11].Replace('.', ','));

            if (adat[11].Length==0)
            {
                FairingDiameter = -1;
            } else
            {
                char[] off = { ' ', 'm' };
                FairingDiameter = Convert.ToDouble(adat[11].Trim(off).Replace('.', ','));
            }

            if (adat[12].Length == 0)
            {
                FairingHeight = -1;
            }
            else
            {
                char[] off = { ' ', 'm' };
                FairingHeight = Convert.ToDouble(adat[12].Trim(off).Replace('.', ','));
            }


        }


    }
}
