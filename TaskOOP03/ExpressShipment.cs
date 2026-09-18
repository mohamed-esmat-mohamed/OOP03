using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOOP03
{
    internal class ExpressShipment : Shipment
    {
        public double ExtraFee { get; set; }

        public ExpressShipment(
            string trackingCode,
            string description,
            double weight,
            double deliveryFee,
            double extraFee,
            string city,
            string street)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                city,
                street)
        {
            ExtraFee = extraFee;
        }

        public override double EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Express Shipment");
            Console.WriteLine("---------------------------------------------");

            base.PrintShipment();

            Console.WriteLine(
                "Extra Fee     : " + ExtraFee + " EGP");

            Console.WriteLine(
                "Estimated Cost: " + EstimatedCost + " EGP");
        }
    }
}
