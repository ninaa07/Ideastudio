using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ideastudio.DataAccess.Configurations
{
    public class PovrsinaConfiguration : BaseEntityConfiguration<Povrsina>
    {
        public override void Configure(EntityTypeBuilder<Povrsina> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Oznaka).IsRequired();

            builder.Property(x => x.Naziv).IsRequired().HasMaxLength(50);

            builder.Property(x => x.VrstaPoda).IsRequired().HasMaxLength(20);

            builder.Property(x => x.Status).IsRequired();

            builder.HasOne(x => x.VrstaPovrsine)
                .WithMany(x => x.Povrsine)
                .HasForeignKey(x => x.VrstaPovrsineId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.ProjekatZaGradjevinskuDozvolu)
                .WithMany(x => x.Povrsine)
                .HasForeignKey(x => x.ProjekatZaGradjevinskuDozvoluId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
