

namespace UyariSoftBk.Modules.Product.Domain.Entity;

public record CategoryEntity
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<ProductEntity> Products { get; set; }
}