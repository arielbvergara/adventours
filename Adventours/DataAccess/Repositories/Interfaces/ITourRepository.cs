using DataAccess.Entities;

namespace DataAccess.Repositories.Interfaces;

internal interface ITourRepository : IRepository<TourEntity>
{
    Task<ICollection<TourEntity>> GetAllByTravelerId(int travelerId);

    Task<ICollection<TourEntity>> GetAllByTourLeaderId(int tourLeaderId);
}