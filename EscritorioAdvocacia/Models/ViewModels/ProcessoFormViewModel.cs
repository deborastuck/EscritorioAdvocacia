using System.Collections.Generic;

namespace EscritorioAdvocacia.Models.ViewModels {
    public class ProcessoFormViewModel {
        public Processo Processo { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}
