using System;
using System.Collections.Generic;

namespace TurntablTowers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Apartment> apartments = new List<Apartment>()
            {
                new BasicApartment("12","05","Erastus"),  
                new GrandApartment("5","06","Elinam"),
                new SilverApartment("4","08","Selasi"),
                new GrandApartment("3", "09","Rubbie")
            };
            
            TurnTablTower turnTablTower = new TurnTablTower(apartments);
            
            turnTablTower.TakeRegister();
            turnTablTower.RingBell();
            //Console.WriteLine("Hello World!");
        }
    }
}