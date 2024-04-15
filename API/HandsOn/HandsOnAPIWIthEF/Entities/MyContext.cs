using Microsoft.EntityFrameworkCore;
namespace HandsOnAPIWIthEF.Entities
{
    public class MyContext:DbContext
    {
        //add entity set
        public DbSet<Product> Products { get; set; }
        //defind the connectionstring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = "server=localhost;database=sampledb;user=root;password=admin";
            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }

    }
}
