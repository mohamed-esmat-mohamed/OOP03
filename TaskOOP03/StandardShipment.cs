using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOOP03
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(
           string trackingCode,
           string description,
           double weight,
           double deliveryFee,
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
        }

        public override void PrintShipment()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Standard Shipment");
            Console.WriteLine("---------------------------------------------");

            base.PrintShipment();

            Console.WriteLine(
                "Estimated Cost: " + EstimatedCost + " EGP");
        }
    }
}
