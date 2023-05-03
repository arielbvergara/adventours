using Core.Features.Tours.GetToursByTravelerId;
using Core.Infrastructure;
using DataAccess.Entities;

namespace Adventours.API.Features.Tours;

public static class TourController
{
    public static void GetTourByTravelerId(this WebApplication app)
    {
        app.MapGet("/tours/traveler/{id}", async (int id, IQueryHandler<GetToursByTravelerIdQuery, ICollection<TourEntity>> handler) =>
                await handler.HandleAsync(new(id))
        ).WithName("GetWeatherForecast")
        .WithOpenApi();
    }
}