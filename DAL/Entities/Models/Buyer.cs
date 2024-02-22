using System.ComponentModel.DataAnnotations;

namespace DAL.Entities.Models;

public class Buyer
{
    [Key]
    public int BuyerId { get; set; }

    [Required]
    public string? BuyerName { get; set; } = null!;
}
