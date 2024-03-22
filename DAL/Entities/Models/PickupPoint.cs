namespace DAL.Entities.Models;

public class PickupPoint 
{
    public int Id { get; set; }
    public string Address { get; set; }
    public double Rating { get; set; }
    public int? EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    public Order? Order { get; set; }    
}
