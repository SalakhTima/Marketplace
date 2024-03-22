namespace DAL.Entities.Models;

public class Buyer 
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public Order? Order { get; set; }
}
