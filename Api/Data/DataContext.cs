using AGREGAMENTO.Models;
using Microsoft.EntityFrameworkCore;

namespace AGREGAMENTO.Data
{
    public class DataContext : DbContext
    {
        public DbSet<DadosDoColaboradorModel> Colaboradores { get; set; }
       
        public DbSet<CadastroDeFabricanteModel> Fabricantes { get; set; }
       
        public DbSet<AgregadosAcompanhamentoModel> Agregados { get; set; }
        public DbSet<CadastroDeValoresModel> Valores { get; set; }
        


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}
