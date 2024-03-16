using DAL.Entities.Contexts;
using DAL.Entities.Models;

namespace DAL.Repositories.Implementations;

public class UnitOfWork
{
    private readonly MarketplaceDbContext _context = new();

    private BaseRepository<Buyer>? _buyerRepository;
    private BaseRepository<Employee>? _employeeRepository;
    private BaseRepository<Order>? _orderRepository;
    private BaseRepository<PickupPoint>? _pickupPointRepository;
    private BaseRepository<Product>? _productRepository;
    private BaseRepository<Seller>? _sellerRepository;

    public BaseRepository<Buyer> BuyerRepository =>
        _buyerRepository ??= new BaseRepository<Buyer>(_context);

    public BaseRepository<Employee> EmployeeRepository =>
         _employeeRepository ??= new BaseRepository<Employee>(_context);

    public BaseRepository<Order> OrderRepository =>
        _orderRepository ??= new BaseRepository<Order>(_context);

    public BaseRepository<PickupPoint> PickupPointRepository =>
        _pickupPointRepository ??= new BaseRepository<PickupPoint>(_context);

    public BaseRepository<Product> ProductRepository =>
        _productRepository ??= new BaseRepository<Product>(_context);

    public BaseRepository<Seller> SellerRepository =>
        _sellerRepository ??= new BaseRepository<Seller>(_context);
}
