using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToplistaElem> toplista = new List<ToplistaElem>();

            toplista.Add(new ToplistaElem("TheKing", 8000));
            toplista.Add(new ToplistaElem("NoPingJustLag", 6500));
            toplista.Add(new ToplistaElem("Destroyer", 6200));
            toplista.Add(new ToplistaElem("JustSkillNoLuck", 5200));
            toplista.Add(new ToplistaElem("Sentinel", 3200));


            var jsonSerializer = new JsonSerializer();

            var jsonFajl = new JsonTextWriter(new StreamWriter("toplista.json"));

            jsonSerializer.Serialize(jsonFajl, toplista);
            
            jsonFajl.Close();

            Console.WriteLine("Kész");

            var jsonBetolt = new JsonTextReader(new StreamReader("toplista.json"));

            List<ToplistaElem> jsonVissza = jsonSerializer.Deserialize<List<ToplistaElem>>(jsonBetolt);

            foreach (var i in jsonVissza)
            {
                Console.WriteLine($"{i.Nev},{i.Pontszam}");
            }


            Console.ReadKey();
        }
    }
}
