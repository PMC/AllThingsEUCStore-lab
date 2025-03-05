using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApi.Entities;

[Table("Customers")]
public class Customer
{
    public int Id { get; set; }

    public required string Name { get; set; }
    public string? Email { get; set; }
    //public string CustomerPhone { get; set; }
    public string? CustomerAddress1 { get; set; }
    public string? CustomerAddress2 { get; set; }
    public string? CustomerAddress3 { get; set; }
}
