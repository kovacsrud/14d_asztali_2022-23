using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorOOP
{
    public enum Anyag {fa,fém,műanyag,beton,kő };
    public class Butor
    {
        public int Suly { get; set; }
        public Anyag JellemzoAnyag { get; set; }
        public int MaxMagassag { get; set; }

        public override string ToString()
        {
            return $"{Suly},{JellemzoAnyag},{MaxMagassag}";
        }
    }
}
