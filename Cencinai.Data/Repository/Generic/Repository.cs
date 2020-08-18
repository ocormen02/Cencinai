using Cencinai.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cencinai.Data.Repository.Generic
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext dbContext;

        public Repository(DbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes)
        {
            var collection = BuildQueryToGetAll(includes).AsNoTracking();

            if (predicate != null)
                collection.Where(predicate);

            if (orderBy != null)
                collection = orderBy(collection);

            return await collection.ToListAsync();
        }

        public async Task<T> GetOne(Expression<Func<T, bool>> predicate, params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes)
        {
            var collection = BuildQueryToGetAll(includes).AsNoTracking();

            if (predicate != null) collection = collection.Where(predicate);

            return await collection.SingleAsync();
        }

        public void Add(T entity)
        {
            dbContext.Set<T>().Add(entity);
            dbContext.Entry(entity).State = EntityState.Added;
        }

        public void Remove(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            dbContext.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            dbContext.Set<T>().Update(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateRange(List<T> range)
        {
            dbContext.Set<T>().UpdateRange(range);
            dbContext.Entry(range).State = EntityState.Modified;
        }

        public async Task<PagedResult<T>> GetAllPaged(
            int page,
            int pageSize,
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes)
        {
            var skip = (page - 1) * pageSize;
            var collection = BuildQueryToGetAll(includes);

            if (predicate != null)
                collection = collection.Where(predicate);

            if (orderBy != null)
                collection = orderBy(collection);

            var pageCount = (int)Math.Ceiling((double)collection.Count() / pageSize);
            var pagedResult = await collection.Skip(skip).Take(pageSize).AsNoTracking().ToListAsync();

            return new PagedResult<T>
            {
                CurrentPage = page,
                PageSize = pageSize,
                PageCount = pageCount,
                TotalRowCount = collection.Count(),
                Result = pagedResult
            };
        }

        protected IQueryable<T> BuildQueryToGetAll(params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes)
        {

            var query = dbContext.Set<T>() as IQueryable<T>;

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = include(query);
                }
            }

            return query;
        }
    }
}
