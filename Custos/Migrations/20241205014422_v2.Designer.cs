﻿// <auto-generated />
using Custos.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Custos.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241205014422_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Custos.Models.Custo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FilmeId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ValorBilheteCinema")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorBilheteria")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorMidiaFisica")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorProducao")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorTotalArecadado")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Custo");
                });
#pragma warning restore 612, 618
        }
    }
}
