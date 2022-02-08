using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterekManipulacioja
{
    class Program
    {
        static void Main(string[] args)
        {
            string nev = "GubAcSi ELeK";

            char[] charNev = nev.ToCharArray();

            for (int i = 0; i < charNev.Length; i++)
            {
                if (Char.IsUpper(charNev[i]))
                {
                    charNev[i] = Char.ToLower(charNev[i]);
                } else if (Char.IsLower(charNev[i]))
                {
                    charNev[i] = Char.ToUpper(charNev[i]);
                }
                
                    
                
            }

            nev = new string(charNev);

            Console.WriteLine(nev);

            Console.ReadKey();
        }
    }
}
