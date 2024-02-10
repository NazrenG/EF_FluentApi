using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taskk.Entities.Concretes;

namespace Taskk.Configuration
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasMany(builder =>builder.Taechers)
                .WithOne(x => x.Department)
                .HasForeignKey(builder => builder.DepartmentId);
        }
    }
}
