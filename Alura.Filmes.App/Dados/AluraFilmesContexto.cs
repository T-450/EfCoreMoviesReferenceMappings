using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.Filmes.App.Dados
{
    public class AluraFilmesContexto : DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<FilmeAtor> Elenco { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FilmeCategoria> FilmeCategoria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AluraFilmes;Trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreach (var fks in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    fks.DeleteBehavior = DeleteBehavior.Restrict;
            //}
            modelBuilder.ApplyConfiguration<Funcionario>(new FuncionarioConfig());
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfig());
            modelBuilder.ApplyConfiguration<Ator>(new AtorConfig());
            modelBuilder.ApplyConfiguration<Filme>(new FilmeConfig());
            modelBuilder.ApplyConfiguration<Categoria>(new CategoriaConfig());
            modelBuilder.ApplyConfiguration<FilmeAtor>(new FilmeAtorConfig());
            modelBuilder.ApplyConfiguration<FilmeCategoria>(new FilmeCategoriaConfig());
            modelBuilder.ApplyConfiguration<Idioma>(new IdiomaConfig());
        }
    }
}
