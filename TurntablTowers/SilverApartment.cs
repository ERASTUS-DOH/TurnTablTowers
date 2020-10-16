using System;

namespace TurntablTowers
{
    public class SilverApartment : Apartment
    {
        public SilverApartment(string floorNumber_, string apartmentNumber_, string residentName_) : base(floorNumber_, apartmentNumber_, residentName_)
        {
        }

        public override void ringDoorBell()
        {
            Random random = new Random();
            int randomNumber = random.Next(100);


            if ( randomNumber <= 80 )
            {
                Console.WriteLine($"{ResidentName} is home, ");
            }
            else
            {
                Console.WriteLine($"{ResidentName} is not home ");
            }
            
            //80% probability that there is no one home
            // throw new System.NotImplementedException();
        }
    }
}