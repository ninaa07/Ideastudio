using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ideastudio.DataAccess.Configurations
{
    public class ProstorijaConfiguration : BaseEntityConfiguration<Prostorija>
    {
        public override void Configure(EntityTypeBuilder<Prostorija> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Naziv).IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.VrstaPovrsine)
                .WithMany(x => x.Prostorije)
                .HasForeignKey(x => x.VrstaPovrsineId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
