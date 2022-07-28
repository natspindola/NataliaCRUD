using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Natalia.Web.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {
            this.Categorias = new List<string>();
            this.Fabricantes = new List<FabricanteViewModel>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public FabricanteViewModel Fabricante { get; set; }

        public int FabricanteId { get; set; }

        public string Categoria { get; set; }

        public decimal Preco { get; set; }

        [NotMapped]
        public IEnumerable<FabricanteViewModel> Fabricantes { get; set; }

        [NotMapped]
        public IEnumerable<string> Categorias { get; set; }
    }
}
