using Microsoft.AspNetCore.Mvc;

namespace REST_API.Endpoints;
using REST_API.Controllers;
using REST_API.Models;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
         // GET 
         app.MapGet("/animals", void (AnimalController controller) => controller.GetAnimals());
         // GET - id   
         app.MapGet("/animals/{id}", (AnimalController controller, int id) => controller.GetAnimalById(id));
         // POST 
         app.MapPost("/animals", (AnimalController controller, [FromBody]Animal animal) => controller.AddAnimal(animal));
         //PUT 
         app.MapPut("/animals/{id}", (AnimalController controller, int id, [FromBody] Animal animal) => controller.UpdateAnimal(id, animal));
         //DELETE
         app.MapDelete("/animals/{id}", (AnimalController controller, int id) => controller.DeleteAnimal(id));
         
    }
}