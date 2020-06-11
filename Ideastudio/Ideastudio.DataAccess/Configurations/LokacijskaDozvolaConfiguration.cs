using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ideastudio.DataAccess.Configurations
{
    public class LokacijskaDozvolaConfiguration : BaseEntityConfiguration<LokacijskaDozvola>
    {
        public override void Configure(EntityTypeBuilder<LokacijskaDozvola> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Naziv).IsRequired().HasMaxLength(50);

            builder.Property(x => x.OpstiPodaci).IsRequired().HasMaxLength(255);

            builder.Property(x => x.LokacijskiUslovi).IsRequired().HasMaxLength(255);

            builder.Property(x => x.BrojParcele).IsRequired();

            builder.Property(x => x.PovrsinaParcele).IsRequired();

            builder.Property(x => x.DatumIzdavanja).IsRequired();

            builder.HasOne(x => x.InformacijeOLokaciji)
                .WithMany(x => x.LokacijskeDozvole)
                .HasForeignKey(x => x.InformacijeOLokacijiId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
