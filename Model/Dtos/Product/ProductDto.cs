namespace UyariSoftBk.Model.Dtos.Product;

public record ProductDto
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
    public CategoryDto Category { get; set; }
    public List<ProductImageDto> ProductImages { get; set; }
}