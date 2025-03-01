using Microsoft.AspNetCore.Mvc;
using StoreApi.Entities;

namespace StoreApi.Controllers
{
    [Route("StoreApi/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static readonly List<Product> products = [
                   new Product()
            {
                Id = 1,
                Name = "Gotway G25",
                Brand = "Gotway",
                Description = "an EUC!",
                ShortDescription = "one liner",

                Price = 12000,
                StockQuantity = 5
            }

               ];


        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product is null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> AddProduct(Product product)
        {
            if (product is null)
            {
                return BadRequest();
            }

            product.Id = products.Max(p => p.Id) + 1;
            products.Add(product);

            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
            var oldProduct = products.FirstOrDefault(p => p.Id == id);
            if (oldProduct is null)
            {
                return NotFound();
            }

            oldProduct.Name = updatedProduct.Name;
            oldProduct.ShortDescription = updatedProduct.ShortDescription;
            oldProduct.Brand = updatedProduct.Brand;
            oldProduct.Description = updatedProduct.Description;
            oldProduct.ImageUrl = updatedProduct.ImageUrl;
            oldProduct.Price = updatedProduct.Price;
            oldProduct.StockQuantity = updatedProduct.StockQuantity;

            return Ok(oldProduct);

        }
    }
}
