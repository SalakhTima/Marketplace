namespace DAL.Entities.Models;

public class Buyer : BaseEntity
{
    public string FullName { get; set; }
    public Order? Order { get; set; }
}
