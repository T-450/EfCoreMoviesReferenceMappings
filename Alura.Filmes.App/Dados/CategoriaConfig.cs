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
    public class CategoriaConfig : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            // Categoria
            builder
                .ToTable("category");
            builder
                .Property<byte>(it => it.Id)
                .HasColumnName("category_id")
                .HasColumnType("tinyint");

            builder
                .Property(it => it.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property<DateTime>("last_update")
                .HasDefaultValueSql("getdate()");
        }
    }
}
