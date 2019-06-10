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
    public class ArtistRepository : BaseRepository, IArtistRepository
    {
        public void Add(Artist entity)
        {
            context.Artists.Add(entity);
        }

        public void Delete(Artist entity)
        {
            context.Artists.Remove(entity);
        }

        public Artist GetDetail(Func<Artist, bool> predicate)
        {
            return context.Artists.Where(predicate).FirstOrDefault(); 
        }

        public IEnumerable<Artist> GetOverview(Func<Artist, bool> predicate = null)
        {
            if (predicate != null)
                return context.Artists.Where(predicate).ToList();

            return context.Artists;
        }
    }
}
