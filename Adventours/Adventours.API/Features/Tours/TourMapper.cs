using DataAccess.Entities;

namespace Adventours.API.Features.Tours;

public static class TourMapper
{
    public static TourResource ToResource(this TourEntity tourEntity) => 
        new TourResource(tourEntity.Id, 
            tourEntity.Title, 
            tourEntity.Description, 
            tourEntity.TourLeader);

    public static ICollection<TourResource> ToResources(this ICollection<TourEntity> tourEntities) =>
        tourEntities.Select(ToResource).ToList();
}