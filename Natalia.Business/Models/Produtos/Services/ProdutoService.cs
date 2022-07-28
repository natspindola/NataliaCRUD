using Natalia.Business.Models.Fabricantes;
using Natalia.Business.Models.Produtos.Repositories;
using System;
using System.Threading.Tasks;

namespace Natalia.Business.Models.Produtos.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _clienteRepository;

        public ProdutoService(IProdutoRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Adicionar(Produto produto)
        {
            await _clienteRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            await _clienteRepository.Atualizar(produto);
        }

        public void Dispose()
        {
            _clienteRepository?.Dispose();
        }

        public async Task Remover(Guid id)
        {
            await _clienteRepository.Remover(id);
        }
    }
}
