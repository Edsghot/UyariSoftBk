namespace UyariSoftBk.Model.Dtos.dataProduct;

public record InsertProductDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public IFormFile Cover { get; set; }
    public IFormFile Icon { get; set; }
    public decimal Discount { get; set; }
    public double Rating { get; set; }
    public int NumberOfReviews { get; set; }
    public string InstallationIntructions { get; set; }
    public string Version { get; set; }
    public string Developer { get; set; }
    public string WebSite { get; set; }
    public int IdCategory { get; set; }
    public List<IFormFile>  Images { get; set; }
    public List<string> Githubs { get; set; }
}