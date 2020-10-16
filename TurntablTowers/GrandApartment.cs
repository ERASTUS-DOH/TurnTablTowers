using System;
using System.Security.Cryptography;

namespace TurntablTowers
{
    public class GrandApartment : Apartment
    {
        public GrandApartment(string floorNumber_, string apartmentNumber_, string residentName_) : base(floorNumber_, apartmentNumber_, residentName_)
        {
        }

        public override void ringDoorBell()
        {
            Console.WriteLine("Please how may i be of help to you!");
            //throw new System.NotImplementedException();
        }
    }
}