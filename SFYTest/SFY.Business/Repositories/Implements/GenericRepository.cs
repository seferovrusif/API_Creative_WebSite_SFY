using Microsoft.EntityFrameworkCore;
using SFY.Business.Repositories.Interfaces;
using SFY.Core.Entities.Common;
using SFY.DAL.Contexts;
using System.Linq.Expressions;

namespace SFY.Business.Repositories.Implements
{
    public class GenericRepository<T> : IGenericReository<T> where T : BaseEntity
    {
        SFYTestContext _context { get; }

        public GenericRepository(SFYTestContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool noTracking = true, params string[] includes)
        {
            var query = _applyIncludes(Table.AsQueryable(), includes);
            return noTracking ? query.AsNoTracking() : query;
        }

        public async Task<bool> IsExistAsync(Expression<Func<T, bool>> expression)
        {
            return await Table.AnyAsync(expression);
        }

        public async Task CreateAsync(T data)
        {
            await Table.AddAsync(data);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int id, bool noTracking = true, params string[] includes)
        {
            var query = _applyIncludes(Table.AsQueryable(), includes);
            return noTracking ? await query.AsNoTracking().SingleOrDefaultAsync(t => t.id == id) : await query.SingleOrDefaultAsync(t => t.id == id);
        }

        public void Remove(T data)
        {
            Table.Remove(data);
        }
        IQueryable<T> _applyIncludes(IQueryable<T> query, params string[] includes)
        {
            if (includes != null && includes.Length > 0)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool noTracking = true, params string[] includes)
        {
            var query = _applyIncludes(Table.AsQueryable(), includes);
            return noTracking ? await query.AsNoTracking().SingleOrDefaultAsync(expression) : await query.SingleOrDefaultAsync(expression);
        }
    }
}
