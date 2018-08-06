using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ContactsAPI.Persistence.Contract
{
    public interface ICoreRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(int id);
        int SaveChanges();
    }
}
