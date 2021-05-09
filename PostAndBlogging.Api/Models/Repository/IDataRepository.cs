using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostAndBlogging.Api.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Update(Blogs blog, TEntity entity);
        void Delete(Blogs blog);
    }
}
