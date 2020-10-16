using System;
using System.Collections.Generic;

namespace TurntablTowers
{
    public class TurnTablTower
    {
        private List<Apartment> _apartments;

        public TurnTablTower(List<Apartment> apartments_)
        {
            _apartments = apartments_;
        }

        public void TakeRegister()
        {
            foreach (var apartment in _apartments)
            {
                Console.WriteLine($"Door number : {apartment.DoorNumber} has resident by name : {apartment.ResidentName}");
            }
            
        }


        public void RingBell()
        {
            foreach (var apartment in _apartments)
            {
                apartment.ringDoorBell();
            }
        }
    }
}