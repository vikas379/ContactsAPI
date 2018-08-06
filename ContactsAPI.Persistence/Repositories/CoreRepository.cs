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
            return dbSet;
        }

        public TEntity GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Add(TEntity obj)
        {
            dbSet.Add(obj);
            dbContext.Entry(obj).Property("CreationDate").OriginalValue = DateTime.UtcNow;
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
