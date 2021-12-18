using System;
using System.Linq;
using ASAP_API.Infra.Data;
using Microsoft.EntityFrameworkCore;
using ASAP_API.Domain;
using System.Threading.Tasks;

namespace ASAP_API.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ASAPContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(ASAPContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual void Update(TEntity obj)
        {
                DbSet.Update(obj);
        }

        public virtual void Remove(Guid id)
        {
            if (GetById(id) != null)
                DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }


    }
}
