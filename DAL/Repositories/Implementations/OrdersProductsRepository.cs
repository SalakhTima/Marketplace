using DAL.Entities.Contexts;
using DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class OrdersProductsRepository : BaseRepository<OrdersProducts>
{
    public OrdersProductsRepository(MarketplaceDbContext context) 
        : base(context) { }

    public async Task DeleteAsync(int orderId, int productId)
    {
        var orderProduct = await _context.OrdersProducts
            .FirstOrDefaultAsync(op =>
            op.OrdersId == orderId && op.ProductId == productId);
        if (orderProduct == null) return;
        _context.OrdersProducts.Remove(orderProduct);
        await _context.SaveChangesAsync();
    }

    public override async Task DeleteAsync(int id) =>
        await Task.CompletedTask;

    public async Task<OrdersProducts?> GetByIdAsync(int orderId, int productId) =>
        await _context.OrdersProducts
        .FirstOrDefaultAsync(op =>
        op.OrdersId == orderId && op.ProductId == productId);

    public override async Task<OrdersProducts?> GetByIdAsync(int id) =>
        await Task.FromResult<OrdersProducts>(null!);

    public override async Task UpdateAsync(OrdersProducts entity) =>
        await Task.CompletedTask;
}
