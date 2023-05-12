using MASTERAPI.Model;
using MASTERAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MASTERAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public string GetProducts()
        {
            return "Ok";
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductAsync(Product product)
        {
            try
            {
                var result = await _productService.AddProductAsync(product);
                if (result)
                {
                    return Ok(result);
                }
            }
            catch (Exception)
            {

                return BadRequest("Failed to add new product");
            }
            return BadRequest();
            
        }
    }
}
