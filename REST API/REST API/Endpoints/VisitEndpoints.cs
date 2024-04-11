using Microsoft.AspNetCore.Mvc;

namespace REST_API.Endpoints;
using REST_API.Controllers;
using REST_API.Models;
public static class VisitEndpoints
{
    public static void MapVisitEndpoints(this WebApplication app)
    {
         // GET - animalId
         app.MapGet("/visits/{animalId}", (VisitController controller, int animalId) => controller.GetVisits(animalId));
         //POST 
         app.MapPost("/visits", (VisitController controller,Visit visit) => controller.AddVisit(visit));
      
       
    }

}