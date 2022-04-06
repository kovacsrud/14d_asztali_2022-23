using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            string nevsor = "";
            try
            {
                nevsor = File.ReadAllText("nevsor.json", Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            JObject nevek = JObject.Parse(nevsor);

            Console.WriteLine(nevek["nevsor"].Count());
            Console.WriteLine(nevek["nevsor"][0]["nev"]);

            for (int i = 0; i < nevek["nevsor"].Count(); i++)
            {
                Console.WriteLine($"{nevek["nevsor"][i]["id"]}-{nevek["nevsor"][i]["nev"]}");
                
            }

            Console.WriteLine(nevek["nevsor"][1]["ismerosok"][0]["nev"]);
            if (nevek["nevsor"][1]["ismerosok"].Count()>0)
            {
                Console.WriteLine("Ez egy tömb");
            }

            Console.ReadKey();
        }
    }
}
