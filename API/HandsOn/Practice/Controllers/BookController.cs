using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice.Entities;

namespace Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //private readonly LibraryContext context;

        //public BookController(LibraryContext context)
        //{
        //    context = context;
        //}

        //[HttpPost,Route("AddBooks")]
        //public IActionResult AddBooks()
        //{
           

        //        // Adds a publisher
        //        var publisher = new Publisher
        //        {
        //            Name = "Mariner Books"
        //        };
        //        context.Publisher.Add(publisher);

        //        // Adds some books
        //        context.Book.Add(new Book
        //        {
        //            ISBN = "978-0544003415",
        //            Title = "The Lord of the Rings",
        //            Author = "J.R.R. Tolkien",
        //            Language = "English",
        //            Pages = 1216,
        //            Publisher = publisher
        //        });
        //        context.Book.Add(new Book
        //        {
        //            ISBN = "978-0547247762",
        //            Title = "The Sealed Letter",
        //            Author = "Emma Donoghue",
        //            Language = "English",
        //            Pages = 416,
        //            Publisher = publisher
        //        });

        //        // Saves changes
        //        context.SaveChanges();
        //        return Ok();
            
        //}
    }
}
