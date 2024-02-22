using DAL.Entities.Contexts;
using DAL.Entities.Models;

namespace DAL.Repositories.Implementations;

public class BuyerRepository : BaseRepository<Buyer>
{
    public BuyerRepository(MarketplaceDbContext context) 
        : base(context) { }
}
