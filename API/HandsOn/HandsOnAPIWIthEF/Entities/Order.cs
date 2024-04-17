using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnAPIWIthEF.Entities
{
    public class Order
    {
        //Scalar Properties
        [Key]
        public Guid OrderId { get; set; } = Guid.NewGuid(); //primary key column
        [Required]
        public DateTime OrderDate { get; set; }
       // [ForeignKey("Product")]
        public int ProductId { get; set; } //Foreign key column
        [ForeignKey("ProductId")]
        public Product Product { get; set; } //Navigation Property
    }
}
