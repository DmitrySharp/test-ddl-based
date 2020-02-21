using System.ComponentModel.DataAnnotations.Schema;

namespace TestOrder.Models.Entities
{
    public class BaseEntity
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Int is bad decision. Use GUID
        public int Id { get; set; }
    }
}