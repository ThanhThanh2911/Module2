using ShopShoes.BAL.Interface;
using ShopShoes.DAL.Interface;
using ShopShoes.Domain.Response.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopShoes.BAL
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IList<Category> ListCategory()
        {
            return categoryRepository.ListCategory();
        }
    }
}
