using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private List<Product> products = new List<Product>
        {
            new Product(1, "Nintendo Switch", "Gaming console from Nintendo which can be played both handheld and connected to an external display.", "Electronics", 279),
            new Product(2, "Playstation 5", "The newest gaming console from Sony with awesome graphics.", "Electronics", 499),
            new Product(3, "Levi's 501 jeans", "The classic jeans.", "Clothing", 99),
            new Product(4, "Ben & Jerry's", "Delicious ice cream for Ben & Jerry's.", "Food", 5),
            new Product(5, "Evergood Coffee", "The classic and dull coffee that you all know.", "Food", 4)
        };

        // GET: api/values
        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            return Ok(products);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetSingleProduct(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product is null)
            {
                return BadRequest("Product not found");
            }
            return Ok(product);
        }
    }
}

