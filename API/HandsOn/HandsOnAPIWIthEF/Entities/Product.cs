using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnAPIWIthEF.Entities
{
    public class Product
    {
        [Key] //set as primary key
        public int Id { get; set; }
        [Required] //set as not null
        public string Name { get; set; }
        public int? Price { get; set; } //set null constraint
        public int? Stock { get;set; }
    }
}
