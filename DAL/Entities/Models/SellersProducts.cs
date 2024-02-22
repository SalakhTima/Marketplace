using Microsoft.EntityFrameworkCore;

namespace DAL.Entities.Models;

[Keyless]
public class SellersProducts
{
    public int SellerId { get; set; }
    public int ProductId { get; set; }
}
