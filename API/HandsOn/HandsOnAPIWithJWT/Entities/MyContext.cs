using Microsoft.EntityFrameworkCore;
namespace HandsOnAPIWithJWT.Entities
{
    public class MyContext:DbContext
    {
        IConfiguration configuration;

        public MyContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //add entity set
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        //defind the connectionstring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connection = "server=localhost;database=ecommdb;user=root;password=admin";
            var connection = configuration.GetConnectionString("MySqlConnection");
            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }

    }
}
