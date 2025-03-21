using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StoreApi.Entities;

[Table("OrderDetails")]
public class OrderDetail
{
    public int OrderDetailId { get; set; }
    public int OrderId { get; set; }
    [JsonIgnore]
    public Order Order { get; set; } = null!; // Required reference navigation to principal

    public int ProductId { get; set; }
    public string ProductName { get; set; }
    [JsonIgnore]
    public Product Product { get; set; } = null!; // Required reference navigation to principal
    public required int Quantity { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}
