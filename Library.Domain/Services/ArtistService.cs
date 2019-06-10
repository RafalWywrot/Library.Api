using AutoMapper;
using Library.Domain.DTO;
using Library.Domain.Entities;
using Library.Domain.Repositories;
using System.Collections.Generic;

namespace Library.Domain.Services
{
    public interface IArtistService
    {
        ArtistDTO Get(int id);
        IList<ArtistDTO> GetAll();
        void Add(ArtistDTO artistDTO);
        void Update(ArtistDTO artistDTO);
        void Remove(int id);
    }
    public class ArtistService : IArtistService
    {
        private IArtistRepository artistRepository { get; }
        public ArtistService(IArtistRepository artistRepository)
        {
            this.artistRepository = artistRepository;
        }
        public ArtistDTO Get(int id)
        {
            return Mapper.Map<ArtistDTO>(artistRepository.GetDetail(x => x.Id == id));
        }
        public IList<ArtistDTO> GetAll()
        {
            return Mapper.Map<List<ArtistDTO>>(artistRepository.GetOverview());
        }

        public void Add(ArtistDTO artistDTO)
        {
            artistRepository.Add(Mapper.Map<Artist>(artistDTO));
            artistRepository.SaveChanges();
        }

        public void Update(ArtistDTO artistDTO)
        {
            var artist = artistRepository.GetDetail(x => x.Id == artistDTO.Id);
            Mapper.Map<ArtistDTO, Artist>(artistDTO, artist);
            artistRepository.SaveChanges();
        }

        public void Remove(int id)
        {
            var artist = artistRepository.GetDetail(x => x.Id == id);
            artistRepository.Delete(artist);
            artistRepository.SaveChanges();
        }
    }
}
