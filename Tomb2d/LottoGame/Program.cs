using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Játék típus választás
            //Tippek bekérése (nem lehet két egyforma tipp)
            //Nyerőszámok sorsolása (nem lehet két egyforma)
            //Találatok meghatározása
            //Kiíratás
            //Futtassuk adott találatig a programot!
            //Határozzuk meg, hogy hány évebe telt volna az adott számú 
            //találat elérése a megadott tippekkel

            char valasz = 'i';
            while (valasz == 'i') {     

                Console.Write("Hány számot húzunk?");
                var hanySzam = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mennyi számból sorsolunk?");
                var osszSzam = Convert.ToInt32(Console.ReadLine());

                int[] tippek = new int[hanySzam];
                int[] nyeroszamok = new int[hanySzam];
                Random rand = new Random();
                int talalat = 0;
                //Bekérés
                for (int i = 0; i < hanySzam; i++)
                {
                    Console.Write($"{i + 1}.tipp:");
                    var temp = Convert.ToInt32(Console.ReadLine());
                    while (temp < 1 || temp > osszSzam || tippek.Contains(temp))
                    {
                        Console.Write($"Rossz!{i + 1}.tipp");
                        temp = Convert.ToInt32(Console.ReadLine());
                    }
                    tippek[i] = temp;
                }

                Console.WriteLine("Tippek:");
                TombLista(tippek);
                int szamlalo = 0;
                //ciklus eleje
                while (talalat < 5) {

                    talalat = 0;

                    for (int i = 0; i < hanySzam; i++)
                    {
                        var temp = rand.Next(1, osszSzam + 1);
                        while (nyeroszamok.Contains(temp))
                        {
                            temp = rand.Next(1, osszSzam + 1);
                        }
                        nyeroszamok[i] = temp;
                    }
            
                    //Console.WriteLine("Nyerőszámok:");
                    //TombLista(nyeroszamok);

                    for (int i = 0; i < tippek.Length; i++)
                    {
                        for (int j = 0; j < nyeroszamok.Length; j++)
                        {
                                if (tippek[i]==nyeroszamok[j])
                                {
                                    talalat++;
                                }   
                        }
                    }
                    Console.WriteLine($"Találatok száma:{szamlalo},{talalat}");
                    szamlalo++;    

                    //ciklus vége
                }

                Console.WriteLine($"Ennyi évbe telt:{szamlalo/52}");
                Console.Write("Akar újra játszani(i/n)");
                valasz = Console.ReadKey().KeyChar;
                Console.WriteLine();

            }





            Console.ReadKey();
        }

        private static void TombLista(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
