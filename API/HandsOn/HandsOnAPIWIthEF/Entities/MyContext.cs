﻿using Microsoft.EntityFrameworkCore;
namespace HandsOnAPIWIthEF.Entities
{
    public class MyContext:DbContext
    {
        private IConfiguration configuration;

        public MyContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //add entity set
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        //defind the connectionstring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connection = "server=localhost;database=sampledb;user=root;password=admin";
            //get the connection value from the appsettigs.json file
            var connection = configuration.GetConnectionString("MySqlConnection");
            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }

    }
}
