using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOOP03
{
    internal class DeliveryCenter
    {  // Aggregation
        public Driver Driver { get; set; }

        private Shipment[] shipments;
        private int count;

        public DeliveryCenter(int capacity)
        {
            shipments = new Shipment[capacity];
            count = 0;
        }

        public void AddShipment(Shipment shipment)
        {
            if (count < shipments.Length)
            {
                shipments[count] = shipment;
                count++;
            }
            else
            {
                Console.WriteLine(
                    "Delivery Center is full. Cannot add more shipments.");
            }
        }

        public void RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < count; i++)
            {
                if (shipments[i].TrackingCode == trackingCode)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }

                    shipments[count - 1] = null;
                    count--;

                    return;
                }
            }

            Console.WriteLine(
                "Shipment not found: " + trackingCode);
        }

        // Indexer by index
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return shipments[index];
                }

                return null;
            }
        }

        // Indexer by TrackingCode
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < count; i++)
            {
                shipments[i].PrintShipment();
                Console.WriteLine();
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public Shipment[] AllShipments
        {
            get
            {
                Shipment[] result =
                    new Shipment[count];

                Array.Copy(
                    shipments,
                    result,
                    count);

                return result;
            }
        }
    }
}
