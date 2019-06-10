using Library.Api.Helpers;
using Library.Domain.DTO;
using Library.Domain.Services;
using System.Web.Http;

namespace Library.Api.Controllers
{
    public class ArtistController : ApiController
    {
        private IArtistService artistService;
        public ArtistController(IArtistService artistService)
        {
            this.artistService = artistService;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var artists = artistService.GetAll();
            return Ok(artists);
        }
        [HttpPost]
        public IHttpActionResult New(ArtistDTO artist)
        {
            artistService.Add(artist);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var artist = artistService.Get(id);
            return Ok(artist);
        }
        [HttpPost]
        public IHttpActionResult Update(ArtistDTO artist)
        {
            artistService.Update(artist);
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult Remove(EntityId entity)
        {
            artistService.Remove(entity.Id);
            return Ok();
        }
        
    }
}