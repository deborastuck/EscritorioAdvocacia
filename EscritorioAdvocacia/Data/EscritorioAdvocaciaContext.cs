using Microsoft.EntityFrameworkCore;

namespace EscritorioAdvocacia.Models
{
    public class EscritorioAdvocaciaContext : DbContext
    {
        public EscritorioAdvocaciaContext (DbContextOptions<EscritorioAdvocaciaContext> options)
            : base(options)
        {
        }

        public DbSet<EscritorioAdvocacia.Models.Cliente> Cliente { get; set; }
        public DbSet<EscritorioAdvocacia.Models.Processo> Processo { get; set; }
    }
}
