using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIUsingModels.Models;
namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet,Route("GetFlowers")]
        public string[] GetFlowers()
        {
            return new string[] { "Rose", "Lilly" };
        }
        [HttpGet,Route("GetFlower")]
        public string GetFlower()
        {
            return "Tulips";
        }
        [HttpGet]
        public string Greet(string name)
        {
            return "Hello " + name;
        }
        [HttpGet,Route("Message/{message}")]
        public string Message(string message)
        {
            return $"{message} " + "Virat";
        }
        [HttpGet,Route("GetBook")]
        public Book GetBook()
        {
            var book = new Book() { Id = 1, Title = "React", Price = 1200 };
            return book;
        }


    }
}
