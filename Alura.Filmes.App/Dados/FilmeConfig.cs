using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    public class FilmeConfig : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            //Filmes
            builder
                .ToTable("film")
                .Property(it => it.Id)
                .HasColumnName("film_id")
                .HasColumnType("int");

            builder
                .Property(it => it.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder
                .Property(it => it.Descricao)
                .HasColumnName("description")
                .HasColumnType("text");

            builder
                .Property(it => it.ReleaseYear)
                .HasColumnName("release_year")
                .HasColumnType("varchar(4)");

            builder
                .Property(it => it.Length)
                .HasColumnName("length")
                .HasColumnType("smallint");

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

            builder
                .Property<byte>("language_id");
            builder
                .Property<byte?>("original_language_id");

            builder
                .HasOne(f => f.IdiomaFalado)
                .WithMany(i => i.FilmesFalados)
                .HasForeignKey("language_id")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(f => f.IdiomaOriginal)
                .WithMany(i => i.FilmesOriginais)
                .HasForeignKey("original_language_id")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasIndex("original_language_id")
                .HasName("index_idioma_falado_id")
                .ForSqlServerIsClustered(false);

            builder
                .HasIndex("language_id")
                .HasName("index_original_linguage_id")
                .ForSqlServerIsClustered(false);

            builder
                .Property(f => f.TextoClassificacao)
                .HasColumnName("rating")
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder
                .Ignore(f => f.Classificacao);
                
        }
    }
}
