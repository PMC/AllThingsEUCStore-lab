using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApi.Entities;

[Table("Orders")]
public class Order
{
    public int OrderId { get; set; }

    public required string CustomerId { get; set; } //just for reference, customer info needs to be archived in this record
    public required DateTime OrderDate { get; set; } = DateTime.UtcNow;

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalAmount { get; set; }

    public string? Status { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

}
