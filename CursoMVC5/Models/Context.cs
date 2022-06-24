using Microsoft.EntityFrameworkCore;

namespace CursoMVC5.Models
{
    public class Context: DbContext
    {
        public virtual DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString:@"Server = localhost\SQLEXPRESS; Database = master; Trusted_Connection = True;");
        }
    }
}
