using Microsoft.AspNetCore.Mvc;
using StoreApi.Entities;

namespace StoreApi.Controllers;

[Route("StoreApi/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private static List<Product> products = new()
    {
        new Product
        {
            ProductId = 1,
            ProductName = "16X",
            Brand = "Kingsong",
            Description =
                "Kingsong 16X is the flagship model thanks to its powerful motor and high capacity battery. 45km/h top speed is achievable due to a 2kW motor and 1554Wh battery. Large battery gives a maximum range of 150km in ideal conditions – in practice, a rider weighing 80kg and going at moderate/high speed will get around 100+km of range. Its 16-inch wheel also houses a wider tire for extra stability while riding at high speeds which makes it one of the easiest electric unicycles to ride on. A 16-inch wheel is easy to maneuver but also absorbs bumps in the road for a smooth ride. The 16X has an extendable handle for easy transport when not in use. It connects to the KS app over Bluetooth, allowing the user to adjust ride softness, LED lights, and warning signals. Additionally, it is equipped with Bluetooth speakers for music."
        },
        new Product
        {
            ProductId = 2,
            ProductName = "16S",
            Brand = "Kingsong",
            Description =
                "The Kingsong 16S is designed for riders who need a practical and comfortable wheel for city commuting or light off-road riding. With a top speed of 35km/h, it is ideal for riders who prefer a balance between speed and control. The 75km range makes it a reliable companion for daily activities, though actual distance depends on rider weight and riding style. The 16-inch wheel provides a smooth and stable ride, making it more comfortable than smaller models. The 16S connects to the Kingsong app via Bluetooth for ride adjustments, LED customization, and warning signals. It also features built-in Bluetooth speakers."
        },
        new Product
        {
            ProductId = 3,
            ProductName = "14M and 14S",
            Brand = "Kingsong",
            Description =
                "Kingsong 14M and 14S share the same design, differing mainly in battery size and motor power. The 14M is the lightest option, while the 14S offers a longer range. Their lightweight construction makes them easy to carry, ideal for those who frequently navigate stairs or need a portable solution. The 14-inch wheel is maneuverable and suitable for smaller riders. Both models are available in white and black colors."
        },
        new Product
        {
            ProductId = 4,
            ProductName = "S22 Eagle",
            Brand = "Kingsong",
            Description =
                "The Kingsong S22 Eagle is a 20\" suspension wheel with significant upgrades. It features a 20\" wheel with a 3\" tire, a range up to 200km, a peak motor of 7500W, a 2220Wh battery, fast charging, and advanced suspension. It's designed for various terrains with adjustable compression and damping."
        },
        new Product
        {
            ProductId = 5,
            ProductName = "S18",
            Brand = "Kingsong",
            Description =
                "The Kingsong S18 is an 18\" unicycle with a visible shock absorber. It features a 200 x 57 mm shock, a handle for easy carrying, automatic front light, softening pads, rear turn and brake lights, 21700 battery cells, and app connectivity for ride customization. It's designed for both city and off-road riding."
        },
        new Product
        {
            ProductId = 6,
            ProductName = "18L",
            Brand = "Kingsong",
            Description =
                "The Kingsong 18L is a reliable 18\" unicycle with a maximum speed of 50 km/h and a range of approximately 105km. It features an 18\" wheel, app connectivity for ride control and system data, and a built-in handle for easy transport."
        },
        new Product
        {
            ProductId = 7,
            ProductName = "18XL",
            Brand = "Kingsong",
            Description =
                "The Kingsong 18XL is a reliable 18\" unicycle with a maximum speed of 50 km/h and a range of approximately 150km. It features an 18\" wheel, app connectivity for ride control and system data, and a built-in handle for easy transport."
        },
        new Product
        {
            ProductId = 8,
            ProductName = "Veteran Lynx",
            Brand = "LeaperKim",
            Description = "An agile and responsive top-of-the-line 20\" off-road suspension wheel. Available in 3 versions: 70LBS, 66LBS, 62 LBS. Battery: 2700W (Samsung 21700 50S), Motor: 3200W (8000W peak), Weight: 40kg, 20\" knobby tubeless tire, Fast charging up to 15A (1.5h), Progressive suspension."
        },
        new Product
        {
            ProductId = 9,
            ProductName = "Veteran Patton",
            Brand = "LeaperKim",
            Description = "A powerful and agile 16\" (realistically 18\") off-road wheel. Built tough for off-roading. 3000W motor (7000W peak), 16\" knobby tubeless tire, 2,220Wh Samsung 50E or 50S battery, Fastace fork suspension with 80mm travel, Weight: 39kg."
        },
        new Product
        {
            ProductId = 10,
            ProductName = "Veteran Sherman-S",
            Brand = "LeaperKim",
            Description = "Veteran’s first suspension wheel with a massive 3,600Wh battery pack, 3,000W high-torque motor (7KW peak), New generation controller (24x MOSFETs, 680A peak load), Adjustable suspension with up to 90mm travel, 20\" knobby tire, Integrated seat & fender."
        },
        new Product
        {
            ProductId = 11,
            ProductName = "Veteran Sherman Max",
            Brand = "LeaperKim",
            Description = "Performance-focused wheel with a new 3600Wh battery, 2800W motor with 20% more torque, Thicker motor phase wires, Re-designed pedal bracket. No Bluetooth speakers, but 230km of range."
        },
        new Product
        {
            ProductId = 12,
            ProductName = "Veteran Abrams",
            Brand = "LeaperKim",
            Description = "A long-range cruising wheel with a 3500W motor, 22\" knobby tubeless tire, 2,700Wh Samsung 21700 50E battery, IP65 water resistance. Originally designed for seated riding and long-range trips."
        }
    };


    [HttpGet]
    public ActionResult<List<Product>> GetProducts()
    {
        return Ok(products);
    }

    [HttpGet("{id}")]
    public ActionResult<Product> GetProductById(int id)
    {
        var product = products.FirstOrDefault(p => p.ProductId == id);

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

        product.ProductId = products.Max(p => p.ProductId) + 1;
        products.Add(product);

        return CreatedAtAction(nameof(GetProductById), new { id = product.ProductId }, product);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, Product updatedProduct)
    {
        var oldProduct = products.FirstOrDefault(p => p.ProductId == id);
        if (oldProduct is null)
        {
            return NotFound();
        }

        oldProduct.ProductName = updatedProduct.ProductName;
        oldProduct.Brand = updatedProduct.Brand;
        oldProduct.Description = updatedProduct.Description;
        oldProduct.ImageUrl = updatedProduct.ImageUrl;
        oldProduct.Price = updatedProduct.Price;
        oldProduct.StockQuantity = updatedProduct.StockQuantity;

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var productToBeDeleted = products.FirstOrDefault(p => p.ProductId == id);
        if (productToBeDeleted is null)
        {
            return NotFound();
        }

        products.Remove(productToBeDeleted);
        return Ok();
    }
}