using AutoMapper;
using Library.Domain.DTO;
using Library.Domain.Entities;
using Library.Domain.Repositories;
using System.Collections.Generic;

namespace Library.Domain.Services
{
    public interface IRentService
    {
        RentDTO Get(int id);
        IList<RentDTO> GetAll();
        void Add(RentDTO artistDTO);
        void Update(RentDTO artistDTO);
    }
    public class RentService : IRentService
    {
        private IRentRepository rentRepository { get; }
        public RentService(IRentRepository rentRepository)
        {
            this.rentRepository = rentRepository;
        }

        RentDTO IRentService.Get(int id)
        {
            return Mapper.Map<RentDTO>(rentRepository.GetDetail(x => x.Id == id));
        }

        IList<RentDTO> IRentService.GetAll()
        {
            return Mapper.Map<List<RentDTO>>(rentRepository.GetOverview());

        }

        public void Add(RentDTO rentDTO)
        {
            rentRepository.Add(Mapper.Map<Rent>(rentDTO));
            rentRepository.SaveChanges();
        }

        public void Update(RentDTO artistDTO)
        {
            var rent = rentRepository.GetDetail(x => x.Id == artistDTO.Id);
            Mapper.Map<RentDTO, Rent>(artistDTO, rent);
            rentRepository.SaveChanges();
        }
    }
}
