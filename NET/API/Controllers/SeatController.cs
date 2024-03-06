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
    public ActionResult<List<ButacaObra>> GetAll() =>
    _seatService.GetAll();


   // PILLAR SOLO 1 BUTACA
    [HttpGet]
    [Route("{idFunction}/{idSeat}")]
    public ActionResult<ButacaObra> GetSeat(int idFunction, int idSeat)
    {
        var seat = _seatService.GetSeat(idFunction, idSeat);

        if (seat == null){
            return NotFound();
        }else{
            return seat;
        }
    }

   // PILLAR TODAS LAS BUTACAS DE 1 FUNCION
    [HttpGet]
    [Route("{id}")]
    public ActionResult<List<ButacaObra>> GetFromFunction(int id)
    {
        var seat = _seatService.GetFromFunction(id);

        if (seat == null){
            return NotFound();
        }else{
            return seat;
        }
    }




    [HttpPost]
    public IActionResult Create(ButacaObra seat)
    {
        _seatService.Add(seat);
        return CreatedAtAction(nameof(GetSeat), new { id = seat.ObraId }, seat);
    }


 

    [HttpPut("{idFunction}/{idSeat}")]
    public IActionResult Update(int idFunction, int idSeat, ButacaObra seat)
    {
        if (idFunction != seat.ObraId)
            return BadRequest();

        var existingObra = _seatService.GetSeat(idFunction, idSeat);
        if (existingObra is null)
            return NotFound();

        _seatService.Update(seat);

        return NoContent();
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