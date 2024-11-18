﻿// <auto-generated />
using System;
using FrailynGarcia_AP1_P2.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FrailynGarcia_AP1_P2.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20241118231906_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FrailynGarcia_AP1_P2.Models.ArticulosPC", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticuloId"));

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Existencia")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("ArticuloId");

                    b.ToTable("ArticulosPC");

                    b.HasData(
                        new
                        {
                            ArticuloId = 1,
                            Costo = 700.0,
                            Descripcion = "Monitor",
                            Existencia = 50,
                            Precio = 1400.0
                        },
                        new
                        {
                            ArticuloId = 2,
                            Costo = 120.0,
                            Descripcion = "Mouse",
                            Existencia = 100,
                            Precio = 500.0
                        },
                        new
                        {
                            ArticuloId = 3,
                            Costo = 300.0,
                            Descripcion = "Teclado",
                            Existencia = 70,
                            Precio = 1500.0
                        },
                        new
                        {
                            ArticuloId = 4,
                            Costo = 700.0,
                            Descripcion = "CPU",
                            Existencia = 50,
                            Precio = 1700.0
                        },
                        new
                        {
                            ArticuloId = 5,
                            Costo = 350.0,
                            Descripcion = "Memoria Ram",
                            Existencia = 40,
                            Precio = 1300.0
                        });
                });

            modelBuilder.Entity("FrailynGarcia_AP1_P2.Models.Combos", b =>
                {
                    b.Property<int>("ComboId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComboId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<bool>("Vendido")
                        .HasColumnType("bit");

                    b.HasKey("ComboId");

                    b.ToTable("Combos");
                });

            modelBuilder.Entity("FrailynGarcia_AP1_P2.Models.CombosDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("ComboId")
                        .HasColumnType("int");

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.HasKey("DetalleId");

                    b.HasIndex("ComboId");

                    b.ToTable("CombosDetalle");
                });

            modelBuilder.Entity("FrailynGarcia_AP1_P2.Models.CombosDetalle", b =>
                {
                    b.HasOne("FrailynGarcia_AP1_P2.Models.Combos", "Combos")
                        .WithMany("CombosDetalle")
                        .HasForeignKey("ComboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Combos");
                });

            modelBuilder.Entity("FrailynGarcia_AP1_P2.Models.Combos", b =>
                {
                    b.Navigation("CombosDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}