namespace UyariSoftBk.Modules.Product.Domain.Entity;

public class ProductCategoryEntity
{
    public int ProductId { get; set; }
    public ProductEntity Product { get; set; }
    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; } 
}