using DAL.Entities.Contexts;
using DAL.Entities.Models;

namespace DAL.Repositories.Implementations;

public class PickupPointRepository : BaseRepository<PickupPoint>
{
    public PickupPointRepository(MarketplaceDbContext context) 
        : base(context) { }
}
