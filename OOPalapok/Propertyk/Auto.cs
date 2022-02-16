

using System;

namespace Propertyk
{
    public class Auto
    {
        public string Rendszam { get; set; }
        public string Marka { get; set; }
        public string Tipus { get; set; }
        public int GyartasiEv { get; set; }
        public int FutottKm { get; set; }

        public int AutoKor()
        {
            return DateTime.Now.Year - GyartasiEv;
        }
        
    }
}