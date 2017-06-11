using _2012128180_EN.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace _2012128180_PER.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        public readonly DbContext _Context;

        public Repository(DbContext context)
        {
            _Context = context;
        }

        public IQueryable<TEntity> GETEntity()
        {
            return _Context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _Context.Set<TEntity>().AddRange(entities);
        }


        public TEntity Get(int? Id)
        {
            return _Context.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _Context.Set<TEntity>().ToList();

        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _Context.Set<TEntity>().Where(predicate);
        }

        public void Delete(TEntity entity)
        {
            _Context.Set<TEntity>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _Context.Set<TEntity>().RemoveRange(entities);
        }

        

    }
}