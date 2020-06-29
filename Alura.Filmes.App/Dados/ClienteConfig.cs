using Alura.Filmes.App.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Alura.Filmes.App
{
    public class ClienteConfig : PessoaConfig<Cliente>
    {
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);

            builder.ToTable("customer");

            builder
                .Property(it => it.Id)
                .HasColumnName("customer_id")
                .HasColumnType("tinyint");

            builder
                .Property<DateTime>("create_date")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

        }
    }
}