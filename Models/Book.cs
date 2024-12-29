namespace BookStore_API.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Author { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? LastUpdatedDate { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public Category Category { get; set; }
}