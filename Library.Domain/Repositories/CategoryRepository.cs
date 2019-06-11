using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Domain.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {

    }
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public void Add(Category entity)
        {
            context.Categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            context.Categories.Remove(entity);
        }

        public Category GetDetail(Func<Category, bool> predicate)
        {
            return context.Categories.Where(predicate).FirstOrDefault();
        }

        public IEnumerable<Category> GetOverview(Func<Category, bool> predicate = null)
        {
            if (predicate != null)
                return context.Categories.Where(predicate).ToList();

            return context.Categories;
        }
    }
}
