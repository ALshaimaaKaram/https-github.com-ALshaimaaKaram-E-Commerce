using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        IList<AttributeLookUp> ListAttributeLookUp();
    }
}
