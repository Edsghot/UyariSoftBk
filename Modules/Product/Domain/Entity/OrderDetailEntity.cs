

namespace UyariSoftBk.Modules.Product.Domain.Entity;

public record OrderDetailEntity
{
    public int OrderDetailId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public OrderEntity Order { get; set; }
    public ProductEntity Product { get; set; }

}