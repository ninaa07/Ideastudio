﻿// <auto-generated />
using System;
using Ideastudio.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ideastudio.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ideastudio.Domain.GlavniProjektant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BrojLicence")
                        .HasColumnType("bigint");

                    b.Property<string>("ImePrezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Zvanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("GlavniProjektant");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrojLicence = 134L,
                            ImePrezime = "ImePrezime 1",
                            Zvanje = "Zvanje 1"
                        },
                        new
                        {
                            Id = 2,
                            BrojLicence = 54L,
                            ImePrezime = "ImePrezime 2",
                            Zvanje = "Zvanje 2"
                        },
                        new
                        {
                            Id = 3,
                            BrojLicence = 5343L,
                            ImePrezime = "ImePrezime 3",
                            Zvanje = "Zvanje 3"
                        },
                        new
                        {
                            Id = 4,
                            BrojLicence = 28L,
                            ImePrezime = "ImePrezime 4",
                            Zvanje = "Zvanje 4"
                        },
                        new
                        {
                            Id = 5,
                            BrojLicence = 335L,
                            ImePrezime = "ImePrezime 5",
                            Zvanje = "Zvanje 5"
                        });
                });

            modelBuilder.Entity("Ideastudio.Domain.IdejnoResenje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzrade")
                        .HasColumnType("datetime2");

                    b.Property<int>("GlavniProjektantId")
                        .HasColumnType("int");

                    b.Property<int>("LokacijskaDozvolaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ObjekatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GlavniProjektantId");

                    b.HasIndex("LokacijskaDozvolaId");

                    b.HasIndex("ObjekatId");

                    b.ToTable("IdejnoResenje");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatumIzrade = new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(8247),
                            GlavniProjektantId = 2,
                            LokacijskaDozvolaId = 1,
                            Naziv = "Naziv 1",
                            ObjekatId = 4
                        },
                        new
                        {
                            Id = 2,
                            DatumIzrade = new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(9752),
                            GlavniProjektantId = 5,
                            LokacijskaDozvolaId = 5,
                            Naziv = "Naziv 2",
                            ObjekatId = 1
                        },
                        new
                        {
                            Id = 3,
                            DatumIzrade = new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(9781),
                            GlavniProjektantId = 1,
                            LokacijskaDozvolaId = 3,
                            Naziv = "Naziv 3",
                            ObjekatId = 3
                        },
                        new
                        {
                            Id = 4,
                            DatumIzrade = new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(9783),
                            GlavniProjektantId = 4,
                            LokacijskaDozvolaId = 2,
                            Naziv = "Naziv 4",
                            ObjekatId = 2
                        },
                        new
                        {
                            Id = 5,
                            DatumIzrade = new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(9851),
                            GlavniProjektantId = 3,
                            LokacijskaDozvolaId = 4,
                            Naziv = "Naziv 5",
                            ObjekatId = 5
                        });
                });

            modelBuilder.Entity("Ideastudio.Domain.InformacijeOLokaciji", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzdavanja")
                        .HasColumnType("datetime2");

                    b.Property<string>("NamenaZemljista")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zona")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("InformacijeOLokaciji");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatumIzdavanja = new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(8031),
                            NamenaZemljista = "Namena 1",
                            Naziv = "Naziv 1",
                            Zona = "Zona 1"
                        },
                        new
                        {
                            Id = 2,
                            DatumIzdavanja = new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(9471),
                            NamenaZemljista = "Namena 2",
                            Naziv = "Naziv 2",
                            Zona = "Zona 2"
                        },
                        new
                        {
                            Id = 3,
                            DatumIzdavanja = new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(9500),
                            NamenaZemljista = "Namena 3",
                            Naziv = "Naziv 3",
                            Zona = "Zona 3"
                        },
                        new
                        {
                            Id = 4,
                            DatumIzdavanja = new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(9503),
                            NamenaZemljista = "Namena 4",
                            Naziv = "Naziv 4",
                            Zona = "Zona 4"
                        },
                        new
                        {
                            Id = 5,
                            DatumIzdavanja = new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(9505),
                            NamenaZemljista = "Namena 5",
                            Naziv = "Naziv 5",
                            Zona = "Zona 5"
                        });
                });

            modelBuilder.Entity("Ideastudio.Domain.LokacijskaDozvola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BrojParcele")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DatumIzdavanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("InformacijeOLokacijiId")
                        .HasColumnType("int");

                    b.Property<string>("NazivObjekta")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long>("PovrsinaParcele")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("InformacijeOLokacijiId");

                    b.ToTable("LokacijskaDozvola");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrojParcele = 6934L,
                            DatumIzdavanja = new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(4484),
                            InformacijeOLokacijiId = 3,
                            NazivObjekta = "Naziv 1",
                            PovrsinaParcele = 324L
                        },
                        new
                        {
                            Id = 2,
                            BrojParcele = 48643L,
                            DatumIzdavanja = new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(5726),
                            InformacijeOLokacijiId = 2,
                            NazivObjekta = "Naziv 2",
                            PovrsinaParcele = 412L
                        },
                        new
                        {
                            Id = 3,
                            BrojParcele = 4843L,
                            DatumIzdavanja = new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(5764),
                            InformacijeOLokacijiId = 5,
                            NazivObjekta = "Naziv 3",
                            PovrsinaParcele = 3453L
                        },
                        new
                        {
                            Id = 4,
                            BrojParcele = 3458L,
                            DatumIzdavanja = new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(5767),
                            InformacijeOLokacijiId = 1,
                            NazivObjekta = "Naziv 4",
                            PovrsinaParcele = 34534L
                        },
                        new
                        {
                            Id = 5,
                            BrojParcele = 34343L,
                            DatumIzdavanja = new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(5768),
                            InformacijeOLokacijiId = 4,
                            NazivObjekta = "Naziv 5",
                            PovrsinaParcele = 3483L
                        });
                });

            modelBuilder.Entity("Ideastudio.Domain.Objekat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BrojParcele")
                        .HasColumnType("bigint");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Objekat");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrojParcele = 6934L,
                            Naziv = "Naziv 1"
                        },
                        new
                        {
                            Id = 2,
                            BrojParcele = 48643L,
                            Naziv = "Naziv 2"
                        },
                        new
                        {
                            Id = 3,
                            BrojParcele = 4843L,
                            Naziv = "Naziv 3"
                        },
                        new
                        {
                            Id = 4,
                            BrojParcele = 3458L,
                            Naziv = "Naziv 4"
                        },
                        new
                        {
                            Id = 5,
                            BrojParcele = 34343L,
                            Naziv = "Naziv 5"
                        });
                });

            modelBuilder.Entity("Ideastudio.Domain.Povrsina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Oznaka")
                        .HasColumnType("int");

                    b.Property<int>("ProjekatZaGradjevinskuDozvoluId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("VrstaPoda")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("VrstaPovrsineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjekatZaGradjevinskuDozvoluId");

                    b.HasIndex("VrstaPovrsineId");

                    b.ToTable("Povrsina");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Oznaka = 123,
                            ProjekatZaGradjevinskuDozvoluId = 1,
                            Status = 0,
                            VrstaPoda = "Vrsta 1",
                            VrstaPovrsineId = 4
                        },
                        new
                        {
                            Id = 2,
                            Oznaka = 75,
                            ProjekatZaGradjevinskuDozvoluId = 4,
                            Status = 0,
                            VrstaPoda = "Vrsta 2",
                            VrstaPovrsineId = 2
                        },
                        new
                        {
                            Id = 3,
                            Oznaka = 678,
                            ProjekatZaGradjevinskuDozvoluId = 3,
                            Status = 0,
                            VrstaPoda = "Vrsta 3",
                            VrstaPovrsineId = 3
                        },
                        new
                        {
                            Id = 4,
                            Oznaka = 74,
                            ProjekatZaGradjevinskuDozvoluId = 5,
                            Status = 0,
                            VrstaPoda = "Vrsta 4",
                            VrstaPovrsineId = 1
                        },
                        new
                        {
                            Id = 5,
                            Oznaka = 3857,
                            ProjekatZaGradjevinskuDozvoluId = 3,
                            Status = 0,
                            VrstaPoda = "Vrsta 5",
                            VrstaPovrsineId = 5
                        });
                });

            modelBuilder.Entity("Ideastudio.Domain.ProjekatZaGradjevinskuDozvolu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzrade")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdejnoResenjeId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("StatusDokumenta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdejnoResenjeId");

                    b.ToTable("ProjekatZaGradjevinskuDozvolu");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatumIzrade = new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(2144),
                            IdejnoResenjeId = 4,
                            Naziv = "Naziv 1",
                            StatusDokumenta = 0
                        },
                        new
                        {
                            Id = 2,
                            DatumIzrade = new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(3462),
                            IdejnoResenjeId = 1,
                            Naziv = "Naziv 2",
                            StatusDokumenta = 0
                        },
                        new
                        {
                            Id = 3,
                            DatumIzrade = new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(3496),
                            IdejnoResenjeId = 2,
                            Naziv = "Naziv 3",
                            StatusDokumenta = 0
                        },
                        new
                        {
                            Id = 4,
                            DatumIzrade = new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(3498),
                            IdejnoResenjeId = 5,
                            Naziv = "Naziv 4",
                            StatusDokumenta = 0
                        },
                        new
                        {
                            Id = 5,
                            DatumIzrade = new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(3500),
                            IdejnoResenjeId = 3,
                            Naziv = "Naziv 5",
                            StatusDokumenta = 0
                        });
                });

            modelBuilder.Entity("Ideastudio.Domain.Prostorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("VrstaPovrsineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VrstaPovrsineId");

                    b.ToTable("Prostorija");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Naziv = "Naziv 1",
                            VrstaPovrsineId = 1
                        },
                        new
                        {
                            Id = 2,
                            Naziv = "Naziv 2",
                            VrstaPovrsineId = 5
                        },
                        new
                        {
                            Id = 3,
                            Naziv = "Naziv 3",
                            VrstaPovrsineId = 3
                        },
                        new
                        {
                            Id = 4,
                            Naziv = "Naziv 4",
                            VrstaPovrsineId = 2
                        },
                        new
                        {
                            Id = 5,
                            Naziv = "Naziv 5",
                            VrstaPovrsineId = 4
                        });
                });

            modelBuilder.Entity("Ideastudio.Domain.VrstaPovrsine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("VrstaPovrsine");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Naziv = "Naziv 1"
                        },
                        new
                        {
                            Id = 2,
                            Naziv = "Naziv 2"
                        },
                        new
                        {
                            Id = 3,
                            Naziv = "Naziv 3"
                        },
                        new
                        {
                            Id = 4,
                            Naziv = "Naziv 4"
                        },
                        new
                        {
                            Id = 5,
                            Naziv = "Naziv 5"
                        });
                });

            modelBuilder.Entity("Ideastudio.Domain.IdejnoResenje", b =>
                {
                    b.HasOne("Ideastudio.Domain.GlavniProjektant", "GlavniProjektant")
                        .WithMany("IdejnaResenja")
                        .HasForeignKey("GlavniProjektantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ideastudio.Domain.LokacijskaDozvola", "LokacijskaDozvola")
                        .WithMany("IdejnaResenja")
                        .HasForeignKey("LokacijskaDozvolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ideastudio.Domain.Objekat", "Objekat")
                        .WithMany("IdejnaResenja")
                        .HasForeignKey("ObjekatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ideastudio.Domain.LokacijskaDozvola", b =>
                {
                    b.HasOne("Ideastudio.Domain.InformacijeOLokaciji", "InformacijeOLokaciji")
                        .WithMany("LokacijskeDozvole")
                        .HasForeignKey("InformacijeOLokacijiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ideastudio.Domain.Povrsina", b =>
                {
                    b.HasOne("Ideastudio.Domain.ProjekatZaGradjevinskuDozvolu", "ProjekatZaGradjevinskuDozvolu")
                        .WithMany("Povrsine")
                        .HasForeignKey("ProjekatZaGradjevinskuDozvoluId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ideastudio.Domain.VrstaPovrsine", "VrstaPovrsine")
                        .WithMany("Povrsine")
                        .HasForeignKey("VrstaPovrsineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ideastudio.Domain.ProjekatZaGradjevinskuDozvolu", b =>
                {
                    b.HasOne("Ideastudio.Domain.IdejnoResenje", "IdejnoResenje")
                        .WithMany("ProjektiZaGradjevinskuDozvolu")
                        .HasForeignKey("IdejnoResenjeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ideastudio.Domain.Prostorija", b =>
                {
                    b.HasOne("Ideastudio.Domain.VrstaPovrsine", "VrstaPovrsine")
                        .WithMany("Prostorije")
                        .HasForeignKey("VrstaPovrsineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
