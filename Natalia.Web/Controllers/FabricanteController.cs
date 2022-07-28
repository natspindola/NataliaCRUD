using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Natalia.Business.Models.Fabricantes;
using Natalia.Business.Models.Fabricantes.Services;
using Natalia.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natalia.Web.Controllers
{
    public class FabricanteController : Controller
    {
        private readonly IFabricanteService _fabricanteService;
        private readonly IMapper _mapper;

        public FabricanteController(IFabricanteService fabricanteService, IMapper mapper)
        {
            _fabricanteService = fabricanteService;
            _mapper = mapper;
        }

        public async Task<ActionResult> Index()
        {
            var retorno = _mapper.Map<IEnumerable<FabricanteViewModel>>(await _fabricanteService.ObterTodos());

            return View(retorno);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new FabricanteViewModel());
        }

        [HttpPost]
        public async Task<ActionResult> Create(FabricanteViewModel fabricanteViewModel)
        {
            var entidade = _mapper.Map<Fabricante>(fabricanteViewModel);

            await _fabricanteService.Adicionar(entidade);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet, ActionName("Delete")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _fabricanteService.Remover(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet, ActionName("Edit")]
        public async Task<ActionResult> Edit(Guid id)
        {
            var entidade = await _fabricanteService.BuscarPorId(id);

            var retorno = _mapper.Map<FabricanteViewModel>(entidade);

            return View(retorno);
        }

        [HttpPost, ActionName("Edit")]
        public async Task<ActionResult> Edit(FabricanteViewModel fabricanteViewModel)
        {
            var entidade = _mapper.Map<Fabricante>(fabricanteViewModel);

            await _fabricanteService.Atualizar(entidade);

            return RedirectToAction(nameof(Index));
        }



    }
}
