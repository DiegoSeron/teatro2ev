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



    [HttpGet]
    [Route("{id}")]
    public ActionResult<ButacaObra> Get(int idFunction, int idSeat)
    {
        var seat = _seatService.Get(idFunction, idSeat);

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
        return CreatedAtAction(nameof(Get), new { id = seat.ObraId }, seat);
    }




    [HttpPut("{id}")]
    public IActionResult Update(int idFunction, int idSeat, ButacaObra seat)
    {
        if (idFunction != seat.ObraId)
            return BadRequest();

        var existingObra = _seatService.Get(idFunction, idSeat);
        if (existingObra is null)
            return NotFound();

        _seatService.Update(seat);

        return NoContent();
    }




    [HttpDelete("{id}")]
    public IActionResult Delete(int idFunction, int idSeat)
    {
        var obra = _seatService.Get(idFunction, idSeat);

        if (obra is null)
            return NotFound();

        _seatService.Delete(idFunction, idSeat);

        return NoContent();
    }
}