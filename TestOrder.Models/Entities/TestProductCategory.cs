using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestOrder.Models.Entities
{
    public class TestProductCategory
    {
        //This table haven't Id. Is this a mistake/ambiguity in the task statement?
        //In the real situation first of all we need clarify is the relationship between Category and Product one-to-many or many-to-many
        //The current task statement ("into same shipments by address and by product category") implies that a product may belong to only one category
        //So we don't need to use many-to-many and we could remove this table and use one-to-many pattern
        //But in the real case if we already has existing DB we need to discuss how to improve it or use as-is

        [Key]
        [Column(Order = 1)]
        [Required]
        public int ProductId { get; set; }
        public TestProduct Product { get; set; }
        [Key]
        [Column(Order = 2)]
        [Required]
        public int CategoryId { get; set; }
        public TestCategory Category { get; set; }

    }
}