using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApi.Entities;

public class OrderProduct
{
    public int Id { get; set; }
    public required int OrderId { get; set; }
    public required int ProductId { get; set; }
    public required int Quantity { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}
