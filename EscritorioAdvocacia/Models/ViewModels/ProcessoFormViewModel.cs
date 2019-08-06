using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscritorioAdvocacia.Models.ViewModels {
    public class ProcessoFormViewModel {
        public Processo Processo { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}
