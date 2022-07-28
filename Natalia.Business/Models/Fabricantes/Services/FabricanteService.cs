using Natalia.Business.Models.Fabricantes.Repositories;
using System;
using System.Threading.Tasks;

namespace Natalia.Business.Models.Fabricantes.Services
{
    public class FabricanteService : IFabricanteService
    {
        private readonly IFabricanteRepository _fabricanteRepository;

        public FabricanteService(IFabricanteRepository fabricanteRepository)
        {
            _fabricanteRepository = fabricanteRepository;
        }

        public async Task Adicionar(Fabricante fabricante)
        {
            await _fabricanteRepository.Adicionar(fabricante);
        }

        public async Task Atualizar(Fabricante fabricante)
        {
            await _fabricanteRepository.Atualizar(fabricante);
        }

        public void Dispose()
        {
            _fabricanteRepository?.Dispose();
        }

        public async Task Remover(Guid id)
        {
            await _fabricanteRepository.Remover(id);
        }
    }
}
