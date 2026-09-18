using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOOP03
{
    internal class Shipment
    {
        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public double Weight { get; protected set; }
        public double DeliveryFee { get; set; }

        // Composition
        public DeliveryAddress Address { get; private set; }

        public virtual double EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }

        public Shipment(
            string trackingCode,
            string description,
            double weight,
            double deliveryFee,
            string city,
            string street)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;

            Address = new DeliveryAddress(city, street);
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine("Tracking Code : " + TrackingCode);
            Console.WriteLine("Description   : " + Description);
            Console.WriteLine("Weight        : " + Weight + " KG");
            Console.WriteLine("Delivery Fee  : " + DeliveryFee + " EGP");
        }

        // Overloading
        public void UpdateWeight(double newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(double newWeight, double extraPackingWeight)
        {
            Weight = newWeight + extraPackingWeight;
        }
    }
}
