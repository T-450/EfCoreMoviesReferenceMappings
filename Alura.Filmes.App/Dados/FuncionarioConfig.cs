using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alura.Filmes.App.Dados
{
    public class FuncionarioConfig : PessoaConfig<Funcionario>
    {
        public override void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            base.Configure(builder);

            builder.ToTable("staff");
            builder
                .Property(it => it.Id)
                .HasColumnName("staff_id");

            builder
                .Property(it => it.Login)
                .HasColumnName("username")
                .HasColumnType("varchar(40");

            builder
               .Property(it => it.Senha)
               .HasColumnName("password")
               .HasColumnType("varchar(40");
        }
    }
}