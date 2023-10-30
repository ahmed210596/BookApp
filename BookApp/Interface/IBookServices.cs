using BookApp.Entities;

namespace BookApp.Interface
{

    public interface IBookServices
    {


        Task<long> Create(Book book);
        Task<Book> ReadByPk(long isbn);
        Task<int> Update(Book book, long pk);
        Task<int> Delete(long id);
        Task<int> Count(string search);
        Task<List<BookAuPub>> ListAll(int skip,
                                      int take,
                                      string orderBy,
                                      string direction,
                                      string search);
    }
}
