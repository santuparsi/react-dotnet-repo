using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
namespace Practice.Entities
{
    public class LibraryContext:DbContext
    {
        public IConfiguration configuration;

        //public LibraryContext(DbContextOptions<LibraryContext> options):base(options)
        //{
            
        //}

        //public DbSet<Book> Book { get; set; }
        //public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conntection = "server=localhost;database=sample;user=root;password=admin";
            optionsBuilder.UseMySql(conntection, ServerVersion.AutoDetect(conntection));
        }


    }
       
    }

