using WebApplication2.Models;

namespace WebApplication2.EndPoints;

public static class AnimalEndPoint
{
    public static void MapAnimalsEndPoints(this WebApplication app)
    {
        app.MapGet("/animals-minimal.api/{id}", (int id) =>
        {
            if (id != 1)
            {
                Results.NotFound();
            }
    
            Results.Ok();


        });

        app.MapPost("/animals-minimal.api", (Animal animal) =>
        {
            return Results.Created(" ",animal);
            
        });
        
    }
}