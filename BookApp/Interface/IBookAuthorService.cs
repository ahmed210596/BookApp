using BookApp.Entities;

namespace BookApp.Interface
{
    public interface IBookAuthorService
    {

        Task<int> Create(BookAuthorName bookAuthorNamer);
        Task<int> Delete(long isbn, int authorId);
        Task<List<BookAuthorName>> FetchAll(long isbn);
    }
}
