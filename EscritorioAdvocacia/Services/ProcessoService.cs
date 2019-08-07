using EscritorioAdvocacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EscritorioAdvocacia.Services {
    public class ProcessoService {
        private readonly EscritorioAdvocaciaContext _context;
        public ProcessoService(EscritorioAdvocaciaContext context) {
            _context = context;
        }

        public List<Processo> FindAll() {
           return _context.Processo.ToList();
        }
        public void Insert(Processo obj) {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public double SomaAtivos() {
            return _context.Processo.Where(p => p.Status == "ativo").Sum(p => p.Valor);
        }

        public double Media() {
            var procMedia = from p in _context.Processo
                             join c in _context.Cliente on p.ClienteId equals c.Id into cl
                             from c in cl.DefaultIfEmpty()
                             where p.Estado == "Rio de Janeiro" && c.Nome == "Empresa A"
                             select p.Valor;
            return procMedia.Average();
        }

        public int QuantidadeProcesso() {
           return _context.Processo.Count(p => p.Valor > 100000);
        }

        public List<Processo> ProcessosMes() {
            return _context.Processo.Where(p => p.Data >= new DateTime(2007, 09, 01) && p.Data <= new DateTime(2007, 09, 30)).ToList();
        }

        public List<Processo> ProcessoEstado() {
            var procEstado = from p in _context.Processo
                          join c in _context.Cliente on p.ClienteId equals c.Id into cl
                          from c in cl.DefaultIfEmpty()
                          where p.Estado == c.Estado
                          select p;
            return procEstado.ToList();
        }

        public List<Processo> ProcessosTrab() {
            return _context.Processo.Where(p => p.Numero.Contains("TRAB")).ToList();
        }   
    }
}
