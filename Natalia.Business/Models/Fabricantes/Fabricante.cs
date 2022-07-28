using System;
using System.Collections.Generic;
using System.Text;

namespace Natalia.Business.Models.Fabricantes
{
    public class Fabricante : Entity
    {
        public Fabricante()
        {

        }

        public Fabricante(string nome, string categoria1, string categoria2, string categoria3)
        {
            Nome = nome;
            Categoria1 = categoria1;
            Categoria2 = categoria2;
            Categoria3 = categoria3;
        }

        public string Nome { get; private set; }
        public string Categoria1 { get; private set; }
        public string Categoria2 { get; private set; }
        public string Categoria3 { get; private set; }
    }
}
