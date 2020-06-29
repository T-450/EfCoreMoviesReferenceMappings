using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Alura.Filmes.App.Dados
{
    public class PessoaConfig<T> : IEntityTypeConfiguration<T> where T: Pessoa
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder
                .Property(it => it.PrimeiroNome)
                .HasColumnName("first_name")
                .HasColumnType("varchar(45)")
                .IsRequired();

            builder
                .Property(it => it.UltimoNome)
                .HasColumnName("last_name")
                .HasColumnType("varchar(45)")
                .IsRequired();

            builder
                .Property(it => it.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(50)");

            builder
                .Property(it => it.Ativo)
                .HasColumnName("active")
                .IsRequired();

            builder
             .Property<DateTime>("last_update")
             .HasDefaultValueSql("getdate()");
        }
    }
}
