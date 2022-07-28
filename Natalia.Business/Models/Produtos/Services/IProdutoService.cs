using Natalia.Business.Models.Fabricantes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Natalia.Business.Models.Produtos.Services
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
        List<Produto> ObterTodos();
    }
}
