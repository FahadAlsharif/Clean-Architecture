using Domain.Entities;

namespace Application.Services.BookServices.Interface
{
    public interface IBookService
    {

        List<Library> GetLibrarys();
        List<Book> GetBooks();
        bool BookInsert(Book book);
    }
}
