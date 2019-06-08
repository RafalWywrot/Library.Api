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
        public string Get()
        {
            return "a2";
        }
    }
}
