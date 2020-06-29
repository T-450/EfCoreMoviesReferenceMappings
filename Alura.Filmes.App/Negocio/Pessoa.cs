using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Pessoa
    {
        public byte Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }

        public override string ToString()
        {
            var name = this.GetType();
            return $"{name}:\n {PrimeiroNome}\t\t{UltimoNome}\t\t{Email}\t\t{Ativo}";
        }
    }
}
