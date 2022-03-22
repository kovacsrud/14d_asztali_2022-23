using System;
using System.Collections.Generic;
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
                
                foreach (var i in nevvel)
                {
                    Console.WriteLine($"{i.Id},{i.Kor},{i.Kutya_neve},{i.UtolsoEllenorzes}");
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
