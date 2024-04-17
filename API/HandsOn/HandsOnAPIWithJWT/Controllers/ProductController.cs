using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIWithJWT.Repositories;
using HandsOnAPIWithJWT.Entities;
using Microsoft.AspNetCore.Authorization;
namespace HandsOnAPIWithJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //endpoints
        [HttpPost,Route("AddProduct")]
        [Authorize(Roles ="Admin")]
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
        [Authorize(Roles = "Admin,Customer")]
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
        [Authorize(Roles = "Customer")]
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            _productRepository.Delete(id);
            return Ok(new JsonResult("Record Deleted"));
        }
    }
}
