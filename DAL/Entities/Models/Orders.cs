using System.ComponentModel.DataAnnotations;

namespace DAL.Entities.Models;

public class Orders
{
    [Key]
    public int OrdersId { get; set; }

    [Required]
    public DateOnly? OrdersRegistrationDate { get; set; } = null!;

    [Required]
    public DateOnly? OrdersReceivingDate { get; set; } = null!;
    public int OrdersPickupPoint { get; set; }
    public int OrdersBuyer { get; set; }
}
