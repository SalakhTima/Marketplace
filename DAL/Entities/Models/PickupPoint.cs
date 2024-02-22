using System.ComponentModel.DataAnnotations;

namespace DAL.Entities.Models;

public class PickupPoint
{
    [Key]
    public int PickupPointId { get; set; }

    [Required]
    public string? PickupPointAddress { get; set; } = null!;

    [Required]
    public double? PickupPointRating { get; set; } = null!;
    public int PickupPointEmployee { get; set; }
}
