namespace StoreApi.Entities;

public class Category
{
    public int Id { get; set; }

    public required string Name { get; set; }

    //public int? ParentCategoryId { get; set; }

    //public Category? ParentCategory { get; set; }

    public string? Description { get; set; }

    //public ICollection<Category> Children { get; set; } = new List<Category>();

    public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
}