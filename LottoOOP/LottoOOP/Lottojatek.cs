using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoOOP
{
    public class Lottojatek
    {
        private int hanySzam;
        private int osszSzam;
        private int[] tippek;
        private int[] nyeroszamok;
        private int talalat;
        Random rand;

        public Lottojatek(int hanyszam,int osszszam)
        {
            hanySzam = hanyszam;
            osszSzam = osszszam;
            tippek = new int[hanySzam];
            nyeroszamok = new int[hanySzam];
            rand = new Random();
            talalat = 0;

        }

        public void Jatek()
        {
            talalat = 0;
            Tippeles();
            TombLista(tippek);
            Sorsolas();
            TombLista(nyeroszamok);
            Talalatok();
            Console.WriteLine($"Találatok száma:{talalat}");
        }

        private void Tippeles()
        {
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
        }

        private void Sorsolas()
        {
            for (int i = 0; i < hanySzam; i++)
            {
                var temp = rand.Next(1, osszSzam + 1);
                while (nyeroszamok.Contains(temp))
                {
                    temp = rand.Next(1, osszSzam + 1);
                }
                nyeroszamok[i] = temp;
            }
        }

        private void Talalatok()
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                for (int j = 0; j < nyeroszamok.Length; j++)
                {
                    if (tippek[i] == nyeroszamok[j])
                    {
                        talalat++;
                    }
                }
            }
        }

        private void TombLista(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
