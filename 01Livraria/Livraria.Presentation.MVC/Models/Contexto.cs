using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Livraria.Presentation.MVC.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base("BDLivraria") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Editora> Editora { get; set; }
        public DbSet<Livro> Livro { get; set; }

    }
}