using Code.First.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Code.First.Mapping
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books", "library");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Language).HasColumnType("varchar(200)");
            builder.Property(x => x.IsAvailable).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.PageNumbers);

            builder.HasIndex(x => x.AuthorId).IsUnique(false);
        }

    }
}
