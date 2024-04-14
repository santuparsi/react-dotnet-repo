
using Microsoft.EntityFrameworkCore;
using Practice.Entities;

namespace Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
      
            var connection = builder.Configuration.GetConnectionString("MySqlConnection");
           //builder.Services.AddDbContext<LibraryContext>(options => options.UseMySql(connection,ServerVersion.AutoDetect(connection)));

            builder.Services.AddControllers();
            builder.Services.AddCors(c=>
            c.AddPolicy("AllowOrigin", options=>
            {
                options.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("AllowOrigin");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
