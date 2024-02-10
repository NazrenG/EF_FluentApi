using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taskk.Entities.Concretes;

namespace Taskk.Configuration
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name) .HasColumnType("nvarchar(15)");

            builder.HasMany(builder =>builder.SCards)
                .WithOne(s=>s.Book)
                .HasForeignKey(s => s.BookId);

            builder.HasMany(builder => builder.TCards)
               .WithOne(s => s.Book)
               .HasForeignKey(s => s.BookId);

            builder.HasOne(builder => builder.Theme)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.ThemeId);


            builder.HasOne(builder => builder.Press)
               .WithMany(x => x.Books)
               .HasForeignKey(x => x.PressId);
        }

      
    }
}
