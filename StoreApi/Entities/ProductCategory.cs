using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApi.Entities;

[Table("Product_Category")]
public class ProductCategory
{
    public int Id { get; set; }

    public int? ProductId { get; set; }
    public Product? Product { get; set; }

    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
}
