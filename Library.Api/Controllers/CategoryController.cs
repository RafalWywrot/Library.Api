using Library.Api.Helpers;
using Library.Domain.DTO;
using Library.Domain.Services;
using System.Web.Http;
namespace Library.Api.Controllers
{
    public class CategoryController : ApiController
    {
        private ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var categories = categoryService.GetAll();
            return Ok(categories);
        }
        [HttpPost]
        public IHttpActionResult New(CategoryDTO category)
        {
            categoryService.Add(category);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var category = categoryService.Get(id);
            return Ok(category);
        }
        [HttpPost]
        public IHttpActionResult Update(CategoryDTO category)
        {
            categoryService.Update(category);
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult Remove(EntityId entity)
        {
            categoryService.Remove(entity.Id);
            return Ok();
        }
    }
}