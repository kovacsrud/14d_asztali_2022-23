using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainDir = Environment.CurrentDirectory;
            var mainDir2 = Directory.GetCurrentDirectory();
            var cardDir = "playingcards";
            Console.WriteLine(mainDir2);
            var fullPath = Path.Combine(mainDir,cardDir);
            Console.WriteLine(fullPath);

            DirectoryInfo mainDirInfo = new DirectoryInfo(fullPath);
            var cardFiles = mainDirInfo.GetFiles();

            foreach (var i in cardFiles)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
