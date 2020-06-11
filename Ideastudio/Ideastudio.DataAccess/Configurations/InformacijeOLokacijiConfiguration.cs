using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ideastudio.DataAccess.Configurations
{
    public class InformacijeOLokacijiConfiguration : BaseEntityConfiguration<InformacijeOLokaciji>
    {
        public override void Configure(EntityTypeBuilder<InformacijeOLokaciji> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Naziv).IsRequired().HasMaxLength(50);

            builder.Property(x => x.DatumIzdavanja).IsRequired();
            
            builder.Property(x => x.NamenaZemljista).IsRequired().HasMaxLength(255);
            
            builder.Property(x => x.Zona).IsRequired().HasMaxLength(50);
        }
    }
}
