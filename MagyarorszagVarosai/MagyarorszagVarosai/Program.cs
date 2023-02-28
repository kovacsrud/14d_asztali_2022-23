using System;
using MagyarorszagVarosai.Models;
using Microsoft.EntityFrameworkCore;

namespace MagyarorszagVarosai
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new magyar_telepulesekContext();
            context.Telepulesek.Load();
            context.Megyek.Load();
            context.Jogallas.Load();
            

            foreach (var i in context.Megyek.Local)
            {
                Console.WriteLine($"{i.Nev},{i.Kod}");
            }

            foreach (var i in context.Jogallas.Local)
            {
                Console.WriteLine($"{i.Suly},{i.Jogallas1}");
            }

            foreach (var i in context.Telepulesek.Local)
            {
                Console.WriteLine($"{i.Irszam},{i.JogallasNavigation.Jogallas1},{i.Nev},{i.MegyekodNavigation.Nev}");
            }

            Console.ReadKey();
        }
    }
}
