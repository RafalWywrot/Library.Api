using AutoMapper;
using Library.Domain.DTO;
using Library.Domain.Entities;
using Library.Domain.Repositories;
using System.Collections.Generic;

namespace Library.Domain.Services
{
    public interface IPublishHouseService
    {
        PublishHouseDTO Get(int id);
        IList<PublishHouseDTO> GetAll();
        void Add(PublishHouseDTO PublishHouseDTO);
        void Update(PublishHouseDTO PublishHouseDTO);
        void Remove(int id);
    }
    public class PublishHouseService : IPublishHouseService
    {
        private PublishHouseRepository publishHouseRepository { get; }
        public PublishHouseService(PublishHouseRepository publishHouseRepository)
        {
            this.publishHouseRepository = publishHouseRepository;
        }
        public PublishHouseDTO Get(int id)
        {
            return Mapper.Map<PublishHouseDTO>(publishHouseRepository.GetDetail(x => x.Id == id));
        }
        public IList<PublishHouseDTO> GetAll()
        {
            return Mapper.Map<List<PublishHouseDTO>>(publishHouseRepository.GetOverview());
        }

        public void Add(PublishHouseDTO publishHouseDTO)
        {
            publishHouseRepository.Add(Mapper.Map<PublishHouse>(publishHouseDTO));
            publishHouseRepository.SaveChanges();
        }

        public void Update(PublishHouseDTO publishHouseDTO)
        {
            var publishHouse = publishHouseRepository.GetDetail(x => x.Id == publishHouseDTO.Id);
            Mapper.Map<PublishHouseDTO, PublishHouse>(publishHouseDTO, publishHouse);
            publishHouseRepository.SaveChanges();
        }

        public void Remove(int id)
        {
            var publisHouse = publishHouseRepository.GetDetail(x => x.Id == id);
            publishHouseRepository.Delete(publisHouse);
            publishHouseRepository.SaveChanges();
        }
    }
}
