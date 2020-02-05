using ShopShoes.Domain.Request;
using ShopShoes.Domain.Response.Product;
using System;
using System.Collections.Generic;

namespace ShopShoes.BAL.Interface
{
    public interface IProductService
    {
        SaveProductRes SaveProductRes(SaveProductReq saveProductReq);
        Product GetProductById(int id);
        bool DeleteProduct(int id);
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductByName(string name);
    }
}
