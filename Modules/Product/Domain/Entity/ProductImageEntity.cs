
namespace UyariSoftBk.Modules.Product.Domain.Entity;

public record ProductImageEntity
{
    
    public int ImageId { get; set; }
    public int ProductId { get; set; }
    public string ImageUrl { get; set; }
    public ProductEntity Product { get; set; }

}