namespace UyariSoftBk.Modules.Product.Domain.Entity;

public record UserEntity
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<OrderEntity> Orders { get; set; }

}