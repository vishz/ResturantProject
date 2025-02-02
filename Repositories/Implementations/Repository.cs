using Microsoft.EntityFrameworkCore;
using RebornResturantApp.Data;
using RebornResturantApp.Repositories.Interfaces;

namespace RebornResturantApp.Repositories.Implementations
{
  public class Repository<T> : IRepository<T> where T : class
  {
    private readonly DbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
      _context = context;
      _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
      return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
      return await _dbSet.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
      await _dbSet.AddAsync(entity);
    }

    public async Task UpdateAsync(T entity)
    {
      _dbSet.Attach(entity);
      _context.Entry(entity).State = EntityState.Modified;
    }

    public async Task DeleteAsync(int id)
    {
      var entity = await _dbSet.FindAsync(id);
      if (entity != null)
      {
        _dbSet.Remove(entity);
      }
    }

    public async Task<int> SaveChangesAsync()
    {
      return await _context.SaveChangesAsync();
    }
  }
}
