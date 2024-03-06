using Tickett.Models;
using Tickett.Business;
using Microsoft.AspNetCore.Mvc;


namespace Tickett.Controllers;

[ApiController]
[Route("[controller]")]
public class ObraController : ControllerBase
{
    private readonly IObraService _obraService;
    public ObraController(IObraService obraService)
    {
        _obraService = obraService;
    }

    [HttpGet]
    public ActionResult<List<Obra>> GetAll() =>
    _obraService.GetAll();



    [HttpGet]
    [Route("{id}")]
    public ActionResult<Obra> Get(int id)
    {
        var obra = _obraService.Get(id);

        if (obra == null)
        {
            return NotFound();
        }
        else
        {
            return obra;
        }
    }




    [HttpPost]
    public IActionResult Create([FromBody] ObraCreateDTO obraDto)
    {
        if (!ModelState.IsValid) { return BadRequest(ModelState); }

        try
        {
            var obra = _obraService.Add(obraDto); //mejor pasar el DTO completo como en el PUT
            return CreatedAtAction(nameof(Get), new { obraId = obra.ObraId }, obra);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }



    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] ObraUpdateDTO obraDto)
    {
        if (!ModelState.IsValid) { return BadRequest(ModelState); }

        try
        {
            _obraService.Update(id, obraDto);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }




    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var obra = _obraService.Get(id);

        if (obra is null)
            return NotFound();

        _obraService.Delete(id);

        return NoContent();
    }
}