using Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Abstract
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
        Category GetById(int categoryId);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
