﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using miniProjeto.Data;

namespace miniProjeto.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("miniProjeto.Data.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4");

                    b.Property<decimal>("Preco")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estoque = 10,
                            Nome = "Caderno",
                            Preco = 7.95m
                        },
                        new
                        {
                            Id = 2,
                            Estoque = 30,
                            Nome = "Borracha",
                            Preco = 2.30m
                        },
                        new
                        {
                            Id = 3,
                            Estoque = 15,
                            Nome = "Estojo",
                            Preco = 6.40m
                        },
                        new
                        {
                            Id = 4,
                            Estoque = 20,
                            Nome = "Lapseira",
                            Preco = 3.50m
                        },
                        new
                        {
                            Id = 5,
                            Estoque = 10,
                            Nome = "Caneta",
                            Preco = 3.105m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}