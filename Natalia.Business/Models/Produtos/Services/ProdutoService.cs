using Natalia.Business.Models.Fabricantes;
using Natalia.Business.Models.Produtos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natalia.Business.Models.Produtos.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produto produto)
        {
            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            await _produtoRepository.Atualizar(produto);
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }

        public List<Produto> ObterTodos()
        {
            return this._produtoRepository.Consultar().ToList();
        }

        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }
    }
}
