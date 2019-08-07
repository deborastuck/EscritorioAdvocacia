using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EscritorioAdvocacia.Models {
    public class Cliente {
        public string Nome { get; set; }
        [Key]
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string Estado { get; set; }
        public ICollection<Processo> Processos { get; set; } = new List<Processo>();

        public Cliente() {
        }

        public Cliente(int id, string nome, string cnpj, string estado) {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            Estado = estado;
        }
    }
}
