using DAL.Entities.Contexts;
using DAL.Entities.Models;
using DAL.Repositories.Implementations;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using var context = new MarketplaceDbContext();
var sp = new SellersProductsRepository(context);
var spt = await sp.GetByIdAsync(2);

Console.WriteLine(spt!.SellerId);

//var selected = await (from s in context.Seller
//                      join sp in context.SellersProducts on s.SellerId equals sp.SellerId
//                      join p in context.Product on sp.ProductId equals p.ProductId
//                      select new
//                      {
//                          SellerName = s.SellerName,
//                          ProductName = p.ProductName,
//                          ProductDescription = p.ProductDescription,
//                          ProductPrice = p.ProductPrice
//                      }).ToListAsync();

//foreach (var e in total)
//{
//    Console.WriteLine($"{e.EmployeeName} {e.EmployeeSalary}");
//}
