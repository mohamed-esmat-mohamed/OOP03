using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOOP03
{
    internal class DeliveryAddress
    {
        public string City { get; private set; }
        public string Street { get; private set; }

        public DeliveryAddress(string city, string street)
        {
            City = city;
            Street = street;
        }
    }
}
