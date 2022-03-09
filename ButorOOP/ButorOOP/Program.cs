using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Butor> butorok = new List<Butor>();

            Butor butor = new Butor {
                JellemzoAnyag=Anyag.fa,
                MaxMagassag=170,
                Suly=80
              
            };

            Szekreny szekreny = new Szekreny
            {
                JellemzoAnyag=Anyag.fém,
                Suly=45,
                MaxMagassag=150,
                KulccsalZarhato=true,
                Uveges=false
            };

            Console.WriteLine(butor.ToString());
            Console.WriteLine(szekreny.ToString());
            butorok.Add(butor);
            butorok.Add(szekreny);

            Console.ReadKey();
        }
    }
}
