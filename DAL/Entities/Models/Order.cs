namespace DAL.Entities.Models;

public class Order : BaseEntity
{
    public int Id { get; set; }
    public DateOnly CreationDate { get; set; }
    public DateOnly ReceivingDate { get; set; }
    public int? PickupPointId { get; set; }
    public PickupPoint? PickupPoint { get; set; }
    public int? BuyerId { get; set; }
    public Buyer? Buyer { get; set; }
    public ICollection<Product>? Products { get; set; }
}
