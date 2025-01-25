namespace UyariSoftBk.Modules.Product.Domain.Entity;

public record OrderEntity
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
}


