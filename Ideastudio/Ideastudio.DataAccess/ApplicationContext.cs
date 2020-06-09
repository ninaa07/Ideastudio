using Ideastudio.DataAccess.Configurations;
using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

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

            builder.Entity<InformacijeOLokaciji>().HasData(
                new InformacijeOLokaciji { Id = 1, Naziv = "Naziv 1", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 1", Zona = "Zona 1"},
                new InformacijeOLokaciji { Id = 2, Naziv = "Naziv 2", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 2", Zona = "Zona 2" },
                new InformacijeOLokaciji { Id = 3, Naziv = "Naziv 3", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 3", Zona = "Zona 3" },
                new InformacijeOLokaciji { Id = 4, Naziv = "Naziv 4", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 4", Zona = "Zona 4" },
                new InformacijeOLokaciji { Id = 5, Naziv = "Naziv 5", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 5", Zona = "Zona 5" }
            );

            builder.Entity<LokacijskaDozvola>().HasData(
                new LokacijskaDozvola { Id = 1, BrojParcele = 6934, PovrsinaParcele = 324, DatumIzdavanja = DateTime.UtcNow, NazivObjekta = "Naziv 1", InformacijeOLokacijiId = 3 },
                new LokacijskaDozvola { Id = 2, BrojParcele = 48643, PovrsinaParcele = 412, DatumIzdavanja = DateTime.UtcNow, NazivObjekta = "Naziv 2", InformacijeOLokacijiId = 2 },
                new LokacijskaDozvola { Id = 3, BrojParcele = 4843, PovrsinaParcele = 3453, DatumIzdavanja = DateTime.UtcNow, NazivObjekta = "Naziv 3", InformacijeOLokacijiId = 5 },
                new LokacijskaDozvola { Id = 4, BrojParcele = 3458, PovrsinaParcele = 34534, DatumIzdavanja = DateTime.UtcNow, NazivObjekta = "Naziv 4", InformacijeOLokacijiId = 1 },
                new LokacijskaDozvola { Id = 5, BrojParcele = 34343, PovrsinaParcele = 3483, DatumIzdavanja = DateTime.UtcNow, NazivObjekta = "Naziv 5", InformacijeOLokacijiId = 4 }
            );

            builder.Entity<IdejnoResenje>().HasData(
                new IdejnoResenje { Id = 1, Naziv = "Naziv 1", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 2, ObjekatId = 4, LokacijskaDozvolaId = 1 },
                new IdejnoResenje { Id = 2, Naziv = "Naziv 2", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 5, ObjekatId = 1, LokacijskaDozvolaId = 5 },
                new IdejnoResenje { Id = 3, Naziv = "Naziv 3", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 1, ObjekatId = 3, LokacijskaDozvolaId = 3 },
                new IdejnoResenje { Id = 4, Naziv = "Naziv 4", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 4, ObjekatId = 2, LokacijskaDozvolaId = 2 },
                new IdejnoResenje { Id = 5, Naziv = "Naziv 5", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 3, ObjekatId = 5, LokacijskaDozvolaId = 4 }
            );

            builder.Entity<ProjekatZaGradjevinskuDozvolu>().HasData(
                new ProjekatZaGradjevinskuDozvolu { Id = 1, Naziv = "Naziv 1", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 4, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 2, Naziv = "Naziv 2", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 1, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 3, Naziv = "Naziv 3", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 2, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 4, Naziv = "Naziv 4", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 5, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 5, Naziv = "Naziv 5", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 3, StatusDokumenta = StatusDokumenta.Nov }
            );

            builder.Entity<GlavniProjektant>().HasData(
                new GlavniProjektant { Id = 1, ImePrezime = "ImePrezime 1", BrojLicence = 134, Zvanje = "Zvanje 1" },
                new GlavniProjektant { Id = 2, ImePrezime = "ImePrezime 2", BrojLicence = 54, Zvanje = "Zvanje 2" },
                new GlavniProjektant { Id = 3, ImePrezime = "ImePrezime 3", BrojLicence = 5343, Zvanje = "Zvanje 3" },
                new GlavniProjektant { Id = 4, ImePrezime = "ImePrezime 4", BrojLicence = 28, Zvanje = "Zvanje 4" },
                new GlavniProjektant { Id = 5, ImePrezime = "ImePrezime 5", BrojLicence = 335, Zvanje = "Zvanje 5" }
            );

            builder.Entity<Objekat>().HasData(
                new Objekat { Id = 1, BrojParcele = 6934, Naziv = "Naziv 1" },
                new Objekat { Id = 2, BrojParcele = 48643, Naziv = "Naziv 2" },
                new Objekat { Id = 3, BrojParcele = 4843, Naziv = "Naziv 3" },
                new Objekat { Id = 4, BrojParcele = 3458, Naziv = "Naziv 4" },
                new Objekat { Id = 5, BrojParcele = 34343, Naziv = "Naziv 5" }
            );

            builder.Entity<Prostorija>().HasData(
                new Prostorija { Id = 1, Naziv = "Naziv 1", VrstaPovrsineId = 1 },
                new Prostorija { Id = 2, Naziv = "Naziv 2", VrstaPovrsineId = 5 },
                new Prostorija { Id = 3, Naziv = "Naziv 3", VrstaPovrsineId = 3 },
                new Prostorija { Id = 4, Naziv = "Naziv 4", VrstaPovrsineId = 2 },
                new Prostorija { Id = 5, Naziv = "Naziv 5", VrstaPovrsineId = 4 }
            );

            builder.Entity<VrstaPovrsine>().HasData(
                new VrstaPovrsine { Id = 1, Naziv = "Naziv 1" },
                new VrstaPovrsine { Id = 2, Naziv = "Naziv 2" },
                new VrstaPovrsine { Id = 3, Naziv = "Naziv 3" },
                new VrstaPovrsine { Id = 4, Naziv = "Naziv 4" },
                new VrstaPovrsine { Id = 5, Naziv = "Naziv 5" }
            );

            builder.Entity<Povrsina>().HasData(
                new Povrsina { Id = 1, Oznaka = 123, VrstaPoda = "Vrsta 1", ProjekatZaGradjevinskuDozvoluId = 1, VrstaPovrsineId = 4 },
                new Povrsina { Id = 2, Oznaka = 75, VrstaPoda = "Vrsta 2", ProjekatZaGradjevinskuDozvoluId = 4, VrstaPovrsineId = 2 },
                new Povrsina { Id = 3, Oznaka = 678, VrstaPoda = "Vrsta 3", ProjekatZaGradjevinskuDozvoluId = 3, VrstaPovrsineId = 3 },
                new Povrsina { Id = 4, Oznaka = 74, VrstaPoda = "Vrsta 4", ProjekatZaGradjevinskuDozvoluId = 5, VrstaPovrsineId = 1 },
                new Povrsina { Id = 5, Oznaka = 3857, VrstaPoda = "Vrsta 5", ProjekatZaGradjevinskuDozvoluId = 3, VrstaPovrsineId = 5 }
            );
        }
    }
}
