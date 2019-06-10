using Library.Domain.DTO;
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
        private IBookService bookService;
        private IArtistService artistService;
        public HomeController(IBookService bookService, IArtistService artistService)
        {
            this.bookService = bookService;
            this.artistService = artistService;
        }

        [HttpGet]
        public IHttpActionResult Index()
        {
            var artists = artistService.GetAll();
            return Ok(artists);
        }
    }
}
