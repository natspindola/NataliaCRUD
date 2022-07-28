using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natalia.Web.ViewModels
{
    public class ProdutoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public FabricanteViewModel Fabricante { get; set; }

        public string Categoria { get; set; }

        public decimal Preco { get; set; }
    }
}
