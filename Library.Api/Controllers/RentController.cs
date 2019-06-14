using Library.Api.Helpers;
using Library.Domain.DTO;
using Library.Domain.Services;
using System;
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

        [HttpPost]
        public IHttpActionResult New(RentDTO rentDto)
        {
            rentDto.From = DateTime.Now;
            rentService.Add(rentDto);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var rent = rentService.Get(id);
            return Ok(rent);
        }

        [HttpPost]
        public IHttpActionResult Remove(EntityId entity)
        {
            rentService.Remove(entity.Id);
            return Ok();
        }
    }
}