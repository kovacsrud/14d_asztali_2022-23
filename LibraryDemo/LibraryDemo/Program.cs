using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRHash;

namespace LibraryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHash hash = new CreateHash();
            var valami=hash.MakeHash(HashType.MD5, "blabla");
            Console.WriteLine(valami);

            Console.ReadKey();
        }
    }
}
