using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //C REATES
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        //R EADS
        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();
        IEnumerator<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //U PDATES
        //void Update(TEntity entity);
        //void UpdateRange(IEnumerable<TEntity> entities);

        //D ELETES
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
