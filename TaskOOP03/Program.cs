
using TaskOOP03;

namespace SmartDeliveryManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "====================================================");

            Console.WriteLine("Delivery Center");

            Console.WriteLine(
                "====================================================");


            // (a) Create Driver
            Driver driver = new Driver(
                "D001",
                "Ahmed Mohamed",
                "01000000000");


            // (b) Create DeliveryCenter
            DeliveryCenter center =
                new DeliveryCenter(10);


            // (c) Connect Driver with DeliveryCenter
            center.Driver = driver;

            Console.WriteLine(
                "Driver : " + center.Driver.FullName);

            Console.WriteLine();


            // (d) Standard Shipment
            StandardShipment standard =
                new StandardShipment(
                    "SH001",
                    "Laptop",
                    3,
                    50,
                    "Cairo",
                    "Tahrir St.");


            // (e) Express Shipment
            ExpressShipment express =
                new ExpressShipment(
                    "SH002",
                    "Mobile Phone",
                    2,
                    60,
                    30,
                    "Giza",
                    "Haram St.");


            // (f) International Shipment
            InternationalShipment international =
                new InternationalShipment(
                    "SH003",
                    "Television",
                    5,
                    130,
                    "Germany",
                    100,
                    "Berlin",
                    "Alex Platz");


            // (g) Add shipments
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);


            // (h) Print all shipments
            center.PrintAllShipments();


            // (i) DeliveryHelper
            Console.WriteLine(
                "====================================================");

            Console.WriteLine(
                "Printing Using DeliveryHelper...");

            Console.WriteLine(
                "====================================================");

            foreach (Shipment s in center.AllShipments)
            {
                DeliveryHelper.PrintShipmentDetails(s);

                Console.WriteLine(
                    s.GetType().Name
                    + " Printed Successfully.");

                Console.WriteLine();
            }


            // (j) UpdateWeight Overloading
            Console.WriteLine(
                "====================================================");

            Console.WriteLine("Updating Weight...");

            Console.WriteLine(
                "====================================================");

            Console.WriteLine(
                "Original Weight : "
                + standard.Weight
                + " KG");


            standard.UpdateWeight(5);

            Console.WriteLine(
                "Updated Weight : "
                + standard.Weight
                + " KG");


            standard.UpdateWeight(5, 0.5);

            Console.WriteLine(
                "Updated Weight After Packing : "
                + standard.Weight
                + " KG");

            Console.WriteLine();


            // (k) Mixed Shipment Array
            Console.WriteLine(
                "====================================================");

            Console.WriteLine(
                "Printing Using Shipment[]...");

            Console.WriteLine(
                "====================================================");


            Shipment[] mixedShipments =
            {
                standard,
                express,
                international
            };


            foreach (Shipment s in mixedShipments)
            {
                Console.WriteLine(
                    s.GetType().Name + "...");
            }

            Console.WriteLine();


            // (l) Sealed Class & Sealed Method
            Console.WriteLine(
                "====================================================");

            Console.WriteLine(
                "Sealed Class & Sealed Method Demo");

            Console.WriteLine(
                "====================================================");


            // Sealed Class
            CompletedShipment completed =
                new CompletedShipment(
                    "SH004",
                    "Books",
                    1.5,
                    40,
                    DateTime.Now,
                    "Cairo",
                    "Nasr City");

            completed.PrintShipment();

            Console.WriteLine();


            // Sealed Method
            PriorityInternationalShipment priority =
                new PriorityInternationalShipment(
                    "SH005",
                    "Medical Equipment",
                    8,
                    200,
                    "France",
                    150,
                    "Paris",
                    "Champs Elysees");

            priority.GenerateCustomsReport();


            Console.WriteLine();

            Console.WriteLine(
                "Program finished successfully.");
        }
    }
}