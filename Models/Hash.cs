namespace BookStore_API.Models;

public class Hash
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string HashValue { get; set; } = string.Empty;
}