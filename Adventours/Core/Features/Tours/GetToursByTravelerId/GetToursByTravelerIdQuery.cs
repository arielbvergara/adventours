using Core.Infrastructure;
using DataAccess.Entities;

namespace Core.Features.Tours.GetToursByTravelerId;

public record GetToursByTravelerIdQuery(int TravelerId) : IQuery<ICollection<TourEntity>>;