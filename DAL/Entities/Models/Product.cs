namespace DAL.Entities.Models;

public class Product : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public double Rating { get; set; }
    public ICollection<Seller>? Sellers { get; set; } = [];
    public ICollection<Order>? Orders { get; set; } = [];
}
