using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ideastudio.DataAccess.Configurations
{
    public class IdejnoResenjeConfiguration : BaseEntityConfiguration<IdejnoResenje>
    {
        public override void Configure(EntityTypeBuilder<IdejnoResenje> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Naziv).IsRequired().HasMaxLength(50);

            builder.Property(x => x.DatumIzrade).IsRequired();

            builder.HasOne(x => x.GlavniProjektant)
                .WithMany(x => x.IdejnaResenja)
                .HasForeignKey(x => x.GlavniProjektantId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Objekat)
                .WithMany(x => x.IdejnaResenja)
                .HasForeignKey(x => x.ObjekatId)
                .OnDelete(DeleteBehavior.Cascade); 
            
            builder.HasOne(x => x.LokacijskaDozvola)
                .WithMany(x => x.IdejnaResenja)
                .HasForeignKey(x => x.LokacijskaDozvolaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
