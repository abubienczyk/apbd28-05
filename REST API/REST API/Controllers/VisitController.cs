using Microsoft.AspNetCore.Mvc;
using REST_API.Database;
//using REST_API.Endpoints;
using REST_API.Models;
namespace REST_API.Controllers;

[ApiController]
[Route("[controller]")]
public class VisitController : ControllerBase
{

    // GET /visits/{animalId}
    [HttpGet("/visits/{animalId}")]
    public IActionResult GetVisits(int animalId)
    {
        var animalVisits = VisitSetUp.Visits.FindAll(v => v.AnimalId == animalId);
        return Ok(animalVisits);
    }

    // POST /visits
    [HttpPost("/visits")]
    public IActionResult AddVisit([FromBody]Visit visit)
    {
        VisitSetUp.Visits.Add(visit);
        return CreatedAtAction(nameof(GetVisits), new { animalId = visit.AnimalId }, visit);
    }
}