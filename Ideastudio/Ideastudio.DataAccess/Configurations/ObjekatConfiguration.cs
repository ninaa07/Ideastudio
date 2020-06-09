using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ideastudio.DataAccess.Configurations
{
    public class ObjekatConfiguration : BaseEntityConfiguration<Objekat>
    {
        public override void Configure(EntityTypeBuilder<Objekat> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.BrojParcele).IsRequired();

            builder.Property(x => x.Naziv).IsRequired().HasMaxLength(50);
        }
    }
}
