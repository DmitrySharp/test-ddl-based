using System.ComponentModel.DataAnnotations;

namespace TestOrder.Models.Entities
{
    public class TestProductCategory: BaseEntity
    {
        //TODO: This table haven't Id. Is this a mistake?
        //TODO: If product ID used like ID, so this relationship is one to many, and doesn't need separated table

        [Required]
        public int ProductId { get; set; }
        public TestProduct Product { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public TestCategory Category { get; set; }

    }
}