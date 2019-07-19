using Data.First.Entities;
using Data.First.Mapping;
using Microsoft.EntityFrameworkCore;


namespace Data.First.Contexts
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
        {
   
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AuthorConfiguration());

            modelBuilder.Entity<BookDetails>().HasKey(p => p.Id);

            modelBuilder.Entity<Book>()
                .HasOne(p => p.BookDetails).WithOne()
                .HasForeignKey<Book>(e => e.Id);

            modelBuilder.Entity<BookDetails>().ToTable("Books", "library");
            modelBuilder.Entity<Book>().ToTable("Books", "library");


            base.OnModelCreating(modelBuilder);
        }
    }
}
