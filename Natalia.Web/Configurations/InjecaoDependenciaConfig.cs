using Microsoft.Extensions.DependencyInjection;
using Natalia.Business.Models.Fabricantes.Repositories;
using Natalia.Business.Models.Fabricantes.Services;
using Natalia.Business.Models.Produtos.Repositories;
using Natalia.Business.Models.Produtos.Services;
using Natalia.Data.Context;
using Natalia.Data.Repositories.Fabricantes;
using Natalia.Data.Repositories.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natalia.Web.Configurations
{
    public static class InjecaoDependenciaConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFabricanteRepository, FabricanteRepository>();
            services.AddScoped<IFabricanteService, FabricanteService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
