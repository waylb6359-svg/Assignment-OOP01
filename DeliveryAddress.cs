using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Assignment_oop01
{
    internal struct DeliveryAddress
    {
        public string City= "Unknown";
        public string Street= "Unknown";
        public int BuildingNumber= 0;
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }        

        public string GetFullAddress()
        {
            return $"{City},{Street},  {BuildingNumber}";
        }

    }
}
