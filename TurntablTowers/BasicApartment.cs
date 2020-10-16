using System;

namespace TurntablTowers
{
    public class BasicApartment : Apartment
    {
        public BasicApartment(string floorNumber_, string apartmentNumber_, string residentName_) : base(floorNumber_, apartmentNumber_, residentName_)
        {
        }

        public override void ringDoorBell()
        {
            //10%
            Random random = new Random();
            int randomNumber = random.Next(100);

            if (randomNumber <= 10)
            {
                Console.WriteLine($"{ResidentName} is home");
            }
            else
            {
                Console.WriteLine($"{ResidentName} is not home");
            }
            //throw new System.NotImplementedException();
        }
    }
}