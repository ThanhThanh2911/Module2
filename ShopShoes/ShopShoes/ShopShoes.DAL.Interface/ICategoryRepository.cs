using ShopShoes.Domain.Response.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopShoes.DAL.Interface
{
    public interface ICategoryRepository
    {
        IList<Category> ListCategory();
    }
}
