using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopShoes.BAL.Interface;
using ShopShoes.Domain.Response.Category;

namespace ShopShoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        [Route("ListCategory")]
        public IEnumerable<Category> ListCategory()
        {
            return categoryService.ListCategory();
        }
    }
}