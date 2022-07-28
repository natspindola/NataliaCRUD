using Natalia.Business.Models.Fabricantes;
using Natalia.Business.Models.Produtos.Repositories;
using Natalia.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natalia.Data.Repositories.Produtos
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) : base(context) { }
    }
}
