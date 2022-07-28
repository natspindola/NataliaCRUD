using Natalia.Business.Models.Fabricantes;
using Natalia.Business.Models.Fabricantes.Repositories;
using Natalia.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natalia.Data.Repositories.Fabricantes
{
    public class FabricanteRepository : Repository<Fabricante>, IFabricanteRepository
    {
        public FabricanteRepository(MeuDbContext context) : base(context) { }
    }
}
