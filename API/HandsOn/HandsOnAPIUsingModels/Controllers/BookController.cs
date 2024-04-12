using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIUsingModels.Models;
namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public static List<Book> books = new List<Book>()
        {
            new Book(){Id=1, Title="Book 1",Price=500},
             new Book(){Id=2, Title="Book 2",Price=1500},
              new Book(){Id=3, Title="Book 3",Price=2500},
               new Book(){Id=4, Title="Book 4",Price=3500},
        };
        //endpoints
        //1.GetAllBooks
        [HttpGet,Route("GetBooks")]
        public List<Book> GetBooks()
        {
            return books;
        }
        //2. GetBookById
        [HttpGet,Route("GetBook/{id}")]
        public Book GetBook(int id)
        {
            var book=books.SingleOrDefault(book => book.Id == id);
            return book;
        }
        //3.AddBook
        [HttpPost,Route("AddBook")]
        public string Add(Book book)
        {
            books.Add(book);
            return "Book Added";
        }
        [HttpDelete,Route("DeleteBook/{id}")]
        public string Delete(int id)
        {
            var book = books.SingleOrDefault(book => book.Id == id);
            books.Remove(book);
            return "Book Deleted";
        }
    }
}
