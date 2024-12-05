﻿// <auto-generated />
using System;
using Gestao.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gestao.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241205014328_v3")]
    partial class v3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Gestao.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("Lucro")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Nota")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("vl_total")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("Gestao.Models.Teste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Texto")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teste");
                });
#pragma warning restore 612, 618
        }
    }
}