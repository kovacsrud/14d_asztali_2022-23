using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmber
{
    public class Sportolo : Ember
    {
        public string Sportag { get; set; }

        public override void Eszik()
        {
            Console.WriteLine("A sportoló sokat eszik");
        }

        public override void Iszik()
        {
            Console.WriteLine("A sportoló nem iszik alkoholt");
        }

        public override void Mozog()
        {
            Console.WriteLine("A sportoló sokat mozog");
        }
    }
}
