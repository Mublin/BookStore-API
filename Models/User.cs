namespace BookStore_API.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Username { get; set; } = null!;
    public string Role { get; set; } = "customer";
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime? Updated { get; set; }
    public ICollection<RefreshToken> RefreshTokens { get; set; } = [];
    public required Hash Hash { get; set; }
    public ICollection<Order> Order { get; set; } = [];
}
