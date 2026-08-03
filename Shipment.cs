using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop01
{
    internal class Shipment
    {
        private string DescriPtion= "Unknown"; 
        private double weight=1;
        private decimal deliveryFee=50;
        private string trackingCode;
        private DeliveryAddress destination;


        public Shipment(string TrackingCode)
        {
            trackingCode = TrackingCode;
        }

        public Shipment(string TrackingCode , string descriPtion, double Weight, decimal DeliveryFee, DeliveryAddress Destination) 
        {
            trackingCode = TrackingCode;
            DescriPtion = descriPtion;
            weight = Weight;
            deliveryFee = DeliveryFee;
            destination = Destination;

        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0) 
            {
                deliveryFee = newFee;

            } 

        }

        public void PrintShipment() 
        {
            Console.WriteLine($"Tracking Code: {trackingCode}");
            Console.WriteLine($"Description: {DescriPtion}");
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Delivery Fee: ${deliveryFee}");
            Console.WriteLine($"Destination: {destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: ${estimatedCost}");
        }


   

        public string Description
        {
            get { return DescriPtion; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }
                DescriPtion = value;
            }
        }
    
        public double Weight
        {
            get { return weight; }
            set {
                if (value <= 0)
                {
                    return;
                }
                weight = value;
            }
        }
        
        public decimal DeliveryFee
        {
           get { return deliveryFee; }
           private set {
                if (value <= 0)
                {
                    return;
                }
                deliveryFee = value;
            }
        }
  
        public string TrackingCode
        {
            get { return trackingCode; }
           private set
                 {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }
                trackingCode = value;
            }

        }

        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }

      
        public decimal estimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5);
            }
        }








    }
}
