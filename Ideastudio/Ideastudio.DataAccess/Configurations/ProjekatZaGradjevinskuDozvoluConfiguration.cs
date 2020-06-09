using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ideastudio.DataAccess.Configurations
{
    public class ProjekatZaGradjevinskuDozvoluConfiguration : BaseEntityConfiguration<ProjekatZaGradjevinskuDozvolu>
    {
        public override void Configure(EntityTypeBuilder<ProjekatZaGradjevinskuDozvolu> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Naziv).IsRequired().HasMaxLength(50);

            builder.Property(x => x.DatumIzrade).IsRequired();

            builder.HasOne(x => x.IdejnoResenje)
                .WithMany(x => x.ProjektiZaGradjevinskuDozvolu)
                .HasForeignKey(x => x.IdejnoResenjeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
