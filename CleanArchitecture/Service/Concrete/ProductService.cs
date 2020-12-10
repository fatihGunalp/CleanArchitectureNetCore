using Data.Entity;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> productRepository;
        private readonly IRepository<Category> categoryRepository;

        public ProductService(IRepository<Product> productRepository, IRepository<Category> categoryRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }
        public void Add(Product product)
        {
            productRepository.Add(product);
        }

        public void Delete(Product product)
        {
            productRepository.Delete(product);
        }

        public Product GetById(int productId)
        {
            return productRepository.GetById(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public IEnumerable<Product> GetProductsWithCategory(int categoryId)
        {
            return productRepository.Where(x => x.CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            productRepository.Update(product);
        }
    }
}
