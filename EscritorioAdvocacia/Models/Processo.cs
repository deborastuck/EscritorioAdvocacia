using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace EscritorioAdvocacia.Models {
    public class Processo {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Número do Processo")]
        public string Numero { get; set; }
        public string Estado { get; set; }       
        public string Status { get; set; }
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Valor { get; set; }
        [Display(Name = "Data de Criação")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public Cliente  Cliente { get; set; }

        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        public Processo() {

        }
        public Processo(int id, string numero, string estado, string status, double valor, DateTime data, Cliente cliente) {
            Id = id;
            Numero = numero;
            Estado = estado;
            Status = status;
            Valor = valor;
            Data = data;
            Cliente = cliente;
        }

       
    }
}
