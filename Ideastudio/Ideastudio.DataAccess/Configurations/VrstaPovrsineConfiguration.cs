using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ideastudio.DataAccess.Configurations
{
    public class VrstaPovrsineConfiguration : BaseEntityConfiguration<VrstaPovrsine>
    {
        public override void Configure(EntityTypeBuilder<VrstaPovrsine> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Naziv).IsRequired().HasMaxLength(50);
        }
    }
}
