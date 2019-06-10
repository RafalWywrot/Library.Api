using System;
using System.Collections.Generic;

namespace Library.Domain.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetOverview(Func<T, bool> predicate = null);
        T GetDetail(Func<T, bool> predicate);
        void Add(T entity);
        void Delete(T entity);
    }
}
