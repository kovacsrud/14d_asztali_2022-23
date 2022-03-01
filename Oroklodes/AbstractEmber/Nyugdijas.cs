using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmber
{
    public class Nyugdijas : Ember
    {
        public int HanyEvetDolgozott { get; set; }
        public override void Eszik()
        {
            Console.WriteLine("A nyugdíjas keveset eszik");
        }

        public override void Iszik()
        {
            Console.WriteLine("A nyugdíjas vizet iszik");
        }

        public override void Mozog()
        {
            Console.WriteLine("A nyugdíjas többnyire lassan mozog");
        }
    }
}
