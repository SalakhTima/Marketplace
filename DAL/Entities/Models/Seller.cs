using System.ComponentModel.DataAnnotations;

namespace DAL.Entities.Models;

public class Seller
{
    [Key]
    public int SellerId { get; set; }
    public string? SellerName { get; set; } = null!;
    public double? SellerRating { get; set; } = null!;
}
