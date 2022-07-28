using Microsoft.EntityFrameworkCore;
using Natalia.Business.Models.Fabricantes;
using Natalia.Business.Models.Produtos.Repositories;
using Natalia.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natalia.Data.Repositories.Produtos
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) : base(context) { }

        public override IQueryable<Produto> Consultar()
        {
            return base.Consultar()
                .Include(a => a.Fabricante);
        }
    }
}
