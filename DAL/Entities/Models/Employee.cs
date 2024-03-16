namespace DAL.Entities.Models;

public class Employee : BaseEntity
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Salary { get; set; }
    public PickupPoint? PickupPoint { get; set; }
}
