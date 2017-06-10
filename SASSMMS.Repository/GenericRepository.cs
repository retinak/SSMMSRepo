using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace SASSMMS.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal MainContext ObjiSimsContextInternal;
        internal DbSet<TEntity> DbSet;
        public GenericRepository(MainContext objiSimsContext)
        {
            ObjiSimsContextInternal = objiSimsContext;
            DbSet = objiSimsContext.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }
        public virtual TEntity GetById(object id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetByQuery(string sqlQuery)
        {
           return DbSet.SqlQuery(sqlQuery);
        }
        public virtual TEntity GetFirst()
        {
            return Get().First();
        }
        public virtual TEntity GetLast()
        {
            return Get().Last();
        }
        public virtual void Insert(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Insert(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }
        //public virtual void Delete(object id)
        //{
        //    TEntity entityToDelete = DbSet.Find(id);
        //    Delete(entityToDelete);
        //}

        public virtual void Delete(TEntity entityToDelete)
        {
            if (ObjiSimsContextInternal.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
        
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            ObjiSimsContextInternal.Entry(entityToUpdate).State = EntityState.Modified;
        }


        public virtual void Update(IEnumerable<TEntity> entitiesToUpdate)
        {
            foreach (TEntity entityToUpdate in entitiesToUpdate)
            {
                if (!DbSet.Contains(entityToUpdate))
                {
                    DbSet.Attach(entityToUpdate);
                    ObjiSimsContextInternal.Entry(entityToUpdate).State = EntityState.Modified;
                }
            }
        }
    }
    
}
