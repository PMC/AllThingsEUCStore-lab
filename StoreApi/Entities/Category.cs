using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApi.Entities;

[Table("Categories")]
public class Category
{
    public int CategoryId { get; set; }

    public required string CategoryName { get; set; }

    //public int? ParentCategoryId { get; set; }

    //public Category? ParentCategory { get; set; }

    public string? Description { get; set; }

    //public ICollection<Category> Children { get; set; } = new List<Category>();

    public ICollection<Product> Products { get; } = new List<Product>();
}