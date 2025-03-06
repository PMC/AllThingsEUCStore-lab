using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApi.Entities;

[Table("Products")]
public class Product
{
    public int ProductId { get; set; }
    public required string ProductName { get; set; }
    public string? Brand { get; set; } //For filtering by brand
    //public bool? HasSuspension { get; set; }
    // For filtering by suspension
    //public int? BatteryVoltage { get; set; } //For filtering by battery voltage.

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Price { get; set; }

    public int? StockQuantity { get; set; }
    public string? ImageUrl { get; set; }

    public string? Description { get; set; }

    public ICollection<Category> Categories { get; } = new List<Category>();

    // Navigation property for many-to-many relationship
    //        public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();


    //public ICollection<ProductProp> ProductProperties { get; set; } = new List<ProductProp>();
}