using LojaVirtual.Dominio.Entidade;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LojaVirtual.Dominio.Repositorio
{
    public class Context : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }
}
