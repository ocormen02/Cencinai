using Cencinai.Data.Models;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cencinai.Data.Repository.Generic
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes);

        Task<T> GetOne(Expression<Func<T, bool>> predicate,
            params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes);

        Task<PagedResult<T>> GetAllPaged(
            int page,
            int pageSize,
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes);

        void Add(T entity);

        void Remove(T entity);

        void Update(T entity);

        void UpdateRange(List<T> range);
    }
}
