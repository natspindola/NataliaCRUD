using System;
using System.Collections.Generic;
using System.Text;

namespace Natalia.Business.Models.Fabricantes
{
    public class Produto : Entity
    {
        public Produto()
        {

        }

        public Produto(string nome, Fabricante fabricante, string categoria, decimal preco)
        {
            Nome = nome;
            Fabricante = fabricante;
            Categoria = categoria;
            Preco = preco;
        }

        public string Nome { get; private set; }

        public Fabricante Fabricante { get; private set; }
        public Guid FabricanteId { get; set; }

        public string Categoria { get; private set; }

        public decimal Preco { get; private set; }

    }
}
