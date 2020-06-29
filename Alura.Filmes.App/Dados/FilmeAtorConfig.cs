using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    class FilmeAtorConfig : IEntityTypeConfiguration<FilmeAtor>
    {
        public void Configure(EntityTypeBuilder<FilmeAtor> builder)
        {
            builder.ToTable("film_actor");
            builder.Property<int>("actor_id");
            builder.Property<int>("film_id");
            builder
                .HasKey("actor_id", "film_id");

            builder.Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");

            builder
                .HasOne<Filme>(fa => fa.Filme)
                .WithMany(f => f.Atores)
                .HasForeignKey("film_id");
            builder
                .HasOne<Ator>(fa => fa.Ator)
                .WithMany(fa => fa.Filmografia)
                .HasForeignKey("actor_id");
        }
    }
}
