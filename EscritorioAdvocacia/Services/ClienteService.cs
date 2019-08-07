using EscritorioAdvocacia.Models;
using System.Collections.Generic;
using System.Linq;

namespace EscritorioAdvocacia.Services {
    public class ClienteService {
        private readonly EscritorioAdvocaciaContext _context;
        public ClienteService(EscritorioAdvocaciaContext context) {
            _context = context;
        }
        public List<Cliente> FindAll() {
           return _context.Cliente.OrderBy(x => x.Nome).ToList();
        }
    }
}
