using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [Route("ListParent")]
        [HttpGet]
        public List<Category> ListParent()
        {
            return categoryRepository.List().ToList();
        }

        [HttpPost]
        public void AddCategory(Category category)
        {      
            categoryRepository.Add(category);
        }

        //public void AddAttributes()
        //{

        //}

    }
}
