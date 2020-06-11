using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ideastudio.DataAccess.Configurations
{
    public class ObjekatConfiguration : BaseEntityConfiguration<Objekat>
    {
        public override void Configure(EntityTypeBuilder<Objekat> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Naziv).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Dimenzije).IsRequired().HasColumnType("decimal(10,2)");

            builder.Property(x => x.Karakteristike).IsRequired().HasMaxLength(255);
        }
    }
}
