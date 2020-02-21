using System.Collections.Generic;
using TestOrder.Models.Entities;

namespace TestOrder.Models.View
{
    public class TestOrderProductModel
    {
        public Entities.TestOrder Order { get; set; }
        public List<TestProductModel> Products { get; set; } = new List<TestProductModel>();

    }


    public class TestProductModel
    {
        public TestProduct Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}