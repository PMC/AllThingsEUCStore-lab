using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApi.Entities;

[Table("Orders")]
public class Order
{
    public int Id { get; set; }

    public required int CustomerId { get; set; } //just for reference, customer info needs to be archived in this record

    public required DateOnly OrderDate { get; set; }

    public required string CustomerName { get; set; }
    public string? CustomerEmail { get; set; }
    //public string CustomerPhone { get; set; }
    public string? CustomerAddress1 { get; set; }
    public string? CustomerAddress2 { get; set; }
    public string? CustomerAddress3 { get; set; }

    //public ICollection<OrderProduct> OrderedProducts { get; set; } = new List<OrderProduct>();

}
