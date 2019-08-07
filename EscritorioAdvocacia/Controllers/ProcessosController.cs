using Microsoft.AspNetCore.Mvc;
using EscritorioAdvocacia.Models;
using EscritorioAdvocacia.Models.ViewModels;
using EscritorioAdvocacia.Services;

namespace EscritorioAdvocacia.Controllers {
    public class ProcessosController : Controller {
        private readonly ProcessoService _processoService;
        private readonly ClienteService _clienteService;
        public ProcessosController(ProcessoService processoService, ClienteService clienteService) {
            _processoService = processoService;
            _clienteService = clienteService;
        }

        public IActionResult Index() {
            var list = _processoService.FindAll();
            return View(list);
        }

        public IActionResult Create() {
            var clientes = _clienteService.FindAll();
            var viewModel = new ProcessoFormViewModel { Clientes = clientes };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Processo processo) {
            _processoService.Insert(processo);
            return RedirectToAction(nameof(Index));

        }
    }
}
