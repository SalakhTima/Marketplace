using DAL.Entities.Contexts;
using DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class SellersProductsRepository : BaseRepository<SellersProducts>
{
    public SellersProductsRepository(MarketplaceDbContext context) 
        : base(context) { }

    public async Task DeleteAsync(int sellerId, int productId)
    {
        var sellerProduct = await _context.SellersProducts
            .FirstOrDefaultAsync(sp => 
            sp.SellerId == sellerId && sp.ProductId == productId);
        if (sellerProduct == null) return;
        _context.SellersProducts.Remove(sellerProduct);
        await _context.SaveChangesAsync();
    }

    public override async Task DeleteAsync(int id) =>
        await Task.CompletedTask;

    public async Task<SellersProducts?> GetByIdAsync(int sellerId, int productId) =>
        await _context.SellersProducts
        .FirstOrDefaultAsync(sp => 
        sp.SellerId == sellerId && sp.ProductId == productId);

    public override async Task<SellersProducts?> GetByIdAsync(int id) =>
        await Task.FromResult<SellersProducts>(null!);

    public override async Task UpdateAsync(SellersProducts entity) =>
        await Task.CompletedTask;
}
