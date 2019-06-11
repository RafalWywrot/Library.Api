using AutoMapper;
using Library.Domain.DTO;
using Library.Domain.Entities;
using Library.Domain.Repositories;
using System.Collections.Generic;
namespace Library.Domain.Services
{
    public interface ICategoryService
    {
        CategoryDTO Get(int id);
        IList<CategoryDTO> GetAll();
        void Add(CategoryDTO CategoryDTO);
        void Update(CategoryDTO CategoryDTO);
        void Remove(int id);
    }
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository categoryRepository { get; }
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public CategoryDTO Get(int id)
        {
            return Mapper.Map<CategoryDTO>(categoryRepository.GetDetail(x => x.Id == id));
        }
        public IList<CategoryDTO> GetAll()
        {
            return Mapper.Map<List<CategoryDTO>>(categoryRepository.GetOverview());
        }

        public void Add(CategoryDTO categoryDTO)
        {
            categoryRepository.Add(Mapper.Map<Category>(categoryDTO));
            categoryRepository.SaveChanges();
        }

        public void Update(CategoryDTO CategoryDTO)
        {
            var category = categoryRepository.GetDetail(x => x.Id == CategoryDTO.Id);
            Mapper.Map<CategoryDTO, Category>(CategoryDTO, category);
            categoryRepository.SaveChanges();
        }

        public void Remove(int id)
        {
            var category = categoryRepository.GetDetail(x => x.Id == id);
            categoryRepository.Delete(category);
            categoryRepository.SaveChanges();
        }
    }
}
