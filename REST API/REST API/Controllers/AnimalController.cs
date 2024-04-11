using Microsoft.AspNetCore.Mvc;
using REST_API.Database;
using REST_API.Models;
namespace REST_API.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalController : ControllerBase
{
    // GET /animals
    [HttpGet("/animals")]
    public IActionResult GetAnimals()
    {
        var a = AnimalSetUp.animals;
        return Ok(a);
    }
    
    // GET /animals/{id}
    [HttpGet("/animals/{id}")]
    public IActionResult GetAnimalById(int id)
    {
        var animal = AnimalSetUp.animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound();
        }
        return Ok(animal);
    }

    // POST /animals
    [HttpPost("/animals")]
    public IActionResult AddAnimal([FromBody]Animal animal)
    {
        AnimalSetUp.animals.Add(animal);
        return CreatedAtAction(nameof(GetAnimalById), new { id = animal.Id }, animal);
    }

    // PUT /animals/{id}
    [HttpPut("/animals/{id}")]
    public IActionResult UpdateAnimal(int id, [FromBody] Animal animal)
    {
        var currentAnimal = AnimalSetUp.animals.FirstOrDefault(a => a.Id == id);
        if (currentAnimal == null)
        {
            return NotFound();
        }

        currentAnimal.Name = animal.Name;
        currentAnimal.Category = animal.Category;
        currentAnimal.Weight = animal.Weight;
        currentAnimal.FurColor = animal.FurColor;

        return NoContent();
    }

    // DELETE /animals/{id}
    [HttpDelete("/animals/{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = AnimalSetUp.animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound();
        }

        AnimalSetUp.animals.Remove(animal);
        return NoContent();
    }

    
}