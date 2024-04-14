using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Practice.Entities
{
    public class Product
    {
       
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int stock { get; set; }
    }
}
