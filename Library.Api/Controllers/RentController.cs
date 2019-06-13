using Library.Api.Helpers;
using Library.Domain.DTO;
using Library.Domain.Services;
using System.Web.Http;

namespace Library.Api.Controllers
{
    public class RentController : ApiController
    {
        private IRentService rentService;
        public RentController(IRentService rentService)
        {
            
            this.rentService = rentService;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var rents = rentService.GetAll();
            return Ok(rents);
        }
        //[HttpPost]
        //public IHttpActionResult New(BookSaveDTO bookDto)
        //{
        //    bookService.Add(bookDto);
        //    return Ok();
        //}
        //[HttpGet]
        //public IHttpActionResult GetById(int id)
        //{
        //    var book = bookService.Get(id);
        //    return Ok(book);
        //}
        //[HttpPost]
        //public IHttpActionResult Update(BookSaveDTO bookDto)
        //{
        //    bookService.Update(bookDto);
        //    return Ok();
        //}
    }
}