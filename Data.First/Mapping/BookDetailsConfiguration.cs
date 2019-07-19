using Data.First.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.First.Mapping
{
    public class BookDetailsConfiguration : IEntityTypeConfiguration<BookDetails>
    {
        public void Configure(EntityTypeBuilder<BookDetails> builder)
        {
            builder.ToTable("Books", "library");

            builder.HasKey(p => p.Id);

            builder.Property(x => x.Language).HasColumnType("varchar(200)");
            builder.Property(x => x.IsAvailable).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.PageNumbers);
        }

    }
}
