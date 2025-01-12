namespace UyariSoftBk.Model.Dtos.Product;

public class CategoryDto
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<ProductDto> Products { get; set; }
}