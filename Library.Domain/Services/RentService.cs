using AutoMapper;
using Library.Domain.DTO;
using Library.Domain.Entities;
using Library.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Domain.Services
{
    public interface IRentService
    {
        RentDTO Get(int id);
        IList<RentDTO> GetAll();
        void Add(RentDTO rentDTO);
        void Remove(int id);
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
            return Mapper.Map<List<RentDTO>>(rentRepository.GetOverview().ToList());
        }

        public void Add(RentDTO rentDTO)
        {
            rentRepository.Add(Mapper.Map<Rent>(rentDTO));
            rentRepository.SaveChanges();
        }

        public void Remove(int id)
        {
            var rent = rentRepository.GetDetail(x => x.BookId == id);
            rentRepository.Delete(rent);
            rentRepository.SaveChanges();
        }
    }
}
