using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ideastudio.DataAccess.Configurations
{
    public class GlavniProjektantConfiguration : BaseEntityConfiguration<GlavniProjektant>
    {
        public override void Configure(EntityTypeBuilder<GlavniProjektant> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.ImePrezime).IsRequired().HasMaxLength(100);
            
            builder.Property(x => x.BrojLicence).IsRequired();

            builder.Property(x => x.Zvanje).IsRequired().HasMaxLength(20);
        }
    }
}
