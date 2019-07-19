using Code.First.Entities;
using Microsoft.EntityFrameworkCore;

namespace Code.First.Seed
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder builder)
        {
            var author = new Author { Name = "Robert", LastName = "Martin", Id=111 };
           builder
              .Entity<Author>()
              .HasData(
                      author
              );

            builder
            .Entity<Book>()
            .HasData(
                    new Book { Id=1, Title= "Clean Architecture", AuthorId=111, Language="English", PageNumbers = 100}
            );
        }
    }
}
