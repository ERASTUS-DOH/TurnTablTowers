using System.Net.Security;

namespace TurntablTowers
{
    public abstract class Apartment
    {
        private string _floorNumber;
        private string _doorNumber;
        private string _apartmentNumber;
        private string _residentName;

        protected Apartment(string floorNumber_, string apartmentNumber_, string residentName_)
        {
            _floorNumber = floorNumber_;
            _apartmentNumber = apartmentNumber_;
            _residentName = residentName_;
            _doorNumber = floorNumber_ + apartmentNumber_;
        }

        public string FloorNumber
        {
            get => _floorNumber;
            set => _floorNumber = value;
        }

        public string DoorNumber
        {
            get => _doorNumber;
            set => _doorNumber = value;
        }

        public string ApartmentNumber
        {
            get => _apartmentNumber;
            set => _apartmentNumber = value;
        }

        public string ResidentName
        {
            get => _residentName;
            set => _residentName = value;
        }

        public abstract void ringDoorBell();
    }
}