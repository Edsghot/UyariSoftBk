namespace UyariSoftBk.Model.Dtos.Product;

public class OrderDto
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    
    public bool Paid { get; set; }
    
    public DateTime PaidDate { get; set; }    

}