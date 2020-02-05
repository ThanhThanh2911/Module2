using ShopShoes.Domain.Response.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopShoes.BAL.Interface
{
    public interface ICategoryService
    {
        IList<Category> ListCategory();
    }
}
