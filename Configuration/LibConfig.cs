using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;
using Taskk.Entities.Concretes;

namespace Taskk.Configuration
{
    public class LibConfig : IEntityTypeConfiguration<Lib>
    {
        public void Configure(EntityTypeBuilder<Lib> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasMany(y=>y.TCards)
                .WithOne(t=>t.Lib)
                .HasForeignKey(t=>t.LibId);

            builder.HasMany(y => y.SCards)
             .WithOne(t => t.Lib)
             .HasForeignKey(t => t.LibId);
        }
    }
}
