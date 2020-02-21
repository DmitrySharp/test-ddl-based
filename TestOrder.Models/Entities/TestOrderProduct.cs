using System.ComponentModel.DataAnnotations;

namespace TestOrder.Models.Entities
{
    public class TestOrderProduct : BaseEntity
    {
        [Required]
        public int OrderId { get; set; }
        public TestOrder Order { get; set; }
        [Required]
        public int ProductId { get; set; }
        public TestProduct Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Total { get; set; }


        public string GetAddressIdentity()
        {
            //TODO: Actually, address must be validated by Address Lookup and Validation APIs
            //That's why we do not check case or something else
            return this.Order == null
                ? string.Empty
                : this.Order.Address + this.Order.City + this.Order.State + this.Order.Country;
        }

    }
}