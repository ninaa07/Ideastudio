using Ideastudio.DataAccess.Configurations;
using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ideastudio.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public virtual DbSet<GlavniProjektant> GlavniProjektanti { get; set; }

        public virtual DbSet<IdejnoResenje> IdejnaResenja { get; set; }

        public virtual DbSet<InformacijeOLokaciji> InformacijeOLokacijama { get; set; }

        public virtual DbSet<LokacijskaDozvola> LokacijskeDozvole { get; set; }

        public virtual DbSet<Objekat> Objekti { get; set; }

        public virtual DbSet<Povrsina> Povrsine { get; set; }

        public virtual DbSet<ProjekatZaGradjevinskuDozvolu> ProjektiZaGradjevinskuDozvolu { get; set; }

        public virtual DbSet<Prostorija> Prostorije { get; set; }

        public virtual DbSet<VrstaPovrsine> VrstePovrsine { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                builder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name);
            }

            builder.ApplyConfiguration(new GlavniProjektantConfiguration());
            
            builder.ApplyConfiguration(new IdejnoResenjeConfiguration());
            
            builder.ApplyConfiguration(new InformacijeOLokacijiConfiguration());
            
            builder.ApplyConfiguration(new LokacijskaDozvolaConfiguration());
            
            builder.ApplyConfiguration(new ObjekatConfiguration());
            
            builder.ApplyConfiguration(new PovrsinaConfiguration());
            
            builder.ApplyConfiguration(new ProjekatZaGradjevinskuDozvoluConfiguration());
            
            builder.ApplyConfiguration(new ProstorijaConfiguration());

            builder.ApplyConfiguration(new VrstaPovrsineConfiguration());
        }
    }
}
