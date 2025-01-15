

namespace UyariSoftBk.Modules.Product.Domain.Entity
{
    public record CategoryEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ProductCategoryEntity> ProductCategories { get; set; }
    }
}