using WebApplication2.DataBase;
using WebApplication2.Models;

namespace WebApplication2.EndPoints;

public static class VisitEndpoints
{
    public static void MapVisitEndpoints(this WebApplication app)
    {
        app.MapGet("/visits/{animalId}", (int animalId, MockDb db) =>
        {
            var visits = db.Visits.Where(v => v.AnimalId == animalId).ToList();
            if (!visits.Any()) return Results.NotFound("No visits found for this animal.");
            return Results.Ok(visits);
        });

        app.MapPost("/visits", (Visit visit, MockDb db) =>
        {
            db.Visits.Add(visit);
            return Results.Created($"/visits/{visit.AnimalId}", visit);
        });
    }
}