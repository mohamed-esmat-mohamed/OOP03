using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOOP03
{
    internal class CompletedShipment : Shipment
    {
        public DateTime CompletionDate { get; set; }

        public CompletedShipment(
            string trackingCode,
            string description,
            double weight,
            double deliveryFee,
            DateTime completionDate,
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
            CompletionDate = completionDate;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Completed Shipment");
            Console.WriteLine("---------------------------------------------");

            base.PrintShipment();

            Console.WriteLine(
                "Completed On  : "
                + CompletionDate.ToShortDateString());

            Console.WriteLine(
                "Estimated Cost: "
                + EstimatedCost
                + " EGP");
        }
    }
}
