using Microsoft.AspNetCore.Mvc;
using StoreAppError.Repository;

namespace StoreAppError.Controllers;
[ApiController]
[Route("/api/products")]
public class ProductsController:ControllerBase
{
    private readonly ProductRepository _productRepository;

    public ProductsController(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    [HttpGet]
    public IActionResult GetAllProduct(){
        return Ok(_productRepository.GetAllProducts());
    }
    [HttpGet("{id:int}")]
    public IActionResult GetOne(int id){
        return Ok(_productRepository.GetOneProduct(id));
    }
}