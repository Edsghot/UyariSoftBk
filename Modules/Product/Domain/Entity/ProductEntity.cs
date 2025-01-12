
namespace UyariSoftBk.Modules.Product.Domain.Entity
{
        public class ProductEntity
        {
                public int ProductId { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
                public decimal Price { get; set; }
                public int Stock { get; set; }
                public int CategoryId { get; set; }
                public CategoryEntity Category { get; set; }
                public ICollection<ProductImageEntity> ProductImages { get; set; }
        }
}