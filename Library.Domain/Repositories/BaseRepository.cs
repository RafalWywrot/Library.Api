using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Repositories
{
    public class BaseRepository : IRepositorySave
    {
        protected LibraryDbContext context;
        public BaseRepository()
        {
            context = new LibraryDbContext();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
