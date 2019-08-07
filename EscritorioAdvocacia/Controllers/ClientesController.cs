using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EscritorioAdvocacia.Models;
using EscritorioAdvocacia.Services;

namespace EscritorioAdvocacia.Controllers
{
    public class ClientesController : Controller
    {
        private readonly EscritorioAdvocaciaContext _context;

        public ClientesController(EscritorioAdvocaciaContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public IActionResult Index()
        {
            var clienteServce = new ClienteService(_context);
            var list = clienteServce.FindAll();
            return View(list);
        }


        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Cnpj,Estado")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }
    }
}
