using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;
using Taskk.Entities.Concretes;
namespace Taskk.Configuration
{
    public class T_CardConfig : IEntityTypeConfiguration<T_Card>
    {
        public void Configure(EntityTypeBuilder<T_Card> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x=>x.Taecher)
                .WithMany(y=>y.TCards)
                .HasForeignKey(x=>x.TaecherId);
        }
    }
}
