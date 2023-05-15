c#

namespace ndm.Service
{
    using ndm.DTO;

    public interface IBookService
    {
        Book GetBookById(int id);

        IEnumerable<Book> GetAllBooks();

        void CreateBook(Book book);

        void UpdateBook(Book book);

        void DeleteBook(int id);
    }
}