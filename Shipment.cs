using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop01
{
    internal class Shipment
    {
        private string description;
        private double weight;
        private decimal deliveryFee;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            set { deliveryFee = value; }
        }

    }
}
