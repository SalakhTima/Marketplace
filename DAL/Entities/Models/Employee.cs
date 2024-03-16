namespace DAL.Entities.Models;

public class Employee : BaseEntity
{
    public string FullName { get; set; }
    public int Salary { get; set; }
    public PickupPoint? PickupPoint { get; set; }
}
