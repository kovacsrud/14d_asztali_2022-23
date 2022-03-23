using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                KutyaAdatok adatok = new KutyaAdatok();
                var kutyafajtak = adatok.Kutyafajtak.Kutyafajtak;
                var kutyanevek = adatok.Kutyanevek.Kutyanevek;
                var kutyak = adatok.Kutyak.Kutyak;

                //foreach (var i in kutyak)
                //{
                //    Console.WriteLine($"{i.Eletkor},{i.NevId}");
                //}
                var nevvel = kutyak.Join(kutyanevek,
                    k=>k.NevId,
                    kn=>kn.Id,
                    (k,kn)=>new {Kor=k.Eletkor,k.FajtaId,k.Id,k.UtolsoEllenorzes,Kutya_neve=kn.KutyaNev}
                   
                    );

                var osszes = nevvel.Join(kutyafajtak,
                        n => n.FajtaId,
                        kf => kf.Id,
                        (n, kf) => new {n.Id,n.Kor,n.Kutya_neve,n.UtolsoEllenorzes,kf.Nev }
                    ); 
                
                //foreach (var i in nevvel)
                //{
                //    Console.WriteLine($"{i.Id},{i.Kor},{i.Kutya_neve},{i.UtolsoEllenorzes}");
                //}

                var avgEletkor = osszes.Average(x => x.Kor);
                Console.WriteLine($"A kutyák átlagéletkora:{avgEletkor:0.00}");

                var legidosebb = osszes.First(x => x.Kor == osszes.Max(y => y.Kor));
                Console.WriteLine($"{legidosebb.Kutya_neve},{legidosebb.Nev}");

                var legidosebbW = osszes.Where(x => x.Kor == osszes.Max(y => y.Kor));

                Console.WriteLine($"{legidosebbW.First().Kutya_neve},{legidosebbW.First().Nev}");

                foreach (var i in legidosebbW)
                {
                    Console.WriteLine($"{i.Kutya_neve},{i.Nev},{i.Kor}");
                }

                var adottNap = osszes.Where(x=>x.UtolsoEllenorzes.Year==2018
                && x.UtolsoEllenorzes.Month==1               
                && x.UtolsoEllenorzes.Day==10);

                var stat = adottNap.ToLookup(x=>x.Nev);
                foreach (var i in stat)
                {
                    Console.WriteLine($"{i.Key} - {i.Count()} kutya");
                }

                var maxLeterhelt = osszes.ToLookup(x=>new {x.UtolsoEllenorzes.Year,x.UtolsoEllenorzes.Month,x.UtolsoEllenorzes.Day }).OrderByDescending(x=>x.Count());

                //foreach (var i in maxLeterhelt)
                //{
                //    Console.WriteLine($"{i.Key.Year}.{i.Key.Month}.{i.Key.Day} - {i.Count()}");
                //}

                Console.WriteLine($"{maxLeterhelt.First().Key.Year}.{maxLeterhelt.First().Key.Month}.{maxLeterhelt.First().Key.Day} - {maxLeterhelt.First().Count()}");

                var nevstat = osszes.ToLookup(x => x.Kutya_neve).OrderByDescending(x => x.Count());

                try
                {
                    FileStream fajl = new FileStream("nevstatisztika.txt",FileMode.Create);
                    using (StreamWriter writer = new StreamWriter(fajl, Encoding.UTF8))
                    {
                        foreach (var i in nevstat)
                        {
                            writer.WriteLine($"{i.Key};{i.Count()}");
                        }
                    }
                    Console.WriteLine("Kiírás kész!");
                }
                catch (Exception ex)
                {
                                        
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            

           

            Console.ReadKey();
        }
    }
}
