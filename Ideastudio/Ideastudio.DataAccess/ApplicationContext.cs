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
                new InformacijeOLokaciji { Id = 1, Naziv = "Informacije o lokaciji 1", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 1", Zona = "Zona 1" },
                new InformacijeOLokaciji { Id = 2, Naziv = "Informacije o lokaciji 2", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 2", Zona = "Zona 2" },
                new InformacijeOLokaciji { Id = 3, Naziv = "Informacije o lokaciji 3", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 3", Zona = "Zona 3" },
                new InformacijeOLokaciji { Id = 4, Naziv = "Informacije o lokaciji 4", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 4", Zona = "Zona 4" },
                new InformacijeOLokaciji { Id = 5, Naziv = "Informacije o lokaciji 5", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 5", Zona = "Zona 5" },
                new InformacijeOLokaciji { Id = 6, Naziv = "Informacije o lokaciji 6", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 6", Zona = "Zona 6" },
                new InformacijeOLokaciji { Id = 7, Naziv = "Informacije o lokaciji 7", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 7", Zona = "Zona 7" },
                new InformacijeOLokaciji { Id = 8, Naziv = "Informacije o lokaciji 8", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 8", Zona = "Zona 8" },
                new InformacijeOLokaciji { Id = 9, Naziv = "Informacije o lokaciji 9", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 9", Zona = "Zona 9" },
                new InformacijeOLokaciji { Id = 10, Naziv = "Informacije o lokaciji 10", DatumIzdavanja = DateTime.UtcNow, NamenaZemljista = "Namena 10", Zona = "Zona 10" }
            );

            builder.Entity<LokacijskaDozvola>().HasData(
                new LokacijskaDozvola { Id = 1, Naziv = "Lokacijska dozvola 1", OpstiPodaci = "Opsti podaci 1", LokacijskiUslovi = "Lokacijski uslovi 1", BrojParcele = 6934, PovrsinaParcele = 324, DatumIzdavanja = DateTime.UtcNow, InformacijeOLokacijiId = 3 },
                new LokacijskaDozvola { Id = 2, Naziv = "Lokacijska dozvola 2", OpstiPodaci = "Opsti podaci 2", LokacijskiUslovi = "Lokacijski uslovi 2", BrojParcele = 48643, PovrsinaParcele = 412, DatumIzdavanja = DateTime.UtcNow, InformacijeOLokacijiId = 2 },
                new LokacijskaDozvola { Id = 3, Naziv = "Lokacijska dozvola 3", OpstiPodaci = "Opsti podaci 3", LokacijskiUslovi = "Lokacijski uslovi 3", BrojParcele = 4843, PovrsinaParcele = 3453, DatumIzdavanja = DateTime.UtcNow, InformacijeOLokacijiId = 5 },
                new LokacijskaDozvola { Id = 4, Naziv = "Lokacijska dozvola 4", OpstiPodaci = "Opsti podaci 4", LokacijskiUslovi = "Lokacijski uslovi 4", BrojParcele = 3458, PovrsinaParcele = 34534, DatumIzdavanja = DateTime.UtcNow, InformacijeOLokacijiId = 1 },
                new LokacijskaDozvola { Id = 5, Naziv = "Lokacijska dozvola 5", OpstiPodaci = "Opsti podaci 5", LokacijskiUslovi = "Lokacijski uslovi 5", BrojParcele = 34343, PovrsinaParcele = 3483, DatumIzdavanja = DateTime.UtcNow, InformacijeOLokacijiId = 4 }
            );

            builder.Entity<IdejnoResenje>().HasData(
                new IdejnoResenje { Id = 1, Naziv = "Idejno resenje 1", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 2, ObjekatId = 4, LokacijskaDozvolaId = 1 },
                new IdejnoResenje { Id = 2, Naziv = "Idejno resenje 2", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 5, ObjekatId = 1, LokacijskaDozvolaId = 5 },
                new IdejnoResenje { Id = 3, Naziv = "Idejno resenje 3", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 1, ObjekatId = 3, LokacijskaDozvolaId = 3 },
                new IdejnoResenje { Id = 4, Naziv = "Idejno resenje 4", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 4, ObjekatId = 2, LokacijskaDozvolaId = 2 },
                new IdejnoResenje { Id = 5, Naziv = "Idejno resenje 5", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 3, ObjekatId = 5, LokacijskaDozvolaId = 4 },
                new IdejnoResenje { Id = 6, Naziv = "Idejno resenje 6", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 2, ObjekatId = 3, LokacijskaDozvolaId = 1 },
                new IdejnoResenje { Id = 7, Naziv = "Idejno resenje 7", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 1, ObjekatId = 3, LokacijskaDozvolaId = 2 },
                new IdejnoResenje { Id = 8, Naziv = "Idejno resenje 8", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 2, ObjekatId = 4, LokacijskaDozvolaId = 4 },
                new IdejnoResenje { Id = 9, Naziv = "Idejno resenje 9", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 4, ObjekatId = 4, LokacijskaDozvolaId = 4 },
                new IdejnoResenje { Id = 10, Naziv = "Idejno resenje 10", DatumIzrade = DateTime.UtcNow, GlavniProjektantId = 4, ObjekatId = 5, LokacijskaDozvolaId = 5 }
            );

            builder.Entity<Objekat>().HasData(
                new Objekat { Id = 1, Naziv = "Objekat 1", Dimenzije = 323, Karakteristike = "Karakteristika 1" },
                new Objekat { Id = 2, Naziv = "Objekat 2", Dimenzije = 432, Karakteristike = "Karakteristika 2" },
                new Objekat { Id = 3, Naziv = "Objekat 3", Dimenzije = 545, Karakteristike = "Karakteristika 3" },
                new Objekat { Id = 4, Naziv = "Objekat 4", Dimenzije = 216, Karakteristike = "Karakteristika 4" },
                new Objekat { Id = 5, Naziv = "Objekat 5", Dimenzije = 786, Karakteristike = "Karakteristika 5" }
            );

            builder.Entity<ProjekatZaGradjevinskuDozvolu>().HasData(
                new ProjekatZaGradjevinskuDozvolu { Id = 1, Naziv = "Projekat 1", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 2, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 2, Naziv = "Projekat 2", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 7, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 3, Naziv = "Projekat 3", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 9, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 4, Naziv = "Projekat 4", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 1, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 5, Naziv = "Projekat 5", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 5, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 6, Naziv = "Projekat 6", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 3, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 7, Naziv = "Projekat 7", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 10, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 8, Naziv = "Projekat 8", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 4, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 9, Naziv = "Projekat 9", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 8, StatusDokumenta = StatusDokumenta.Nov },
                new ProjekatZaGradjevinskuDozvolu { Id = 10, Naziv = "Projekat 10", DatumIzrade = DateTime.UtcNow, IdejnoResenjeId = 6, StatusDokumenta = StatusDokumenta.Nov }
            );

            builder.Entity<GlavniProjektant>().HasData(
                new GlavniProjektant { Id = 1, ImePrezime = "ImePrezime 1", BrojLicence = 134, Zvanje = "Zvanje 1" },
                new GlavniProjektant { Id = 2, ImePrezime = "ImePrezime 2", BrojLicence = 54, Zvanje = "Zvanje 2" },
                new GlavniProjektant { Id = 3, ImePrezime = "ImePrezime 3", BrojLicence = 5343, Zvanje = "Zvanje 3" },
                new GlavniProjektant { Id = 4, ImePrezime = "ImePrezime 4", BrojLicence = 28, Zvanje = "Zvanje 4" },
                new GlavniProjektant { Id = 5, ImePrezime = "ImePrezime 5", BrojLicence = 335, Zvanje = "Zvanje 5" }
            );

            builder.Entity<Prostorija>().HasData(
                new Prostorija { Id = 1, Naziv = "Prostorija 1", VrstaPovrsineId = 1 },
                new Prostorija { Id = 2, Naziv = "Prostorija 2", VrstaPovrsineId = 5 },
                new Prostorija { Id = 3, Naziv = "Prostorija 3", VrstaPovrsineId = 3 },
                new Prostorija { Id = 4, Naziv = "Prostorija 4", VrstaPovrsineId = 2 },
                new Prostorija { Id = 5, Naziv = "Prostorija 5", VrstaPovrsineId = 4 }
            );

            builder.Entity<VrstaPovrsine>().HasData(
                new VrstaPovrsine { Id = 1, Naziv = "Vrsta povrsine 1" },
                new VrstaPovrsine { Id = 2, Naziv = "Vrsta povrsine 2" },
                new VrstaPovrsine { Id = 3, Naziv = "Vrsta povrsine 3" },
                new VrstaPovrsine { Id = 4, Naziv = "Vrsta povrsine 4" },
                new VrstaPovrsine { Id = 5, Naziv = "Vrsta povrsine 5" }
            );

            builder.Entity<Povrsina>().HasData(
                new Povrsina { Id = 1, Naziv = "Povrsina 1", Oznaka = 1423, VrstaPoda = "Vrsta 1", ProjekatZaGradjevinskuDozvoluId = 1, VrstaPovrsineId = 4 },
                new Povrsina { Id = 2, Naziv = "Povrsina 2", Oznaka = 755, VrstaPoda = "Vrsta 2", ProjekatZaGradjevinskuDozvoluId = 4, VrstaPovrsineId = 2 },
                new Povrsina { Id = 3, Naziv = "Povrsina 3", Oznaka = 678, VrstaPoda = "Vrsta 3", ProjekatZaGradjevinskuDozvoluId = 3, VrstaPovrsineId = 3 },
                new Povrsina { Id = 4, Naziv = "Povrsina 4", Oznaka = 7434, VrstaPoda = "Vrsta 4", ProjekatZaGradjevinskuDozvoluId = 5, VrstaPovrsineId = 1 },
                new Povrsina { Id = 5, Naziv = "Povrsina 5", Oznaka = 231, VrstaPoda = "Vrsta 5", ProjekatZaGradjevinskuDozvoluId = 3, VrstaPovrsineId = 5 },
                new Povrsina { Id = 6, Naziv = "Povrsina 6", Oznaka = 3121, VrstaPoda = "Vrsta 6", ProjekatZaGradjevinskuDozvoluId = 3, VrstaPovrsineId = 5 },
                new Povrsina { Id = 7, Naziv = "Povrsina 7", Oznaka = 542, VrstaPoda = "Vrsta 7", ProjekatZaGradjevinskuDozvoluId = 2, VrstaPovrsineId = 1 },
                new Povrsina { Id = 8, Naziv = "Povrsina 8", Oznaka = 64, VrstaPoda = "Vrsta 8", ProjekatZaGradjevinskuDozvoluId = 2, VrstaPovrsineId = 1 },
                new Povrsina { Id = 9, Naziv = "Povrsina 9", Oznaka = 113, VrstaPoda = "Vrsta 9", ProjekatZaGradjevinskuDozvoluId = 1, VrstaPovrsineId = 2 },
                new Povrsina { Id = 10, Naziv = "Povrsina 10", Oznaka = 11, VrstaPoda = "Vrsta 10", ProjekatZaGradjevinskuDozvoluId = 1, VrstaPovrsineId = 3 },
                new Povrsina { Id = 11, Naziv = "Povrsina 11", Oznaka = 432, VrstaPoda = "Vrsta 11", ProjekatZaGradjevinskuDozvoluId = 1, VrstaPovrsineId = 4 },
                new Povrsina { Id = 12, Naziv = "Povrsina 12", Oznaka = 554, VrstaPoda = "Vrsta 12", ProjekatZaGradjevinskuDozvoluId = 4, VrstaPovrsineId = 2 },
                new Povrsina { Id = 13, Naziv = "Povrsina 13", Oznaka = 32, VrstaPoda = "Vrsta 13", ProjekatZaGradjevinskuDozvoluId = 3, VrstaPovrsineId = 3 },
                new Povrsina { Id = 14, Naziv = "Povrsina 14", Oznaka = 456, VrstaPoda = "Vrsta 14", ProjekatZaGradjevinskuDozvoluId = 5, VrstaPovrsineId = 1 },
                new Povrsina { Id = 15, Naziv = "Povrsina 15", Oznaka = 231, VrstaPoda = "Vrsta 15", ProjekatZaGradjevinskuDozvoluId = 3, VrstaPovrsineId = 5 },
                new Povrsina { Id = 16, Naziv = "Povrsina 16", Oznaka = 411, VrstaPoda = "Vrsta 16", ProjekatZaGradjevinskuDozvoluId = 3, VrstaPovrsineId = 5 },
                new Povrsina { Id = 17, Naziv = "Povrsina 17", Oznaka = 231, VrstaPoda = "Vrsta 17", ProjekatZaGradjevinskuDozvoluId = 2, VrstaPovrsineId = 1 },
                new Povrsina { Id = 18, Naziv = "Povrsina 18", Oznaka = 467, VrstaPoda = "Vrsta 18", ProjekatZaGradjevinskuDozvoluId = 2, VrstaPovrsineId = 1 },
                new Povrsina { Id = 19, Naziv = "Povrsina 19", Oznaka = 111, VrstaPoda = "Vrsta 19", ProjekatZaGradjevinskuDozvoluId = 1, VrstaPovrsineId = 2 },
                new Povrsina { Id = 20, Naziv = "Povrsina 20", Oznaka = 978, VrstaPoda = "Vrsta 20", ProjekatZaGradjevinskuDozvoluId = 1, VrstaPovrsineId = 3 },
                new Povrsina { Id = 21, Naziv = "Povrsina 21", Oznaka = 65, VrstaPoda = "Vrsta 21", ProjekatZaGradjevinskuDozvoluId = 6, VrstaPovrsineId = 4 },
                new Povrsina { Id = 22, Naziv = "Povrsina 22", Oznaka = 234, VrstaPoda = "Vrsta 22", ProjekatZaGradjevinskuDozvoluId = 9, VrstaPovrsineId = 2 },
                new Povrsina { Id = 23, Naziv = "Povrsina 23", Oznaka = 543, VrstaPoda = "Vrsta 23", ProjekatZaGradjevinskuDozvoluId = 8, VrstaPovrsineId = 3 },
                new Povrsina { Id = 24, Naziv = "Povrsina 24", Oznaka = 54, VrstaPoda = "Vrsta 24", ProjekatZaGradjevinskuDozvoluId = 10, VrstaPovrsineId = 1 },
                new Povrsina { Id = 25, Naziv = "Povrsina 25", Oznaka = 7865, VrstaPoda = "Vrsta 25", ProjekatZaGradjevinskuDozvoluId = 8, VrstaPovrsineId = 5 },
                new Povrsina { Id = 26, Naziv = "Povrsina 26", Oznaka = 465, VrstaPoda = "Vrsta 26", ProjekatZaGradjevinskuDozvoluId = 8, VrstaPovrsineId = 5 },
                new Povrsina { Id = 27, Naziv = "Povrsina 27", Oznaka = 123, VrstaPoda = "Vrsta 27", ProjekatZaGradjevinskuDozvoluId = 7, VrstaPovrsineId = 1 },
                new Povrsina { Id = 28, Naziv = "Povrsina 28", Oznaka = 541, VrstaPoda = "Vrsta 28", ProjekatZaGradjevinskuDozvoluId = 7, VrstaPovrsineId = 1 },
                new Povrsina { Id = 29, Naziv = "Povrsina 29", Oznaka = 313, VrstaPoda = "Vrsta 29", ProjekatZaGradjevinskuDozvoluId = 6, VrstaPovrsineId = 2 },
                new Povrsina { Id = 30, Naziv = "Povrsina 30", Oznaka = 467, VrstaPoda = "Vrsta 30", ProjekatZaGradjevinskuDozvoluId = 6, VrstaPovrsineId = 3 },
                new Povrsina { Id = 31, Naziv = "Povrsina 41", Oznaka = 984, VrstaPoda = "Vrsta 31", ProjekatZaGradjevinskuDozvoluId = 6, VrstaPovrsineId = 4 },
                new Povrsina { Id = 32, Naziv = "Povrsina 42", Oznaka = 32, VrstaPoda = "Vrsta 32", ProjekatZaGradjevinskuDozvoluId = 9, VrstaPovrsineId = 2 },
                new Povrsina { Id = 33, Naziv = "Povrsina 43", Oznaka = 7764, VrstaPoda = "Vrsta 33", ProjekatZaGradjevinskuDozvoluId = 8, VrstaPovrsineId = 3 },
                new Povrsina { Id = 34, Naziv = "Povrsina 44", Oznaka = 65342, VrstaPoda = "Vrsta 34", ProjekatZaGradjevinskuDozvoluId = 10, VrstaPovrsineId = 1 },
                new Povrsina { Id = 35, Naziv = "Povrsina 45", Oznaka = 3219, VrstaPoda = "Vrsta 35", ProjekatZaGradjevinskuDozvoluId = 8, VrstaPovrsineId = 5 },
                new Povrsina { Id = 36, Naziv = "Povrsina 46", Oznaka = 890, VrstaPoda = "Vrsta 36", ProjekatZaGradjevinskuDozvoluId = 8, VrstaPovrsineId = 5 },
                new Povrsina { Id = 37, Naziv = "Povrsina 47", Oznaka = 203, VrstaPoda = "Vrsta 37", ProjekatZaGradjevinskuDozvoluId = 7, VrstaPovrsineId = 1 },
                new Povrsina { Id = 38, Naziv = "Povrsina 48", Oznaka = 110, VrstaPoda = "Vrsta 38", ProjekatZaGradjevinskuDozvoluId = 7, VrstaPovrsineId = 1 },
                new Povrsina { Id = 39, Naziv = "Povrsina 49", Oznaka = 903, VrstaPoda = "Vrsta 39", ProjekatZaGradjevinskuDozvoluId = 6, VrstaPovrsineId = 2 },
                new Povrsina { Id = 40, Naziv = "Povrsina 50", Oznaka = 314, VrstaPoda = "Vrsta 40", ProjekatZaGradjevinskuDozvoluId = 6, VrstaPovrsineId = 3 }
            );
        }
    }
}
