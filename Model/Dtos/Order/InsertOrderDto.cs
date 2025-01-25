namespace UyariSoftBk.Model.Dtos.Order;

public record InsertOrderDto
{
        public int UserId { get; set; }
        public decimal TotalAmount { get; set; }
}