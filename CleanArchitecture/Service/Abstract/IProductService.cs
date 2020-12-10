using Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Abstract
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetById(int productId);
        IEnumerable<Product> GetProductsWithCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
