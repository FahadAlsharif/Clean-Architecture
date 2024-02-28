using Application.Services.BookServices.Interface;
using Domain.Entities;
using Infrastructure.Repository;


namespace Application.Services.BookServices
{
    public class BookServices : IBookService
    {
        public readonly IGenericRepository<Book> _bookRepository;
        public readonly IGenericRepository<Library> _libraryRepository;
        public BookServices(IGenericRepository<Book> bookRepository, IGenericRepository<Library> libraryRepository) 
        {
            _bookRepository = bookRepository;
            _libraryRepository = libraryRepository;
        }

        public List<Library> GetLibrarys()
        {
            return _libraryRepository.GetAll();
        }
        public bool BookInsert(Book book)
        {
            try
            {
                _bookRepository.Insert(book);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Book> GetBooks()
        {
            return _bookRepository.GetAll();
        }
    }
}
