using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Repositories
{
    public interface IArtistRepository : IRepository<Artist>
    {

    }
    public class ArtistRepository : IArtistRepository
    {
        private LibraryDbContext context;
        public ArtistRepository()
        {
            context = new LibraryDbContext();
        }
        public void Add(Artist entity)
        {
            context.Artists.Add(entity);
        }

        public void Delete(Artist entity)
        {
            throw new NotImplementedException();
        }

        public Artist GetDetail(Func<Artist, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Artist> GetOverview(Func<Artist, bool> predicate = null)
        {
            if (predicate != null)
                return context.Artists.Where(predicate).ToList();

            return context.Artists;
        }
    }
}
