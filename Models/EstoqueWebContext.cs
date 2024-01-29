using Microsoft.EntityFrameworkCore;

namespace AULA15CONTROLEESTOQUE.Models
{
    public class EstoqueWebContext : DbContext
    {
        public DbSet<CategoriaModel> Categorias {get;set;}

        public EstoqueWebContext(DbContextOptions<EstoqueWebContext> options)
        :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaModel>().ToTable("Categoria");
        }
    }
}