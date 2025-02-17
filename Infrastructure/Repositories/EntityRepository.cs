using Abstraction.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public abstract class EntityRepository<TEntity> : IEntityRepository<TEntity>, IDisposable where TEntity : EntityBase
    {
        protected ApplicationContext Context { get; set; }

        protected EntityRepository(ApplicationContext context)
        {
            Context = context;
        }

        public void Add(TEntity entity)
        {
            Context.Add(entity);
            Context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public IEnumerable<TEntity> FindAll()
        {
            var query = Context.Set<TEntity>();
            var result = query.ToList();
            return result;
        }

        public TEntity FindById(Guid id)
        {
            var query = Context.Set<TEntity>();
            var result = query.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public void Update(TEntity entity)
        {
            Context.Update(entity);
            Context.SaveChanges();
        }

        public IEnumerable<TEntity> FindAllWithInclude()
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();
            var result = query.Include("Employe").Include("Fonction").Include("Service");
            return result.ToList();
        }
    }
}