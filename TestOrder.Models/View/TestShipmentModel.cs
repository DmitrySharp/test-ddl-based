using System;
using System.Collections.Generic;

namespace TestOrder.Models.View
{
    public class TestShipmentModel
    {
        public Guid ShipmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public IEnumerable<TestShipmentProductModel> Products { get; set; }
    }

    public class TestShipmentProductModel
    {
        public string SKU { get; set; }
        public int Quantity { get; set; }
    }
}