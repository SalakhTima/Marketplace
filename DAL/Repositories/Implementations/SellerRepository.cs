using DAL.Entities.Contexts;
using DAL.Entities.Models;

namespace DAL.Repositories.Implementations;

public class SellerRepository : BaseRepository<Seller>
{
    public SellerRepository(MarketplaceDbContext context) 
        : base(context) { }
}
