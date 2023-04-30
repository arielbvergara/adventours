using Core.Infrastructure;
using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;

namespace Core.Features.Tours.GetToursByTravelerId;

public class GetToursByTravelerIdQueryHandler : IQueryHandler<GetToursByTravelerIdQuery, ICollection<TourEntity>>
{
    private readonly ITourRepository _tourRepository;

    public GetToursByTravelerIdQueryHandler(ITourRepository tourRepository)
    {
        _tourRepository = tourRepository;
    }

    public async Task<ICollection<TourEntity>> HandleAsync(GetToursByTravelerIdQuery query) => 
        await _tourRepository.GetAllByTravelerId(query.TravelerId);
}