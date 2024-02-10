using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;
using Taskk.Entities.Concretes;

namespace Taskk.Configuration
{
    public class S_CardConfig : IEntityTypeConfiguration<S_Card>
    {
        public void Configure(EntityTypeBuilder<S_Card> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.Student)
                .WithMany(y => y.SCards)
                .HasForeignKey(x => x.StudentId);
        }
    }
}
