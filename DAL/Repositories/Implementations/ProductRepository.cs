using DAL.Entities.Contexts;
using DAL.Entities.Models;

namespace DAL.Repositories.Implementations;

public class ProductRepository : BaseRepository<Product>
{
    public ProductRepository(MarketplaceDbContext context) 
        : base(context) { }
}
