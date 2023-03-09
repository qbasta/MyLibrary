namespace MyLibrary
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks(string sTerm = "", int genreId = 0);
        Task<IEnumerable<Genre>> Genres();
        Task<IEnumerable<Author>> Authors();

    }
}