using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taskk.Entities.Concretes;

namespace Taskk.Configuration
{
    public class GroupConfig : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasMany(builder => builder.Students)
                .WithOne(x => x.Group)
                .HasForeignKey(builder => builder.GroupId);
        }

      
    }
}
