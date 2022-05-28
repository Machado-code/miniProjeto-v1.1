using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniProjeto.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CreatingProduto(modelBuilder);
            CreatingCategoria(modelBuilder);
        }


        private void CreatingProduto(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                    .Property(p => p.Nome)
                        .HasMaxLength(80);

            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                    .HasPrecision(10, 2);

            modelBuilder.Entity<Produto>()
                .HasData(
                    new Produto { Id = 1, Nome = "Celular Samsung", Preco = 7.95M, Estoque = 10 },
                    new Produto { Id = 2, Nome = "TV Samsung", Preco = 2.30M, Estoque = 30 },
                    new Produto { Id = 3, Nome = "Celular Motorola", Preco = 6.40M, Estoque = 15 },
                    new Produto { Id = 4, Nome = "Phone de Ouvido", Preco = 3.50M, Estoque = 20 },
                    new Produto { Id = 5, Nome = "Carregador", Preco = 3.105M, Estoque = 10 }
                );
        }
        private void CreatingCategoria(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(p => p.Nome_categoria)
                    .HasMaxLength(80);

            modelBuilder.Entity<Categoria>()
                .HasData(
                    new Categoria { Id = 1, Nome_categoria = "Acessorios" },
                    new Categoria { Id = 2, Nome_categoria = "TVs" },
                    new Categoria { Id = 3, Nome_categoria = "SmartPhones" },
                    new Categoria { Id = 4, Nome_categoria = "Desktops" },
                    new Categoria { Id = 5, Nome_categoria = "LapTop" }
                );
        }
    }
}
