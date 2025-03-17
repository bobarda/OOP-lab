using System;

namespace TravelAgency
{
    public class TravelPackage
    {
        public string Destination { get; set; }
        public string TravelPackageType { get; set; }
        public decimal Price { get; set; }

        public TravelPackage() { }
        public TravelPackage(string destination, string travelPackageType)
        {
            Destination = destination;
            TravelPackageType = travelPackageType;
            Price = GetPrice();
        }

        private decimal GetPrice()
        {
            switch (TravelPackageType)
            {
                case "Basic":
                    return 1000;
                case "Deluxe":
                    return 2000;
                case "Premium":
                    return 3000;
                default:
                    return 0;
            }
        }
    }
}