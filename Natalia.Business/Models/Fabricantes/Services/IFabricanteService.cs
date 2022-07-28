﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Natalia.Business.Models.Fabricantes.Services
{
    public interface IFabricanteService : IDisposable
    {
        Task Adicionar(Fabricante fabricante);
        Task Atualizar(Fabricante fabricante);
        Task Remover(Guid id);
        Task<List<Fabricante>> ObterTodos();
        Task<Fabricante> BuscarPorId(Guid id);

    }
}
