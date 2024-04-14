using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice.Entities;

namespace Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //LibraryContext context;
        private readonly LibraryContext context;

        //public ProductController(LibraryContext context)
        //{
        //    this.context = context;
        //}
        public ProductController()
        {
            context=new LibraryContext();
        }
        [HttpPost,Route("Add")]
        public IActionResult Add(Product product)
        {

            // Creates the database if not exists
           
            context.Products.Add(product);
            context.SaveChanges();
            return Ok(product);

        }
        [HttpPut,Route("EditProduct")]
        public IActionResult Edit(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
            return Ok(product);
        }
        [HttpGet,Route("GetAll")]
        public IActionResult GetAll()
        {
            var products = context.Products;
            return Ok(products);
        }
        [HttpGet,Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            var product=context.Products.SingleOrDefault(p=> p.Id == id);
            return Ok(product);
        }
        [HttpDelete,Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var product=context.Products.SingleOrDefault(p=>p.Id==id);
            context.Products.Remove(product);
            context.SaveChanges();
            return Ok(product);
        }
    }
}
