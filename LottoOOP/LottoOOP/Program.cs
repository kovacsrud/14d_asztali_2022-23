using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Lottojatek lottojatek = new Lottojatek(5, 90);
            lottojatek.Jatek();

            Lottojatek lottojatek45 = new Lottojatek(7, 45);
            lottojatek45.Jatek();

            Lottojatek lottojatek33 = new Lottojatek(7, 33);
            lottojatek33.Jatek();

            Console.ReadKey();
        }
    }
}
