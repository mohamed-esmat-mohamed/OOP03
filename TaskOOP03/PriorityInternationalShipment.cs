using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOOP03
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(
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
            destinationCountry,
            customsFee,
            city,
            street)
        {
        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine(
                "[Priority Customs Report] Fast-tracked customs clearance for "
                + TrackingCode);
        }
    }
}
