namespace StoreApi;

public class StoreProduct
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty; //For filtering by brand
    public bool HasSuspension { get; set; } // For filtering by suspension
    public int BatteryVoltage { get; set; } //For filtering by battery voltage.
    public decimal? Price { get; set; }
    public int StockQuantity { get; set; }
    public string ImageUrl { get; set; } = string.Empty;

    // Navigation property for many-to-many relationship
    //        public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();


    //public ICollection<ProductProp> ProductProperties { get; set; } = new List<ProductProp>();
}