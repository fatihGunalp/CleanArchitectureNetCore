using Data.Entity;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Add(Category category)
        {
            categoryRepository.Add(category);
        }

        public void Delete(Category category)
        {
            categoryRepository.Delete(category);
        }

        public Category GetById(int categoryId)
        {
            return categoryRepository.GetById(categoryId);
        }

        public IEnumerable<Category> GetCategories()
        {
            return categoryRepository.GetAll();
        }

        public void Update(Category category)
        {
            categoryRepository.Update(category);
        }
    }
}
