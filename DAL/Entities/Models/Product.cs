using System.ComponentModel.DataAnnotations;

namespace DAL.Entities.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    public string? ProductName { get; set; } = null!;

    [Required]
    public string? ProductDescription { get; set; } = null!;

    [Required]
    public int? ProductPrice { get; set; } = null!;

    [Required]
    public double? ProductRating { get; set; } = null!;
}
