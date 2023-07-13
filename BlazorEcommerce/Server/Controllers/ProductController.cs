using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private static List<Product> Products = new List<Product>();
        private readonly IProductService _products;

        public ProductController(IProductService products)
        {
            _products = products;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var products = await _products.GetProductsAsync();
            return Ok(products);
        }
    }
}
