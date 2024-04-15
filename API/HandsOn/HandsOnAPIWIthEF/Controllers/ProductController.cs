using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIWIthEF.Repositories;
using HandsOnAPIWIthEF.Entities;
namespace HandsOnAPIWIthEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController()
        {
            _productRepository = new ProductRepository(); //create object to productrepository class
        }
        //endpoints
        [HttpPost,Route("AddProduct")]
        public IActionResult Add([FromBody]Product product)
        {
            try
            {
                _productRepository.Add(product);
                return Ok(product); //return as json data
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet,Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
               var products= _productRepository.GetAll();
                return Ok(products); //return as json data
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet,Route("GetById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var product = _productRepository.GetById(id);
                return Ok(product); //return as json data
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut,Route("Edit")]
        public IActionResult Edit([FromBody] Product product)
        {
            try
            {
                _productRepository.Update(product);
                return Ok(product); //return as json data
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete,Route("DeleteProduct/{id}")]
        public IActionResult Delete(int id)
        {
            _productRepository.Delete(id);
            return Ok(new JsonResult("Record Deleted"));
        }
    }
}
