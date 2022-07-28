using System;
using System.Threading.Tasks;

namespace Natalia.Business.Models.Fabricantes.Services
{
    public interface IFabricanteService : IDisposable
    {
        Task Adicionar(Fabricante fabricante);
        Task Atualizar(Fabricante fabricante);
        Task Remover(Guid id);
    }
}
