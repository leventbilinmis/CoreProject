using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Core.Service
{
    public interface IService<TEntity> where TEntity:class,IEntity,new()
    {
        // sadece ilgili olan entity hangisi ise id arama işlemi ile o entity dönecektir.
        Task<TEntity> GetByIdAsync(int id);

        //Hangi entity çağrılıyorsa tablodaki tüm veriler gelecektir
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);

        TEntity Update(TEntity entity);
    }
}
