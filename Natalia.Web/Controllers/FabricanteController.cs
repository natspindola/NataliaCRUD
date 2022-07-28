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

            return View();
        }
    }
}
