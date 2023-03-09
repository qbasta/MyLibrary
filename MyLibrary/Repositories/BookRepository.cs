using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Genre>> Genres()
        {
            return await _context.Genres.ToListAsync();
        }

        public async Task<IEnumerable<Author>> Authors()
        {
            return await _context.Authors.ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetBooks(string sTerm = "", int genreId = 0)
        {
            sTerm = sTerm.ToLower();

            IEnumerable<Book> books = await (from book in _context.Books
                         join genre in _context.Genres
                         on book.GenreId equals genre.Id
                         where string.IsNullOrWhiteSpace(sTerm) || (book != null && book.Name.ToLower().StartsWith(sTerm))
                         select new Book
                         {
                             Id = book.Id,
                             Image = book.Image,
                             AuthorId = book.AuthorId,
                             Name = book.Name,
                             GenreId = book.GenreId,
                             Price = book.Price,
                             Amount = book.Amount,
                             ISBN = book.ISBN,
                             GenreName = book.GenreName,

                         }).ToListAsync();

            if (genreId > 0)
            {
                books = books.Where(a => a.GenreId == genreId).ToList();
            }
            return books;

        }

    }
}
