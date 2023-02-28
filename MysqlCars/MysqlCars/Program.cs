using System;

namespace MysqlCars
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new CarContext();
            context.Database.EnsureCreated();

            
            var owner = new Owner { Name = "Elek", Phone = "06661234567" };
            var car = new Car { GyartasiEv=2001,Marka="Fiat",Tipus="Bravo",Rendszam="KRG-566",Owner=owner};

            context.Owner.Add(owner);
            context.Car.Add(car);
            context.SaveChanges();


            Console.WriteLine("OK"); 
            Console.ReadKey();
        }
    }
}
