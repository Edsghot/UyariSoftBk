namespace UyariSoftBk.Model.Dtos.Product;

public class OrderDetailDto
{
    public int OrderDetailId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public OrderDto Order { get; set; }
    public ProductDto Product { get; set; }
}