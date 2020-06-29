namespace Alura.Filmes.App.Negocio
{
    public class Funcionario: Pessoa
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public override string ToString()
        {
            return $"{Id}\t\t{PrimeiroNome}\t\t{UltimoNome}\t\t{Email}\t\t{Ativo}\t\t{Login}\t\t{Senha}";
        }
    }
}