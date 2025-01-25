namespace UyariSoftBk.Model.Dtos.Product;

public record ProductImageDto
{
    public int? ProductImageId { get; set; }
    public string ImageUrl { get; set; }
    public int? ProductId { get; set; }
}