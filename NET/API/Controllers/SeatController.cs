using Tickett.Models;
using Tickett.Business;
using Microsoft.AspNetCore.Mvc;


namespace Tickett.Controllers;

[ApiController]
[Route("[controller]")]
public class SeatController : ControllerBase
{
    private readonly ISeatService _seatService;
    public SeatController(ISeatService seatService)
    {
        _seatService = seatService;
    }

    [HttpGet]
    public ActionResult<List<ButacaDTO>> GetAll() =>
    _seatService.GetAll();


    // PILLAR SOLO 1 BUTACA
    [HttpGet]
    [Route("{idFunction}/{idSeat}")]
    public ActionResult<ButacaDTO> GetSeat(int idFunction, int idSeat)
    {
        var seat = _seatService.GetSeat(idFunction, idSeat);

        if (seat == null)
        {
            return NotFound();
        }
        else
        {
            return seat;
        }
    }

    // PILLAR TODAS LAS BUTACAS DE 1 FUNCION
    [HttpGet]
    [Route("{id}")]
    public ActionResult<List<ButacaDTO>> GetFromFunction(int id)
    {
        var seat = _seatService.GetFromFunction(id);

        if (seat == null)
        {
            return NotFound();
        }
        else
        {
            return seat;
        }
    }




    [HttpPost]
    public IActionResult Create([FromBody] ButacaObraCreateDTO butacaObraCreateDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _seatService.Add(butacaObraCreateDTO);
        return Ok();
    }


    [HttpPut("{idFunction}/{idSeat}")]
    public IActionResult Update(int idFunction, int idSeat, [FromBody] ButacaObraUpdateDTO butacaUpdateDTO)
    {
         if (!ModelState.IsValid) { return BadRequest(ModelState); }

        try
        {
            _seatService.Update(idFunction,idSeat, butacaUpdateDTO);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }




    [HttpDelete("{idFunction}/{idSeat}")]
    public IActionResult Delete(int idFunction, int idSeat)
    {
        var obra = _seatService.GetSeat(idFunction, idSeat);

        if (obra is null)
            return NotFound();

        _seatService.Delete(idFunction, idSeat);

        return NoContent();
    }
}