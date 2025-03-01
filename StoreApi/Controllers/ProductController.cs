using Microsoft.AspNetCore.Mvc;

namespace StoreApi.Controllers
{
    [Route("StoreApi/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static readonly List<StoreProduct> products = [
                   new StoreProduct()
            {
                Id = 1,
                Name = "Gotway G25",
                Brand = "Gotway",
                Description = "an EUC!",
                BatteryVoltage = 86,
                HasSuspension = false,
                Price = 12000,
                StockQuantity = 5
            }

               ];


        [HttpGet]
        public ActionResult<List<StoreProduct>> GetProducts()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<StoreProduct> GetProductById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product is null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public ActionResult<StoreProduct> AddProduct(StoreProduct product)
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
        public IActionResult UpdateProduct(int id, StoreProduct updatedProduct)
        {
            var oldProduct = products.FirstOrDefault(p => p.Id == id);
            if (oldProduct is null)
            {
                return NotFound();
            }

            oldProduct.Name = updatedProduct.Name;
            oldProduct.BatteryVoltage = updatedProduct.BatteryVoltage;
            oldProduct.Brand = updatedProduct.Brand;
            oldProduct.Description = updatedProduct.Description;
            oldProduct.HasSuspension = updatedProduct.HasSuspension;
            oldProduct.ImageUrl = updatedProduct.ImageUrl;
            oldProduct.Price = updatedProduct.Price;
            oldProduct.StockQuantity = updatedProduct.StockQuantity;

            return NoContent();

        }
    }
}
