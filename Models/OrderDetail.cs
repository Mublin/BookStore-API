namespace BookStore_API.Models;

public class OrderDetail
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public decimal Unitprice { get; set; }
    public decimal TotalPrice => Unitprice * Quantity;

    public Order Order { get; set; }
    public Book Book { get; set; }
}
