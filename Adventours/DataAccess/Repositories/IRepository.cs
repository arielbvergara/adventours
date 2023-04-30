using DataAccess.Entities;
using Optional;

namespace DataAccess.Repositories;

public interface IRepository<T> where T : EntityBase
{
    Task<IEnumerable<T>> GetAllAsync();

    Task<Option<T>> GetByIdAsync(int id);

    Task<T> AddAsync(T entity);

    T Update(T entity);

    Task DeleteAsync(T entity);

    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}