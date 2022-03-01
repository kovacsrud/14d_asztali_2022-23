using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    public class Allat
    {
        public int Suly { get; set; }
        private bool IsEmlos;

        public Allat(int suly,bool isemlos)
        {
            Suly = suly;
            IsEmlos = isemlos;
            Console.WriteLine("Az allat osztály konstruktora");
        }

        public virtual void Eszik()
        {
            Console.WriteLine("Az állat eszik");
        }

        public void Iszik()
        {
            Console.WriteLine("Az állat iszik");
        }

        public virtual void Mozog()
        {
            Console.WriteLine("Az állat mozog");
        }

        public void setIsEmlos(bool isemlos)
        {
            IsEmlos = isemlos;
        }

        public bool getIsEmlos()
        {
            return IsEmlos;
        }

    }
}
