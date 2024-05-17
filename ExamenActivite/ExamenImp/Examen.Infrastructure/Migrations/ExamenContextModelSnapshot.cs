﻿// <auto-generated />
using System;
using Examen.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    [DbContext(typeof(ExamenContext))]
    partial class ExamenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AcitivitePack", b =>
                {
                    b.Property<int>("AcitiviteListAcitiviteId")
                        .HasColumnType("int");

                    b.Property<int>("PacksPackId")
                        .HasColumnType("int");

                    b.HasKey("AcitiviteListAcitiviteId", "PacksPackId");

                    b.HasIndex("PacksPackId");

                    b.ToTable("AcitivitePack");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Acitivite", b =>
                {
                    b.Property<int>("AcitiviteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AcitiviteId"), 1L, 1);

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.Property<string>("TypeService")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("AcitiviteId");

                    b.ToTable("Acitivites");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Client", b =>
                {
                    b.Property<int>("Identifiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Identifiant"), 1L, 1);

                    b.Property<int>("ConseillerFK")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Identifiant");

                    b.HasIndex("ConseillerFK");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Conseiller", b =>
                {
                    b.Property<int>("ConseillerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConseillerId"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("ConseillerId");

                    b.ToTable("Conseillers");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Pack", b =>
                {
                    b.Property<int>("PackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PackId"), 1L, 1);

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duree")
                        .HasColumnType("int");

                    b.Property<string>("IntitulePack")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("NbPlaces")
                        .HasColumnType("int");

                    b.HasKey("PackId");

                    b.ToTable("Packs");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Reservation", b =>
                {
                    b.Property<int>("PackFk")
                        .HasColumnType("int");

                    b.Property<int>("ClientFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateReservation")
                        .HasColumnType("datetime2");

                    b.Property<int>("NbPersonnes")
                        .HasColumnType("int");

                    b.HasKey("PackFk", "ClientFk", "DateReservation");

                    b.HasIndex("ClientFk");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("AcitivitePack", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Acitivite", null)
                        .WithMany()
                        .HasForeignKey("AcitiviteListAcitiviteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.ApplicationCore.Domain.Pack", null)
                        .WithMany()
                        .HasForeignKey("PacksPackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Acitivite", b =>
                {
                    b.OwnsOne("Examen.ApplicationCore.Domain.Zone", "Zone", b1 =>
                        {
                            b1.Property<int>("AcitiviteId")
                                .HasColumnType("int");

                            b1.Property<string>("Pays")
                                .IsRequired()
                                .HasMaxLength(15)
                                .HasColumnType("nvarchar(15)");

                            b1.Property<string>("Ville")
                                .IsRequired()
                                .HasMaxLength(15)
                                .HasColumnType("nvarchar(15)");

                            b1.HasKey("AcitiviteId");

                            b1.ToTable("Acitivites");

                            b1.WithOwner()
                                .HasForeignKey("AcitiviteId");
                        });

                    b.Navigation("Zone")
                        .IsRequired();
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Client", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Conseiller", "Conseiller")
                        .WithMany("Clients")
                        .HasForeignKey("ConseillerFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conseiller");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Reservation", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Client", "Client")
                        .WithMany("Reservations")
                        .HasForeignKey("ClientFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.ApplicationCore.Domain.Pack", "Pack")
                        .WithMany("Reservations")
                        .HasForeignKey("PackFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Pack");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Client", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Conseiller", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Pack", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
