using AutoMapper;
using Library.Domain.DTO;
using Library.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Services
{
    public interface IArtistService
    {
        IList<ArtistDTO> GetAll();
    }
    public class ArtistService : IArtistService
    {
        private IArtistRepository artistRepository { get; }
        public ArtistService(IArtistRepository artistRepository)
        {
            this.artistRepository = artistRepository;
        }

        public IList<ArtistDTO> GetAll()
        {
            return Mapper.Map<List<ArtistDTO>>(artistRepository.GetOverview());
        }
    }
}
