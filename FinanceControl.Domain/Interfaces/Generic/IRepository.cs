using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ChallengeStone.Domain.Interfaces
{
    public interface IRepository<TEntity, in TId> where TEntity : class
    {
        TEntity Get(object keyValue);

        Task<TEntity> InsertAsync(TEntity entity);

        TEntity Insert(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        TEntity Update(TEntity entity);

        Task<TEntity> DeleteAsync(TEntity entity);

        IQueryable<TEntity> All();

        void Delete(TEntity entity);

        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> filter);

        // SYNC Methods

        TEntity Find(Expression<Func<TEntity, bool>> filter);

        Task<List<TEntity>> FindListAsync(Expression<Func<TEntity, bool>> filter);
    }
}
