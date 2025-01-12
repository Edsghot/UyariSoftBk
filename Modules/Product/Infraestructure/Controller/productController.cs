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

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        await _productInputPort.GetAllAsync();
        var response = _productOutPort.GetResponse;

        return Ok(response);
    }

    [HttpGet("GetById/{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        await _productInputPort.GetById(id);
        var response = _productOutPort.GetResponse;

        return Ok(response);
    }

    // GET api/<ResearchController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ResearchController>/AddParticipant
    [HttpPost("AddParticipant")]
    public async Task<IActionResult> AddParticipant([FromBody] InsertParticipantDto participantDto)
    {
       
            await _productInputPort.AddParticipant(participantDto);
            return Ok(_productOutPort.GetResponse); 
    }
    
    
    [HttpPost("TakeAttendance")]
    public async Task<IActionResult> TakeAttendance([FromBody] InsertAttendanceDto participantDto)
    {
       
        await _productInputPort.TakeAttendance(participantDto);
        return Ok(_productOutPort.GetResponse); 
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