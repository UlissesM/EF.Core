using Code.First.Contexts;
using Code.First.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Code.First.Repositories
{
    public class BookRepository
    {
        public readonly LibraryContext _context;
        public BookRepository(LibraryContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Book> GetAll() =>
            _context.Books.ToList();

    }
}
