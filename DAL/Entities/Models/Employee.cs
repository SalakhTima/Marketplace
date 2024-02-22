using System.ComponentModel.DataAnnotations;

namespace DAL.Entities.Models;

public class Employee
{
    [Key]
    public int EmployeeId { get; set; }

    [Required]
    public string EmployeeName { get; set; } = null!;

    [Required]
    public int? EmployeeSalary { get; set; } = null!;
}
