using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Alura.Filmes.App.Dados
{
    public class AtorConfig : IEntityTypeConfiguration<Ator>
    {
        public void Configure(EntityTypeBuilder<Ator> builder)
        {
            builder
                .ToTable("actor")
                .Property(it => it.Id)
                .HasColumnName("actor_id");

            builder
                .Property(it => it.PrimeiroNome)
                .HasColumnName("first_name")
                .HasColumnType("nvarchar(45)")
                .IsRequired();

            builder
                .Property(it => it.UltimoNome)
                .HasColumnName("last_name")
                .HasColumnType("nvarchar(45)")
                .IsRequired();

            builder
                .Property<DateTime>("last_update")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

            builder
                .HasIndex(a => a.UltimoNome)
                .HasName("index_actor_lastname");

            builder
                .HasAlternateKey(a => new { a.PrimeiroNome, a.UltimoNome });
        }
    }
}
