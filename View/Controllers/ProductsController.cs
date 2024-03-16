using DAL.Repositories.Implementations;
using Microsoft.AspNetCore.Mvc;
using DAL.Entities.Contexts;
using DAL.Entities.Models;
using View.ViewModels;

namespace View.Controllers
{
    public class ProductsController : Controller
    {
        private readonly UnitOfWork _unitOfWork = new();

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _unitOfWork.ProductRepository.GetAllAsync();
            return View(products);
        }

        public IActionResult Add()
        {
            return View();  
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductVM productVM)
        {
            var product = new Product
            {
                Name = productVM.Name,
                Description = productVM.Description,
                Price = productVM.Price,
                Rating = productVM.Rating
            };

            await _unitOfWork.ProductRepository.AddAsync(product);
            return RedirectToAction("All", "Products");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _unitOfWork.ProductRepository
                .GetByIdAsync(id);
            return View(product);
        }

        [HttpPost]  
        public async Task<IActionResult> Edit(Product productVM)
        {
            var product = await _unitOfWork.ProductRepository
                .GetByIdAsync(productVM.Id);

            product.Name = productVM.Name;
            product.Description = productVM.Description;
            product.Price = productVM.Price;
            product.Rating = productVM.Rating;

            await _unitOfWork.ProductRepository
                .UpdateAsync(product);

            return RedirectToAction("All", "Products");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Product productVM)
        {
            await _unitOfWork.ProductRepository
                .DeleteAsync(productVM.Id);
            return RedirectToAction("All", "Products");
        }
    }
}
