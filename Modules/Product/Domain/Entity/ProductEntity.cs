namespace UyariSoftBk.Modules.Product.Domain.Entity
{
    public class ProductEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime UploadDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public string Cover { get; set; }
        public string Icon { get; set; }
        public int IdImages { get; set; }
        public int IdGitHub { get; set; }
        
        public decimal Discount { get; set; }
        public double Rating { get; set; }
        public int NumberOfReviews { get; set; }
        public string InstallationIntructions { get; set; }
        public string Version { get; set; }
        public string Developer { get; set; }
        public string WebSite { get; set; }
        public ICollection<ProductCategoryEntity> ProductCategories { get; set; }
    }
}