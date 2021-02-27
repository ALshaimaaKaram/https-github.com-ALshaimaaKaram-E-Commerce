using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly CategoryDbContext _db;
        public GenericRepository(CategoryDbContext db)
        {
            _db = db;
        }

        public void Add(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
            _db.SaveChanges();
        }

        public IList<TEntity> List()
        {
            return _db.Set<TEntity>().ToList();
        }

        public TEntity FindById(int id)
        {
            return _db.Set<TEntity>().Find(id);
        }
    }
}
