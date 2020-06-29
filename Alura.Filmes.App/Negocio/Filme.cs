using Alura.Filmes.App.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string ReleaseYear { get; set; }
        public short Length { get; set; }
        public string TextoClassificacao { get; private set; }
        public Rating Classificacao
        {
            get
            {
                return TextoClassificacao.ParaValor();
            }
            set
            {
                TextoClassificacao = value.ParaString();
            }
        }
        public IList<FilmeAtor> Atores { get; set; }
        public IList<FilmeCategoria> Categorias { get; set; }
        public Idioma IdiomaFalado { get; set; }
        public Idioma IdiomaOriginal { get; set; }
        


        public Filme()
        {
            Atores = new List<FilmeAtor>();
            Categorias = new List<FilmeCategoria>();
        }

        public override string ToString()
        {
            return $"{Id}\t{Titulo}\t{Descricao}\t{ReleaseYear}\t{Length}\t{Classificacao}";
        }

    }
}
