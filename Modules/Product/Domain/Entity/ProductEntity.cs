using UyariSoftBk.Modules.Event.Domain.Entity;
using UyariSoftBk.Modules.Student.Domain.Entity;
using UyariSoftBk.Modules.Teacher.Domain.Entity;

namespace UyariSoftBk.Modules.Product.Domain.Entity;

public record ProductEntity
{
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
}