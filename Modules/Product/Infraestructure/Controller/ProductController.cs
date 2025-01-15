using Microsoft.AspNetCore.Mvc;
using UyariSoftBk.Modules.Product.Application.Port;

namespace UyariSoftBk.Modules.Product.Infraestructure.Controller;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    
    private readonly IProductInputPort _productInputPort;
    private readonly IProductOutPort _productOutPort;

    public ProductController(IProductInputPort productInputPort, IProductOutPort productOutPort)
    {
        _productInputPort = productInputPort;
        _productOutPort = productOutPort;
    }
    
    [HttpGet("GetAllProduct")]
    public async Task<ActionResult> GetAll()
    {
        await _productInputPort.GetAllProducts();

        var products = _productOutPort.GetResponse;
        return Ok(products);
    }
    
    [HttpGet("GetAllCategories")]
    public async Task<ActionResult> GetAllCategories()
    {
        await _productInputPort.GetAllCategories();

        var products = _productOutPort.GetResponse;
        return Ok(products);
    }
    
    [HttpGet("GetAllByCategories/{idCategory:int}")]
    public async Task<ActionResult> GetAllByCategories([FromRoute] int idCategory){
    
        await _productInputPort.GetAllByCategories(idCategory);

        var products = _productOutPort.GetResponse;
        return Ok(products);
    }
}