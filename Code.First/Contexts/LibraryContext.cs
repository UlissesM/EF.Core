using Code.First.Entities;
using Code.First.Mapping;
using Code.First.Seed;
using Microsoft.EntityFrameworkCore;


namespace Code.First.Contexts
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());


            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}
