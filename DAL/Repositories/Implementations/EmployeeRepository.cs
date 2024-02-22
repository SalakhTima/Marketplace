using DAL.Entities.Contexts;
using DAL.Entities.Models;

namespace DAL.Repositories.Implementations;

public class EmployeeRepository : BaseRepository<Employee>
{
    public EmployeeRepository(MarketplaceDbContext context) 
        : base(context) { }
}
