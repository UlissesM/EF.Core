using Data.First.Contexts;
using Data.First.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.First.Repositories
{
    public class BookRepository
    {
        public readonly LibraryContext _context;
        public BookRepository(LibraryContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _context.Books.AsNoTracking().Include(x => x.BookDetails)
                         .ToListAsync();

        }
         


    }
}
