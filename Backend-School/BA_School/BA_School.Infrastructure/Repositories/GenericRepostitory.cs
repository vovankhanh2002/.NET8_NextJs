using BA_School.Application.Exceptions;
using BA_School.Domain.Interfaces;
using BA_School.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace BA_School.Infrastructure.Repositories
{
    public class GenericRepostitory<T>(SchoolDbcontext dbcontext) : IGeneric<T> where T : class
    {
        public async Task<int> CreateAsync(T entity)
        {
            dbcontext.Set<T>().Add(entity);
            return await dbcontext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var entity = await dbcontext.Set<T>().FindAsync(id) ?? throw new ItemNotFoundException($"{id} is not found");
            dbcontext.Set<T>().Remove(entity);
            return await dbcontext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = dbcontext.Set<T>().AsNoTracking();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await dbcontext.Set<T>().FindAsync(id);
            return result!;
        }

        public async Task<int> UpdateAsync(T entity)
        {
            dbcontext.Set<T>().Update(entity);
            return await dbcontext.SaveChangesAsync();
        }
    }

}
