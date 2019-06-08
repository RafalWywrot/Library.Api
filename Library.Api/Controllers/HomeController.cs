using Library.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Library.Api.Controllers
{
    public class HomeController : ApiController
    {
        private IBookService _bookService;
        public HomeController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IHttpActionResult Index()
        {
            string a = _bookService.Get();
            return Ok();
        }
    }
}
