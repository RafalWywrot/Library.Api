using AutoMapper;
using Library.Domain.DTO;
using Library.Domain.Entities;
using Library.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Library.Domain.Services
{
    public interface IBookService
    {
        BookSaveDTO Get(int id);
        IList<BookDTO> GetAll();
        void Add(BookSaveDTO bookDTO);
        void Update(BookSaveDTO artistDTO);
        void Remove(int id);
    }
    public class BookService : IBookService
    {
        private IBookRepository bookRepository { get; }
        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IList<BookDTO> GetAll()
        {
            return Mapper.Map<List<BookDTO>>(bookRepository.GetOverview().ToList());
        }

        public void Add(BookSaveDTO bookSaveDTO)
        {
            bookRepository.Add(Mapper.Map<Book>(bookSaveDTO));
            bookRepository.SaveChanges();
        }

        public BookSaveDTO Get(int id)
        {
            return Mapper.Map<BookSaveDTO>(bookRepository.GetDetail(x => x.Id == id));
        }

        public void Update(BookSaveDTO bookSaveDto)
        {
            var book = bookRepository.GetDetail(x => x.Id == bookSaveDto.Id);
            Mapper.Map<BookSaveDTO, Book>(bookSaveDto, book);
            bookRepository.SaveChanges();
        }

        public void Remove(int id)
        {
            var book = bookRepository.GetDetail(x => x.Id == id);
            bookRepository.Delete(book);
            bookRepository.SaveChanges();
        }
    }
}
