namespace UyariSoftBk.Model.Dtos.Product;

public record ProductImageDto
{
    public int ImageId { get; set; }
    public int ProductId { get; set; }
    public string ImageUrl { get; set; }
    public ProductDto Product { get; set; }
}