using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alura.Filmes.App.Negocio
{
    public class Categoria
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public IList<FilmeCategoria> Filmes { get; set; }
        public Categoria()
        {
            Filmes = new List<FilmeCategoria>();
        }

        public override string ToString()
        {
            return $"{Id}\t\t{Name}\n";
        }
    }
}
