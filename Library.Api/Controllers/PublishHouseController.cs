using Library.Api.Helpers;
using Library.Domain.DTO;
using Library.Domain.Services;
using System.Web.Http;

namespace Library.Api.Controllers
{
    public class PublishHouseController : ApiController
    {
        private IPublishHouseService publishHouseService;
        public PublishHouseController(IPublishHouseService publishHouseService)
        {
            this.publishHouseService = publishHouseService;
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var publishHouses = publishHouseService.GetAll();
            return Ok(publishHouses);
        }
        [HttpPost]
        public IHttpActionResult New(PublishHouseDTO publishHouse)
        {
            publishHouseService.Add(publishHouse);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var publishHouse = publishHouseService.Get(id);
            return Ok(publishHouse);
        }
        [HttpPost]
        public IHttpActionResult Update(PublishHouseDTO publishHouse)
        {
            publishHouseService.Update(publishHouse);
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult Remove(EntityId entity)
        {
            publishHouseService.Remove(entity.Id);
            return Ok();
        }
    }
}