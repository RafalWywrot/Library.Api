using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {

    }
    public class BookRepository : BaseRepository, IBookRepository
    {
        public void Add(Book entity)
        {
            context.Books.Add(entity);
        }

        public void Delete(Book entity)
        {
            context.Books.Remove(entity);
        }

        public Book GetDetail(Func<Book, bool> predicate)
        {
            return context.Books.Where(predicate).FirstOrDefault();
        }

        public IEnumerable<Book> GetOverview(Func<Book, bool> predicate = null)
        {
            if (predicate != null)
                return context.Books.Where(predicate).ToList();

            return context.Books;
        }
    }
}
