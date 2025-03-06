using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.Entities;

namespace StoreApi.Controllers;

[Route("StoreApi/[controller]")]
[ApiController]
public class ProductController(SqliteDbContext context) : ControllerBase
{
    private readonly SqliteDbContext _context = context;


    //string.IsNul wtc

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        return Ok(await _context.Products.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProductById(int id)
    {
        var product = await _context.Products.FindAsync(id);

        if (product is null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult<Product>> AddProduct(Product newProduct)
    {

        _context.Products.Add(newProduct);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetProductById), new { id = newProduct.ProductId }, newProduct);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, Product updatedProduct)
    {
        var product = await _context.Products.FindAsync(id);
        if (product is null)
        {
            return NotFound();
        }

        product.ProductName = updatedProduct.ProductName;
        product.Brand = updatedProduct.Brand;
        product.Description = updatedProduct.Description;
        product.ImageUrl = updatedProduct.ImageUrl;
        product.Price = updatedProduct.Price;
        product.StockQuantity = updatedProduct.StockQuantity;

        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {

        var productToBeDeleted = await _context.Products.FindAsync(id);
        if (productToBeDeleted is null)
        {
            return NotFound();
        }

        _context.Products.Remove(productToBeDeleted);

        await _context.SaveChangesAsync();
        return Ok();
    }
}