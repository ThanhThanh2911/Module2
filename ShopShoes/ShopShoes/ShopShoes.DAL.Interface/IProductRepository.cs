using ShopShoes.Domain.Request;
using ShopShoes.Domain.Response.Category;
using ShopShoes.Domain.Response.Product;
using System;
using System.Collections.Generic;

namespace ShopShoes.DAL.Interface
{
    public interface IProductRepository
    {
        SaveProductRes SaveProduct(SaveProductReq saveProductReq);
        Product GetProductById(int id);
        bool DeleteProduct(int id);
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductByName(string name);
    }
}
