using Microsoft.EntityFrameworkCore;

namespace Practice.Entities
{
    public class Publisher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        
    }
}
