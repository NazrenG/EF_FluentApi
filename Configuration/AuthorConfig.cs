using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taskk.Entities.Concretes;

namespace Taskk.Configuration
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
           builder.HasKey(x => x.Id);
            builder.Property(x=> x.Id).UseIdentityColumn();
            builder.Property(x=> x.Name).HasColumnName("FirstName")
                .HasColumnType("nvarchar(15)");

            builder.HasMany(builder => builder.Books)
                .WithOne(x => x.Author)
                .HasForeignKey(x => x.AuthorId);
        }
    }
}
