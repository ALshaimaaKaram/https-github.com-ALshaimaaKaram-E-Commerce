using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Repositories
{
    public interface IGenericRepository<TEntity>
    {
        IList<TEntity> List();
        TEntity FindById(int id);
        void Add(TEntity entity);
    }
}
