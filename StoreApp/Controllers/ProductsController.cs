using Microsoft.AspNetCore.Mvc;
using StoreApp.Repository;

namespace StoreApp.Controllers;

[ApiController]
[Route("api/products")]
class ProductsController : ControllerBase{ //localhost/api/products adresine gidilirse ProductsCntroller newlenir
    //Dependency Injection (DI) , IoC
    private readonly ProductRepository _productRepository;

    public ProductsController(ProductRepository productRepository)
    {
        _productRepository = productRepository; //Resolve
    }

    [HttpGet]
    public IActionResult GetAllProducts(){
        return Ok(_productRepository.GetAllProducts());
        
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetOneProducts(int id){
        var result = _productRepository.GetOneProduct(id);
        return Ok(result);
        
    }
}