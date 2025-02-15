﻿// <auto-generated />
using System;
using Examen.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    [DbContext(typeof(ExamenContext))]
    [Migration("20240514131558_migrini")]
    partial class migrini
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Ctegorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ctegories");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Fournisseur", b =>
                {
                    b.Property<int>("Identifiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Identifiant"), 1L, 1);

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Identifiant");

                    b.ToTable("Fournisseurs");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Produit", b =>
                {
                    b.Property<int>("ProduitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProduitId"), 1L, 1);

                    b.Property<int>("CategorieFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateProd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("TypeProduit")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("ProduitId");

                    b.HasIndex("CategorieFk");

                    b.ToTable("Produits");

                    b.HasDiscriminator<string>("TypeProduit").HasValue("P");
                });

            modelBuilder.Entity("FournisseurProduit", b =>
                {
                    b.Property<int>("FournisseursIdentifiant")
                        .HasColumnType("int");

                    b.Property<int>("ProduitListProduitId")
                        .HasColumnType("int");

                    b.HasKey("FournisseursIdentifiant", "ProduitListProduitId");

                    b.HasIndex("ProduitListProduitId");

                    b.ToTable("Facture", (string)null);
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Biologique", b =>
                {
                    b.HasBaseType("Examen.ApplicationCore.Domain.Produit");

                    b.Property<string>("Composition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("B");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Chimique", b =>
                {
                    b.HasBaseType("Examen.ApplicationCore.Domain.Produit");

                    b.Property<string>("NomLab")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("C");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Produit", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Ctegorie", "Ctegorie")
                        .WithMany("Produits")
                        .HasForeignKey("CategorieFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ctegorie");
                });

            modelBuilder.Entity("FournisseurProduit", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Fournisseur", null)
                        .WithMany()
                        .HasForeignKey("FournisseursIdentifiant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.ApplicationCore.Domain.Produit", null)
                        .WithMany()
                        .HasForeignKey("ProduitListProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Ctegorie", b =>
                {
                    b.Navigation("Produits");
                });
#pragma warning restore 612, 618
        }
    }
}
