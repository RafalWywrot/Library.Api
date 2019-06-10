using Library.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Services
{
    public interface IBookService
    {
        string Get();
    }
    public class BookService : IBookService
    {
        private IArtistRepository artistRepository { get; }
        public BookService(IArtistRepository artistRepository)
        {
            this.artistRepository = artistRepository;
        }

        public string Get()
        {
            var b = artistRepository.GetOverview().FirstOrDefault();
            return b.Name;
        }
    }
}
