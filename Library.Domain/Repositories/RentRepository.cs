using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Library.Domain.Repositories
{
    public interface IRentRepository : IRepository<Rent>
    {

    }
    public class RentRepository : BaseRepository, IRentRepository
    {

        public void Add(Rent entity)
        {
            context.Rents.Add(entity);
        }

        public void Delete(Rent entity)
        {
            context.Rents.Remove(entity);
        }

        public Rent GetDetail(Func<Rent, bool> predicate)
        {
            return context.Rents.Where(predicate).FirstOrDefault();
        }

        public IEnumerable<Rent> GetOverview(Func<Rent, bool> predicate = null)
        {
            if (predicate != null)
                return context.Rents.Where(predicate).ToList();

            return context.Rents;
        }
    }
}
