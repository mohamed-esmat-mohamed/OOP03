using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOOP03
{
    internal class InternationalShipment : Shipment
    {
        public string DestinationCountry { get; set; }
        public double CustomsFee { get; set; }

        public InternationalShipment(
            string trackingCode,
            string description,
            double weight,
            double deliveryFee,
            string destinationCountry,
            double customsFee,
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
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override double EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("International Shipment");
            Console.WriteLine("---------------------------------------------");

            base.PrintShipment();

            Console.WriteLine(
                "Destination Country : " + DestinationCountry);

            Console.WriteLine(
                "Customs Fee         : " + CustomsFee + " EGP");

            Console.WriteLine(
                "Estimated Cost      : " + EstimatedCost + " EGP");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine(
                "[Customs Report] Standard customs report for "
                + TrackingCode);
        }

    }
}
