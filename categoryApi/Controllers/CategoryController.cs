using categoryApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace categoryApi.Controllers

{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
     
        [HttpGet]
        public List<Models.Category> GetCategories()
        {
            return Category.GetCategories();
        }
    }
}