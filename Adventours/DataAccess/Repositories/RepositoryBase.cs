using Ardalis.GuardClauses;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Optional;

namespace DataAccess.Repositories;

public class RepositoryBase<T> : IRepository<T> where T : EntityBase
{
    private readonly AdventourContext _context;

    protected DbSet<T> DbSet { get; set; }

    public RepositoryBase(AdventourContext context)
    {
        _context = context;
        DbSet = _context.Set<T>();
    }
        
    internal IQueryable<T> All() => DbSet.AsQueryable();

    public async Task<IEnumerable<T>> GetAllAsync() => await All().ToListAsync();

    public virtual async Task<Option<T>> GetByIdAsync(int id)
    {
        var entity = await DbSet.SingleOrDefaultAsync(e => e.Id.Equals(id));
        return entity != null ? Option.Some(entity) : Option.None<T>();
    }

    public async Task<T> AddAsync(T entity)
    {
        Guard.Against.Null(entity);
            
        await _context.AddAsync(entity);

        return entity;
    }

    public T Update(T entity)
    {
        Guard.Against.Null(entity);

        _context.Update(entity);

        return entity;
    }

    public Task DeleteAsync(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }
            
        return DeleteInternalAsync(entity);
    }

    protected async Task DeleteInternalAsync(T entity)
    {
        DbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }
        
    public async Task SaveChangesAsync(CancellationToken cancellationToken = default) => 
        await _context.SaveChangesAsync(cancellationToken);
}