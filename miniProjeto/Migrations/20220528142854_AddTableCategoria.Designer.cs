﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using miniProjeto.Data;

namespace miniProjeto.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220528142854_AddTableCategoria")]
    partial class AddTableCategoria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("miniProjeto.Data.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome_categoria")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome_categoria = "Acessorios"
                        },
                        new
                        {
                            Id = 2,
                            Nome_categoria = "TVs"
                        },
                        new
                        {
                            Id = 3,
                            Nome_categoria = "SmartPhones"
                        },
                        new
                        {
                            Id = 4,
                            Nome_categoria = "Desktops"
                        },
                        new
                        {
                            Id = 5,
                            Nome_categoria = "LapTop"
                        });
                });

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
                            Nome = "Celular Samsung",
                            Preco = 7.95m
                        },
                        new
                        {
                            Id = 2,
                            Estoque = 30,
                            Nome = "TV Samsung",
                            Preco = 2.30m
                        },
                        new
                        {
                            Id = 3,
                            Estoque = 15,
                            Nome = "Celular Motorola",
                            Preco = 6.40m
                        },
                        new
                        {
                            Id = 4,
                            Estoque = 20,
                            Nome = "Phone de Ouvido",
                            Preco = 3.50m
                        },
                        new
                        {
                            Id = 5,
                            Estoque = 10,
                            Nome = "Carregador",
                            Preco = 3.105m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
