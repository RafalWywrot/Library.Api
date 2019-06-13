using AutoMapper;
using Library.Domain.DTO;
using Library.Domain.Entities;
using Library.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

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

        public RentDTO Get(int id)
        {
            return Mapper.Map<RentDTO>(rentRepository.GetDetail(x => x.Id == id));
        }

        public IList<RentDTO> GetAll()
        {
            var a = rentRepository.GetOverview();
            return Mapper.Map<List<RentDTO>>(rentRepository.GetOverview());
        }

        public void Add(RentDTO rentDTO)
        {
            rentRepository.Add(Mapper.Map<Rent>(rentDTO));
            rentRepository.SaveChanges();
        }

        public void Update(RentDTO rentDTO)
        {
            var rent = rentRepository.GetDetail(x => x.Id == rentDTO.Id);
            Mapper.Map<RentDTO, Rent>(rentDTO, rent);
            rentRepository.SaveChanges();
        }
    }
}
