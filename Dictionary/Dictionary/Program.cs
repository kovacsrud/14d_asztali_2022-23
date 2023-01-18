using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> atvalto = new Dictionary<string, int>()
            {
                {"I",1 },{"II",2},{"III",3},{"IV",4},{"V",5},{"VI",6},{"VII",7}
            };

            Console.WriteLine(atvalto["II"]);
            atvalto.Add("VIII", 8);
            atvalto["IX"] = 9;

            foreach (KeyValuePair<string,int>   entry in atvalto)
            {
                Console.WriteLine($"{entry.Key},{entry.Value}");
            }

            Console.WriteLine(atvalto.ContainsKey("EE"));
            Console.WriteLine(atvalto.ContainsValue(3));
            atvalto["X"] = 3;

            var par = atvalto.Where(x=>x.Value==3);

            Console.WriteLine(par.First().Key);

            foreach (KeyValuePair<string, int> entry in par)
            {
                Console.WriteLine($"{entry.Key},{entry.Value}");
            }


            Console.ReadKey();
        }
    }
}
