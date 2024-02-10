using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taskk.Entities.Concretes;

namespace Taskk.Configuration
{
    public class FacultyConfig : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasMany(builder => builder.Groups)
                .WithOne(x => x.Faculty)
                .HasForeignKey(builder => builder.FacultyId);
        }

    }
}
