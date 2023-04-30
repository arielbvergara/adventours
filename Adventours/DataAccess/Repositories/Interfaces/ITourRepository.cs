using DataAccess.Entities;

namespace DataAccess.Repositories.Interfaces;

public interface ITourRepository : IRepository<TourEntity>
{
    Task<ICollection<TourEntity>> GetAllByTravelerId(int travelerId);

    Task<ICollection<TourEntity>> GetAllByTourLeaderId(int tourLeaderId);
}