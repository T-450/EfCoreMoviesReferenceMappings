using Alura.Filmes.App.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Extensions
{
    public static class RatingExtensions
    {
        private static Dictionary<string, Rating> mapa = new Dictionary<string, Rating>
        {
            { "G", Rating.G },
            { "PG", Rating.PG },
            { "PG-13", Rating.G},
            { "R", Rating.PG13 },
            { "NC-17", Rating.NC17 }
        };

        public static string ParaString(this Rating valor)
        {
            return mapa.First(c => c.Value == valor).Key;
        }

        public static Rating ParaValor(this string texto)
        {
            return mapa.First(c => c.Key == texto).Value;
        }
    }
}
