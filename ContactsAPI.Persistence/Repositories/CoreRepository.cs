using ContactsAPI.Persistence.Contract;
using ContactsAPI.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactsAPI.Persistence.Repositories
{
    public class CoreRepository<TEntity> : ICoreRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// The database context
        /// </summary>
        protected readonly ContactContext dbContext;

        /// <summary>
        /// The database set
        /// </summary>
        protected readonly DbSet<TEntity> dbSet;

        public CoreRepository(ContactContext context)
        {
            dbContext = context;
            dbSet = dbContext.Set<TEntity>();
        }


        public IQueryable<TEntity> GetAll()
        {
            return dbSet.AsNoTracking();
        }

        public TEntity GetById(int id)
        {
            TEntity record = dbSet.Find(id);
            if(record != null) dbContext.Entry(record).State = EntityState.Detached;
            return record;
 
        }

        public void Add(TEntity obj)
        {
            dbSet.Add(obj);
        }

        public void Update(TEntity obj)
        {
            dbSet.Update(obj);
        }

        public void Remove(int id)
        {
            dbSet.Remove(dbSet.Find(id));
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }


        public void Dispose()
        {
            dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
