using Library.Api.Helpers;
using Library.Domain.DTO;
using Library.Domain.Services;
using System.Linq;
using System.Web.Http;
namespace Library.Api.Controllers
{
    public class BookController : ApiController
    {
        private IBookService bookService;

        private IRentService rentService { get; }

        public BookController(IBookService bookService, IRentService rentService)
        {
            this.bookService = bookService;
            this.rentService = rentService;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var books = bookService.GetAll();
            return Ok(books);
        }
        /// <summary>
        /// return not rented books
        /// </summary>
        [HttpGet]
        public IHttpActionResult GetAvailableBooks()
        {
            var books = bookService.GetAll();
            var rents = rentService.GetAll().Select(x => x.Book.Id).ToList();
            return Ok(books.Where(book => !rents.Contains(book.Id)));
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