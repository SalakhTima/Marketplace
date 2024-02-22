using DAL.Entities.Contexts;
using DAL.Entities.Models;

namespace DAL.Repositories.Implementations;

public class OrdersRepository : BaseRepository<Orders>
{
    public OrdersRepository(MarketplaceDbContext context) 
        : base(context) { }
}
