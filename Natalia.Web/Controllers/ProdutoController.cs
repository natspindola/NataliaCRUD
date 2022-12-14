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

        public ActionResult Index()
        {
            var retorno = _mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoService.ObterTodos());

            return View(retorno);
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            var viewModel = new ProdutoViewModel();

            await AjustarViewModel(viewModel);

            return View(viewModel);
        }

        private async Task AjustarViewModel(ProdutoViewModel viewModel)
        {
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
        }

        [HttpPost]
        public async Task<ActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            var entidade = _mapper.Map<Produto>(produtoViewModel);

            await _produtoService.Adicionar(entidade);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet, ActionName("Delete")]
        public async Task<ActionResult> Delete(int id)
        {
            await _produtoService.Remover(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet, ActionName("Edit")]
        public async Task<ActionResult> Edit(int id)
        {
            var entidade = await _produtoService.BuscarPorId(id);

            var retorno = _mapper.Map<ProdutoViewModel>(entidade);

            await AjustarViewModel(retorno);

            return View(retorno);
        }

        [HttpPost, ActionName("Edit")]
        public async Task<ActionResult> Edit(ProdutoViewModel produtoViewModel)
        {
            var entidade = _mapper.Map<Produto>(produtoViewModel);

            await _produtoService.Atualizar(entidade);

            return RedirectToAction(nameof(Index));
        }
    }
}
