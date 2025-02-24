using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Repositories
{
    public interface IEntityRepository<TEntity> where TEntity : EntityBase
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity FindById(Guid id);
        IEnumerable<TEntity> FindAll();
        IEnumerable<TEntity> FindAllWithInclude(params string[] includeProperties);
        void Dispose();
    }
}
