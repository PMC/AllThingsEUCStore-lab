using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApi.Entities;

[Table("Orders")]
public class Order
{
    public int OrderId { get; set; }

    public required int CustomerId { get; set; } //just for reference, customer info needs to be archived in this record

    public required DateTime OrderDate { get; set; } = DateTime.UtcNow;

    public required string CustomerName { get; set; }
    public string? CustomerEmail { get; set; }
    //public string CustomerPhone { get; set; }
    public string? CustomerAddress1 { get; set; }
    public string? CustomerAddress2 { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalAmount { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

}
