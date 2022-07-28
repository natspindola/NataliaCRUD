using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Natalia.Business.Models.Fabricantes;
using Natalia.Business.Models.Fabricantes.Services;
using Natalia.Business.Models.Produtos.Services;
using Natalia.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natalia.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly IFabricanteService _fabricanteService;
        private readonly IMapper _mapper;

        public ProdutoController(IProdutoService produtoService, IMapper mapper, 
            IFabricanteService fabricanteService)
        {
            _produtoService = produtoService;
            _mapper = mapper;
            _fabricanteService = fabricanteService;
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            var viewModel = new ProdutoViewModel();

            var fabricantes = await _fabricanteService.ObterTodos();

            viewModel.Fabricantes = _mapper.Map<List<FabricanteViewModel>>(fabricantes);

            var categorias = fabricantes
                .Select(a => new { a.Categoria1, a.Categoria2, a.Categoria3 })
                .ToList();

            var lista = new List<string>();

            foreach (var item in categorias)
            {
                lista.Add(item.Categoria1);
                lista.Add(item.Categoria2);
                lista.Add(item.Categoria3);
            }

            viewModel.Categorias = lista.Distinct().ToList();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            var entidade = _mapper.Map<Produto>(produtoViewModel);

            await _produtoService.Adicionar(entidade);

            return View();
        }
    }
}
