using Microsoft.AspNetCore.Mvc;
using UyariSoftBk.Model.Dtos.dataProduct;
using UyariSoftBk.Model.Dtos.Order;
using UyariSoftBk.Model.Dtos.Product;
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
    
    [HttpGet("GetByIdProduct/{idProduct:int}")]
    public async Task<ActionResult> GetByIdProduct([FromRoute] int idProduct){
    
        await _productInputPort.GetByIdProduct(idProduct);

        var products = _productOutPort.GetResponse;
        return Ok(products);
    }
    
    [HttpPost("InsertoOrder")]
    public async Task<ActionResult> InsertOrder([FromBody] InsertOrderDto data)
    {
        await _productInputPort.InsertOrder(data);
        var products = _productOutPort.GetResponse;
        return Ok(products);
    }
    
    [HttpGet("LastOrderPayment")]
    public async Task<ActionResult> LastOrderPayment(){
    
        await _productInputPort.LastOrderPayment();

        var response = _productOutPort.GetResponse;
        return Ok(response);
    }
    
    [HttpPut("UpdateOrderStatus/{id:int}")]
    public async Task<ActionResult> UpdateOrderStatus([FromRoute] int id){
        await _productInputPort.UpdateOrderStatus(id);
        var response = _productOutPort.GetResponse;
        return Ok(response);
    }
    
    [HttpPost("RegisterProduct")]
    public async Task<ActionResult> RegisterProduct([FromForm]InsertProductDto data){
        await _productInputPort.RegisterProduct(data);
        var response = _productOutPort.GetResponse;
        return Ok(response);
    }
    
    [HttpPost("subirImage")]
    public async Task<ActionResult> ImageUpload([FromForm]ImageDto data){
        await _productInputPort.ImageUpload(data);
        var response = _productOutPort.GetResponse;
        return Ok(response);
    }
}