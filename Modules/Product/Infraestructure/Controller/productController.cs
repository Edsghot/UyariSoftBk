using UyariSoftBk.Model.Dtos.Attedance;
using UyariSoftBk.Model.Dtos.Event;
using Microsoft.AspNetCore.Mvc;
using UyariSoftBk.Modules.Product.Application.Port;

namespace UyariSoftBk.Modules.Product.Infraestructure.Controller;

[Route("api/[controller]")]
[ApiController]
public class productController : ControllerBase
{
    private readonly IProductInputPort _productInputPort;
    private readonly IProductOutPort _productOutPort;

    public productController(IProductInputPort productInputPort, IProductOutPort productOutPort)
    {
        _productInputPort = productInputPort;
        _productOutPort = productOutPort;
    }

    

    // PUT api/<ResearchController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ResearchController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}