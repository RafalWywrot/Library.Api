using Library.Api.Helpers;
using Library.Domain.DTO;
using Library.Domain.Services;
using System.Web.Http;
namespace Library.Api.Controllers
{
    public class BookController : ApiController
    {
        private IBookService bookService;
        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var books = bookService.GetAll();
            return Ok(books);
        }
        [HttpPost]
        public IHttpActionResult New(BookSaveDTO bookDto)
        {
            bookService.Add(bookDto);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var book = bookService.Get(id);
            return Ok(book);
        }
        [HttpPost]
        public IHttpActionResult Update(BookSaveDTO bookDto)
        {
            bookService.Update(bookDto);
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult Remove(EntityId entity)
        {
            bookService.Remove(entity.Id);
            return Ok();
        }
    }
}