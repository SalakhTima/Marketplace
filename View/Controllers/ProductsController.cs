using Microsoft.AspNetCore.Mvc;
using DAL.Entities.Models;
using View.DTOs;
using DAL.Repositories.Interfaces;

namespace View.Controllers;

[Route("/products")]
public class ProductsController : Controller
{
    private readonly IBaseRepository<Product> _productRepository;

    public ProductsController(IBaseRepository<Product> productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet("all")]
    public async Task<IActionResult> All()
    {
        var products = await _productRepository.GetAllAsync();
        return View(products);
    }

    [Route("add")]
    public IActionResult Add()
    {
        return View();  
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add(ProductDto productDto)
    { 
        var product = new Product
        {
            Name = productDto.Name,
            Description = productDto.Description,
            Price = productDto.Price,
            Rating = productDto.Rating
        };

        await _productRepository.AddAsync(product);
        return RedirectToAction("all");
    }

    [HttpGet("edit/{id:int}")]
    public async Task<IActionResult> Edit(int id)
    {
        var product = await _productRepository
            .GetByIdAsync(id);
        return View(product);
    }

    [HttpPost("edit/{id:int}")]
    public async Task<IActionResult> Edit(Product product)
    {
        var toUpdate = await _productRepository
            .GetByIdAsync(product.Id);

        toUpdate!.Name = product.Name;
        toUpdate.Description = product.Description;
        toUpdate.Price = product.Price;
        toUpdate.Rating = product.Rating;

        await _productRepository
            .UpdateAsync(toUpdate);

        return RedirectToAction("all");
    }

    [HttpPost("delete/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _productRepository.DeleteAsync(id);
        return RedirectToAction("all");
    }
}
