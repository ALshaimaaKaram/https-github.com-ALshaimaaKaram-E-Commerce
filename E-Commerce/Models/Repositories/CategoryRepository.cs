using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly CategoryDbContext _db;

        public CategoryRepository(CategoryDbContext db) : base(db)
        {
            _db = db;
        }
        public IList<AttributeLookUp> ListAttributeLookUp()
        {
            return _db.AttributeLookUps.ToList();
        }
    }
}