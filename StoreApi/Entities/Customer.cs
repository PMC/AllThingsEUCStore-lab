using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApi.Entities;

[Table("Customers")]
public class Customer
{
    public int CustomerId { get; set; }

    public required string CustomerName { get; set; }
    public string? Email { get; set; }
    //public string CustomerPhone { get; set; }
    public string? CustomerAddress1 { get; set; }
    public string? CustomerAddress2 { get; set; }
}
