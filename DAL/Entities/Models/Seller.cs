namespace DAL.Entities.Models;

public class Seller : BaseEntity
{
    public string FullName { get; set; }
    public double Rating { get; set; }
    public ICollection<Product>? Products { get; set; } = [];
}
