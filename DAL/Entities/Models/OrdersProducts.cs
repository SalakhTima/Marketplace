using Microsoft.EntityFrameworkCore;

namespace DAL.Entities.Models;

[Keyless]
public class OrdersProducts
{
    public int OrdersId { get; set; }
    public int ProductId { get; set; }
}
