using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop01
{
    internal class DeliveryCenter
    {

        private Shipment[] shipments;
        public DeliveryCenter(int size = 10)
        {
            if (size > 0 && size <= 10)
            {
                shipments = new Shipment[size];
            }
            else
            {
                shipments = new Shipment[10];
            }
        }



        public Shipment? this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }

                return null;
            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public Shipment? this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }
                return null;
            }
        }


    }
}












    

