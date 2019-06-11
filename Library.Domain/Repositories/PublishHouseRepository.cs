using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Domain.Repositories
{
    public interface IPublishHouseRepository : IRepository<PublishHouse>
    {

    }
    public class PublishHouseRepository : BaseRepository, IPublishHouseRepository
    {
        public void Add(PublishHouse entity)
        {
            context.PublishHouses.Add(entity);
        }

        public void Delete(PublishHouse entity)
        {
            context.PublishHouses.Remove(entity);
        }

        public PublishHouse GetDetail(Func<PublishHouse, bool> predicate)
        {
            return context.PublishHouses.Where(predicate).FirstOrDefault();
        }

        public IEnumerable<PublishHouse> GetOverview(Func<PublishHouse, bool> predicate = null)
        {
            if (predicate != null)
                return context.PublishHouses.Where(predicate).ToList();

            return context.PublishHouses;
        }
    }
}
