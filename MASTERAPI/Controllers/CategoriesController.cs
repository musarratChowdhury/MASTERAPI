using MASTERAPI.Model;
using MASTERAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MASTERAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _CategoryService;
        public CategoriesController(ICategoryService CategoryService)
        {
            _CategoryService = CategoryService;
        }
        [HttpGet]
        public string GetCategorys()
        {
            return "Ok";
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategoryAsync(Category Category)
        {
            try
            {
                var result = await _CategoryService.AddCategoryAsync(Category);
                if (result)
                {
                    return Ok(result);
                }
            }
            catch (Exception)
            {

                return BadRequest("Failed to add new Category");
            }
            return BadRequest();

        }
    }
}
