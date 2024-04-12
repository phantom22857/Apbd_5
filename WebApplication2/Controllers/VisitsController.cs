using Microsoft.AspNetCore.Mvc;
using WebApplication2.DataBase;
using WebApplication2.Models;

namespace WebApplication2.Controllers;
[ApiController]
[Route("[controller]")]
public class VisitsController : ControllerBase
{
    private readonly MockDb _db;

    public VisitsController(MockDb db)
    {
        _db = db;
    }

    [HttpGet("{animalId}")]
    public IActionResult GetVisitsForAnimal(int animalId)
    {
        var visits = _db.Visits.Where(v => v.AnimalId == animalId).ToList();
        if (!visits.Any()) return NotFound("No visits found for the specified animal.");
        return Ok(visits);
    }

    [HttpPost]
    public IActionResult AddVisit([FromBody] Visit visit)
    {
        _db.Visits.Add(visit);
        return CreatedAtAction("GetVisitsForAnimal", new { animalId = visit.AnimalId }, visit);
    }
}