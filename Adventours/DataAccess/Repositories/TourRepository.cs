using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public class TourRepository : RepositoryBase<TourEntity>, ITourRepository
{
    public TourRepository(AdventourContext context) : base(context)
    {
    }

    public async Task<ICollection<TourEntity>> GetAllByTravelerId(int userId) => 
        await DbSet
            .Where(tour => tour.Travelers != null && tour.Travelers.Any(traveler => traveler.UserId == userId))
            .ToListAsync();

    public async Task<ICollection<TourEntity>> GetAllByTourLeaderId(int tourLeaderId) => 
        await DbSet
            .Where(tour => tour.TourLeader.Id == tourLeaderId)
            .ToListAsync();
}