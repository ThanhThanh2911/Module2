using Dapper;
using ShopShoes.DAL.Interface;
using ShopShoes.Domain.Response.Category;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ShopShoes.DAL
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public IList<Category> ListCategory()
        {
            IList<Category> listCategory = SqlMapper.Query<Category>(con, "ListCategory", commandType: CommandType.StoredProcedure).ToList();
            return listCategory;
        }
    }
}
